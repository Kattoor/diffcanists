
using System;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Udp
{
  public sealed class UdpClientConnection : UdpConnection
  {
    private object socketLock = new object();
    private byte[] dataBuffer = new byte[(int) ushort.MaxValue];
    private Socket socket;

    public UdpClientConnection(NetworkEndPoint remoteEndPoint)
    {
      lock (this.socketLock)
      {
        this.EndPoint = (ConnectionEndPoint) remoteEndPoint;
        this.RemoteEndPoint = remoteEndPoint.EndPoint;
        this.IPMode = remoteEndPoint.IPMode;
        if (remoteEndPoint.IPMode == IPMode.IPv4)
        {
          this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }
        else
        {
          if (!Socket.OSSupportsIPv6)
            throw new HazelException("IPV6 not supported!");
          this.socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
          this.socket.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
        }
      }
    }

    protected override void WriteBytesToConnection(byte[] bytes)
    {
      lock (this.socketLock)
      {
        if (this.State != ConnectionState.Connected && this.State != ConnectionState.Connecting)
          throw new InvalidOperationException("Could not send data as this Connection is not connected and is not connecting. Did you disconnect?");
        try
        {
          this.socket.BeginSendTo(bytes, 0, bytes.Length, SocketFlags.None, this.RemoteEndPoint, (AsyncCallback) (result =>
          {
            try
            {
              lock (this.socket)
                this.socket.EndSendTo(result);
            }
            catch (SocketException ex)
            {
              this.HandleDisconnect(new HazelException("Could not send data as a SocketException occured.", (Exception) ex));
            }
          }), (object) null);
        }
        catch (ObjectDisposedException ex)
        {
          throw new InvalidOperationException("Could not send data as this Connection is not connected. Did you disconnect?");
        }
        catch (SocketException ex)
        {
          HazelException e = new HazelException("Could not send data as a SocketException occured.", (Exception) ex);
          this.HandleDisconnect(e);
          throw e;
        }
      }
    }

    public override void Connect(byte[] bytes = null, int timeout = 5000)
    {
      lock (this.socketLock)
      {
        if (this.State != ConnectionState.NotConnected)
          throw new InvalidOperationException("Cannot connect as the Connection is already connected.");
        this.State = ConnectionState.Connecting;
        try
        {
          if (this.IPMode == IPMode.IPv4)
            this.socket.Bind((EndPoint) new IPEndPoint(IPAddress.Any, 0));
          else
            this.socket.Bind((EndPoint) new IPEndPoint(IPAddress.IPv6Any, 0));
        }
        catch (SocketException ex)
        {
          this.State = ConnectionState.NotConnected;
          throw new HazelException("A socket exception occured while binding to the port.", (Exception) ex);
        }
        try
        {
          this.StartListeningForData();
        }
        catch (ObjectDisposedException ex)
        {
          this.State = ConnectionState.NotConnected;
          return;
        }
        catch (SocketException ex)
        {
          this.Dispose();
          throw new HazelException("A Socket exception occured while initiating a receive operation.", (Exception) ex);
        }
      }
      this.SendHello(bytes, (Action) (() =>
      {
        lock (this.socketLock)
          this.State = ConnectionState.Connected;
      }));
      if (!this.WaitOnConnect(timeout))
      {
        this.Dispose();
        throw new HazelException("Connection attempt timed out.");
      }
    }

    private void StartListeningForData()
    {
      lock (this.socketLock)
        this.socket.BeginReceive(this.dataBuffer, 0, this.dataBuffer.Length, SocketFlags.None, new AsyncCallback(this.ReadCallback), (object) this.dataBuffer);
    }

    private void ReadCallback(IAsyncResult result)
    {
      int bytesReceived;
      try
      {
        lock (this.socketLock)
          bytesReceived = this.socket.EndReceive(result);
      }
      catch (ObjectDisposedException ex)
      {
        return;
      }
      catch (SocketException ex)
      {
        this.HandleDisconnect(new HazelException("A socket exception occured while reading data.", (Exception) ex));
        return;
      }
      if (bytesReceived == 0)
      {
        this.HandleDisconnect((HazelException) null);
      }
      else
      {
        byte[] bytes = this.HandleReceive(this.dataBuffer, bytesReceived);
        SendOption sendOption = (SendOption) this.dataBuffer[0];
        try
        {
          this.StartListeningForData();
        }
        catch (SocketException ex)
        {
          this.HandleDisconnect(new HazelException("A Socket exception occured while initiating a receive operation.", (Exception) ex));
        }
        catch (ObjectDisposedException ex)
        {
          return;
        }
        if (bytes == null)
          return;
        this.InvokeDataReceived(bytes, sendOption);
      }
    }

    public override void HandleDisconnect(HazelException e = null)
    {
      bool flag = false;
      lock (this.socketLock)
      {
        if (this.State == ConnectionState.Connected)
        {
          this.State = ConnectionState.Disconnecting;
          flag = true;
        }
      }
      if (!flag)
        return;
      this.InvokeDisconnected((Exception) e);
      this.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.State == ConnectionState.Connected)
          this.SendDisconnect();
        lock (this.socketLock)
        {
          this.State = ConnectionState.NotConnected;
          this.socket.Close();
        }
      }
      base.Dispose(disposing);
    }
  }
}
