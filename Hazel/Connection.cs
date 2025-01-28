
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Hazel
{
  public abstract class Connection : IDisposable
  {
    public player_info player = new player_info();
    private object encryptionLock = new object();
    private ManualResetEvent connectWaitLock = new ManualResetEvent(false);
    public Stopwatch stopwatch;
    public IMiniGame miniGame;
    public int randomRatedFactsID;
    public byte[] randomBytes;
    public AesManaged myAes;
    public EncryptionType encryptionType;
    public string hwid;
    private volatile ConnectionState state;

    public string name
    {
      get
      {
        return this.player.account.name;
      }
    }

    public void OnResign(ZPerson p)
    {
    }

    public string GetChatMessages()
    {
      return (string) null;
    }

    public void OnChat(string s)
    {
    }

    public event EventHandler<DataReceivedEventArgs> DataReceived;

    public event EventHandler<DisconnectedEventArgs> Disconnected;

    public void SetupEncryption()
    {
      if (!LocalServerConn.UseEncryption)
        return;
      this.encryptionType = EncryptionType.S;
    }

    public void CopyEncryption(Connection c)
    {
      this.myAes = c.myAes;
      this.encryptionType = c.encryptionType;
    }

    public byte[] Encrypt(byte[] b)
    {
      if (this.myAes == null)
        return b;
      lock (this.encryptionLock)
      {
        this.myAes.GenerateIV();
        using (ICryptoTransform encryptor = this.myAes.CreateEncryptor(this.myAes.Key, this.myAes.IV))
        {
          using (MemoryStream memoryStream1 = new MemoryStream())
          {
            using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream1, encryptor, CryptoStreamMode.Write))
            {
              cryptoStream.Write(b, 0, b.Length);
              cryptoStream.FlushFinalBlock();
              using (MemoryStream memoryStream2 = new MemoryStream())
              {
                using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream2))
                {
                  myBinaryWriter.Write(this.myAes.IV);
                  myBinaryWriter.Write(memoryStream1.ToArray());
                  return memoryStream2.ToArray();
                }
              }
            }
          }
        }
      }
    }

    public byte[] Decrypt(byte[] b)
    {
      lock (this.encryptionLock)
      {
        using (MemoryStream memoryStream1 = new MemoryStream(b))
        {
          using (myBinaryReader myBinaryReader = new myBinaryReader((Stream) memoryStream1))
          {
            this.myAes.IV = myBinaryReader.ReadBytes();
            byte[] buffer1 = myBinaryReader.ReadBytes();
            using (ICryptoTransform decryptor = this.myAes.CreateDecryptor(this.myAes.Key, this.myAes.IV))
            {
              using (MemoryStream memoryStream2 = new MemoryStream(buffer1))
              {
                using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream2, decryptor, CryptoStreamMode.Read))
                {
                  byte[] buffer2 = new byte[buffer1.Length];
                  cryptoStream.Read(buffer2, 0, buffer2.Length);
                  return buffer2;
                }
              }
            }
          }
        }
      }
    }

    public ConnectionEndPoint EndPoint { get; protected set; }

    public ConnectionStatistics Statistics { get; protected set; }

    public ConnectionState State
    {
      get
      {
        return this.state;
      }
      protected set
      {
        this.state = value;
        if (this.state == ConnectionState.Connected)
          this.connectWaitLock.Set();
        else
          this.connectWaitLock.Reset();
      }
    }

    protected Connection()
    {
      this.Statistics = new ConnectionStatistics();
      this.State = ConnectionState.NotConnected;
    }

    public abstract void SendBytes(byte[] bytes, SendOption sendOption = SendOption.None);

    public abstract void SendBytesAndClose(byte[] bytes, SendOption sendOption = SendOption.None);

    public abstract void SendBytesUnencrypted(byte[] bytes);

    public abstract void Connect(byte[] bytes = null, int timeout = 5000);

    internal void InvokeDataReceived(byte[] bytes, SendOption sendOption)
    {
      DataReceivedEventArgs args = DataReceivedEventArgs.GetObject();
      byte[] numArray = (byte[]) null;
      if (this.encryptionType == EncryptionType.S)
      {
        if (bytes.Length > 1)
        {
          try
          {
            numArray = this.Decrypt(bytes);
          }
          catch (Exception ex)
          {
            this.HandleDisconnect((HazelException) null);
            return;
          }
        }
      }
      args.Set(numArray ?? bytes, sendOption);
      UnityThreadHelper.Dispatcher.Dispatch((Action) (() =>
      {
        EventHandler<DataReceivedEventArgs> dataReceived = this.DataReceived;
        if (dataReceived == null)
          return;
        dataReceived((object) this, args);
      }));
    }

    internal void InvokeDisconnected(Exception e = null)
    {
      DisconnectedEventArgs e1 = DisconnectedEventArgs.GetObject();
      e1.Set(e);
      EventHandler<DisconnectedEventArgs> disconnected = this.Disconnected;
      if (disconnected == null)
        return;
      disconnected((object) this, e1);
    }

    public abstract void HandleDisconnect(HazelException e = null);

    protected bool WaitOnConnect(int timeout)
    {
      return this.connectWaitLock.WaitOne(timeout);
    }

    public virtual void Close()
    {
      this.InvokeDisconnected((Exception) null);
      this.Dispose();
    }

    public void Dispose()
    {
      this.Dispose(true);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this.stopwatch != null)
      {
        this.stopwatch.Stop();
        this.stopwatch = (Stopwatch) null;
      }
      if (!disposing)
        return;
      this.Disconnected = (EventHandler<DisconnectedEventArgs>) null;
      this.DataReceived = (EventHandler<DataReceivedEventArgs>) null;
      this.miniGame = (IMiniGame) null;
      this.myAes = (AesManaged) null;
      this.randomBytes = (byte[]) null;
    }
  }
}
