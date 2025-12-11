
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Hazel.Udp
{
  public abstract class UdpConnection : NetworkConnection
  {
    private int keepAliveInterval = 10000;
    private object keepAliveTimerLock = new object();
    private volatile int resendTimeout = 200;
    private Dictionary<ushort, UdpConnection.Packet> reliableDataPacketsSent = new Dictionary<ushort, UdpConnection.Packet>();
    private HashSet<ushort> reliableDataPacketsMissing = new HashSet<ushort>();
    private volatile int resendsBeforeDisconnect = 3;
    private Timer keepAliveTimer;
    private bool keepAliveTimerDisposed;
    private volatile ushort lastIDAllocated;
    private volatile ushort reliableReceiveLast;
    private volatile bool hasReceivedSomething;
    private long totalRoundTime;
    private long totalReliableMessages;

    public int KeepAliveInterval
    {
      get
      {
        return this.keepAliveInterval;
      }
      set
      {
        this.keepAliveInterval = value;
        this.ResetKeepAliveTimer();
      }
    }

    private void InitializeKeepAliveTimer()
    {
      lock (this.keepAliveTimerLock)
        this.keepAliveTimer = new Timer((TimerCallback) (o => this.SendHello((byte[]) null, (Action) null)), (object) null, this.keepAliveInterval, this.keepAliveInterval);
    }

    private void ResetKeepAliveTimer()
    {
      lock (this.keepAliveTimerLock)
        this.keepAliveTimer.Change(this.keepAliveInterval, this.keepAliveInterval);
    }

    private void DisposeKeepAliveTimer()
    {
      lock (this.keepAliveTimerLock)
      {
        if (!this.keepAliveTimerDisposed)
          this.keepAliveTimer.Dispose();
        this.keepAliveTimerDisposed = true;
      }
    }

    public int ResendTimeout
    {
      get
      {
        return this.resendTimeout;
      }
      set
      {
        this.resendTimeout = value;
      }
    }

    public double AveragePing
    {
      get
      {
        long num = Interlocked.Read(ref this.totalReliableMessages);
        return num == 0L ? 0.0 : (double) (Interlocked.Read(ref this.totalRoundTime) / num / 2L);
      }
    }

    public int ResendsBeforeDisconnect
    {
      get
      {
        return this.resendsBeforeDisconnect;
      }
      set
      {
        this.resendsBeforeDisconnect = value;
      }
    }

    private void WriteReliableSendHeader(byte[] bytes, Action ackCallback)
    {
      lock (this.reliableDataPacketsSent)
      {
        ushort key;
        do
        {
          key = ++this.lastIDAllocated;
        }
        while (this.reliableDataPacketsSent.ContainsKey(key));
        bytes[1] = (byte) ((int) key >> 8 & (int) byte.MaxValue);
        bytes[2] = (byte) key;
        UdpConnection.Packet packet = UdpConnection.Packet.GetObject();
        packet.Set(bytes, (Action<UdpConnection.Packet>) (p =>
        {
          lock (p.Timer)
          {
            if (!p.Acknowledged)
            {
              p.Timer.Change(p.LastTimeout *= 2, -1);
              if (++p.Retransmissions > this.ResendsBeforeDisconnect)
              {
                this.HandleDisconnect((HazelException) null);
                p.Acknowledged = true;
                p.Recycle();
                return;
              }
            }
          }
          try
          {
            this.WriteBytesToConnection(p.Data);
          }
          catch (InvalidOperationException ex)
          {
            this.HandleDisconnect(new HazelException("Could not resend data as connection is no longer connected", (Exception) ex));
          }
        }), this.resendTimeout > 0 ? this.resendTimeout : (this.AveragePing != 0.0 ? (int) this.AveragePing * 4 : 200), ackCallback);
        this.reliableDataPacketsSent.Add(key, packet);
      }
    }

    private bool HandleReliableReceive(byte[] bytes)
    {
      ushort num1 = (ushort) (((uint) bytes[1] << 8) + (uint) bytes[2]);
      this.SendAck(bytes[1], bytes[2]);
      lock (this.reliableDataPacketsMissing)
      {
        ushort num2 = (ushort) ((uint) this.reliableReceiveLast - 32768U);
        if (((int) num2 >= (int) this.reliableReceiveLast ? (int) num1 > (int) this.reliableReceiveLast && (int) num1 <= (int) num2 : (int) num1 > (int) this.reliableReceiveLast || (int) num1 <= (int) num2) || !this.hasReceivedSomething)
        {
          for (ushort index = (ushort) ((uint) this.reliableReceiveLast + 1U); (int) index < (int) num1; ++index)
            this.reliableDataPacketsMissing.Add(index);
          this.reliableReceiveLast = num1;
          this.hasReceivedSomething = true;
        }
        else
        {
          if (!this.reliableDataPacketsMissing.Contains(num1))
            return false;
          this.reliableDataPacketsMissing.Remove(num1);
        }
      }
      return true;
    }

    private void HandleAcknowledgement(byte[] bytes)
    {
      ushort key = (ushort) (((uint) bytes[1] << 8) + (uint) bytes[2]);
      lock (this.reliableDataPacketsSent)
      {
        if (!this.reliableDataPacketsSent.ContainsKey(key))
          return;
        UdpConnection.Packet packet = this.reliableDataPacketsSent[key];
        packet.Acknowledged = true;
        if (packet.AckCallback != null)
          packet.AckCallback();
        packet.Stopwatch.Stop();
        Interlocked.Add(ref this.totalRoundTime, (long) packet.Stopwatch.Elapsed.Milliseconds);
        Interlocked.Increment(ref this.totalReliableMessages);
        packet.Recycle();
        this.reliableDataPacketsSent.Remove(key);
      }
    }

    internal void SendAck(byte byte1, byte byte2)
    {
      this.WriteBytesToConnection(new byte[3]
      {
        (byte) 10,
        byte1,
        byte2
      });
    }

    protected UdpConnection()
    {
      this.InitializeKeepAliveTimer();
    }

    protected abstract void WriteBytesToConnection(byte[] bytes);

    public override void SendBytesUnencrypted(byte[] bytes)
    {
      if (this.State != ConnectionState.Connected)
        throw new InvalidOperationException("Could not send data as this Connection is not connected. Did you disconnect?");
      this.HandleSend(bytes, (byte) 0, (Action) null);
    }

    public override void SendBytes(byte[] bytes, SendOption sendOption = SendOption.None)
    {
      if (this.State != ConnectionState.Connected)
        throw new InvalidOperationException("Could not send data as this Connection is not connected. Did you disconnect?");
      this.HandleSend(bytes, (byte) sendOption, (Action) null);
    }

    public override void SendBytesAndClose(byte[] bytes, SendOption sendOption = SendOption.FragmentedReliable)
    {
      throw new NotImplementedException();
    }

    protected void HandleSend(byte[] data, byte sendOption, Action ackCallback = null)
    {
      byte[] bytes;
      if (sendOption == (byte) 1 || sendOption == (byte) 8)
      {
        bytes = new byte[data.Length + 3];
        this.WriteReliableSendHeader(bytes, ackCallback);
      }
      else
        bytes = new byte[data.Length + 1];
      bytes[0] = sendOption;
      Buffer.BlockCopy((Array) data, 0, (Array) bytes, bytes.Length - data.Length, data.Length);
      this.ResetKeepAliveTimer();
      this.WriteBytesToConnection(bytes);
      this.Statistics.LogSend(data.Length, bytes.Length);
    }

    protected byte[] HandleReceive(byte[] buffer, int bytesReceived)
    {
      this.ResetKeepAliveTimer();
      int srcOffset = 1;
      switch (buffer[0])
      {
        case 1:
          srcOffset = 3;
          if (!this.HandleReliableReceive(buffer))
            return (byte[]) null;
          break;
        case 8:
          this.HandleReliableReceive(buffer);
          return (byte[]) null;
        case 9:
          this.HandleDisconnect((HazelException) null);
          return (byte[]) null;
        case 10:
          this.HandleAcknowledgement(buffer);
          return (byte[]) null;
      }
      byte[] numArray = new byte[bytesReceived - srcOffset];
      Buffer.BlockCopy((Array) buffer, srcOffset, (Array) numArray, 0, numArray.Length);
      this.Statistics.LogReceive(numArray.Length, bytesReceived);
      return numArray;
    }

    protected void SendHello(byte[] bytes, Action acknowledgeCallback)
    {
      byte[] data;
      if (bytes == null)
      {
        data = new byte[1];
      }
      else
      {
        data = new byte[bytes.Length + 1];
        Buffer.BlockCopy((Array) bytes, 0, (Array) data, 1, bytes.Length);
      }
      this.HandleSend(data, (byte) 8, acknowledgeCallback);
    }

    protected void SendDisconnect()
    {
      this.HandleSend(new byte[0], (byte) 9, (Action) null);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        this.DisposeKeepAliveTimer();
      base.Dispose(disposing);
    }

    private class Packet : IRecyclable, IDisposable
    {
      private static readonly ObjectPool<UdpConnection.Packet> objectPool = new ObjectPool<UdpConnection.Packet>((Func<UdpConnection.Packet>) (() => new UdpConnection.Packet()));
      public Stopwatch Stopwatch = new Stopwatch();
      public byte[] Data;
      public Timer Timer;
      public volatile int LastTimeout;
      public Action AckCallback;
      public volatile bool Acknowledged;
      public volatile int Retransmissions;

      internal static UdpConnection.Packet GetObject()
      {
        return UdpConnection.Packet.objectPool.GetObject();
      }

      private Packet()
      {
      }

      internal void Set(
        byte[] data,
        Action<UdpConnection.Packet> resendAction,
        int timeout,
        Action ackCallback)
      {
        this.Data = data;
        this.Timer = new Timer((TimerCallback) (obj => resendAction(this)), (object) null, timeout, -1);
        this.LastTimeout = timeout;
        this.AckCallback = ackCallback;
        this.Acknowledged = false;
        this.Retransmissions = 0;
        this.Stopwatch.Reset();
        this.Stopwatch.Start();
      }

      public void Recycle()
      {
        lock (this.Timer)
          this.Timer.Dispose();
        UdpConnection.Packet.objectPool.PutObject(this);
      }

      public void Dispose()
      {
        this.Dispose(true);
        GC.SuppressFinalize((object) this);
      }

      protected void Dispose(bool disposing)
      {
        if (!disposing)
          return;
        lock (this.Timer)
          this.Timer.Dispose();
      }
    }
  }
}
