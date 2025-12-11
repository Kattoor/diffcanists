
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Telepathy
{
  public class Server : Common
  {
    private ConcurrentDictionary<int, Server.ClientToken> clients = new ConcurrentDictionary<int, Server.ClientToken>();
    public TcpListener listener;
    private Thread listenerThread;
    private static int counter;

    public static int NextConnectionId()
    {
      int num = Interlocked.Increment(ref Server.counter);
      if (num == int.MaxValue)
        throw new Exception("connection id limit reached: " + num.ToString());
      return num;
    }

    public bool Active
    {
      get
      {
        return this.listenerThread != null && this.listenerThread.IsAlive;
      }
    }

    private void Listen(int port)
    {
      try
      {
        this.listener = TcpListener.Create(port);
        this.listener.Server.NoDelay = this.NoDelay;
        this.listener.Server.SendTimeout = this.SendTimeout;
        this.listener.Start();
        Logger.Log("Server: listening port=" + port.ToString());
        while (true)
        {
          TcpClient client = this.listener.AcceptTcpClient();
          int connectionId = Server.NextConnectionId();
          Server.ClientToken token = new Server.ClientToken(client);
          this.clients[connectionId] = token;
          Thread sendThread = new Thread((ThreadStart) (() =>
          {
            try
            {
              Common.SendLoop(connectionId, client, token.sendQueue, token.sendPending);
            }
            catch (ThreadAbortException ex)
            {
            }
            catch (Exception ex)
            {
              Logger.LogError("Server send thread exception: " + ex?.ToString());
            }
          }));
          sendThread.IsBackground = true;
          sendThread.Start();
          new Thread((ThreadStart) (() =>
          {
            try
            {
              Common.ReceiveLoop(connectionId, client, this.receiveQueue, this.MaxMessageSize);
              this.clients.TryRemove(connectionId, out Server.ClientToken _);
              sendThread.Interrupt();
            }
            catch (Exception ex)
            {
              Logger.LogError("Server client thread exception: " + ex?.ToString());
            }
          }))
          {
            IsBackground = true
          }.Start();
        }
      }
      catch (ThreadAbortException ex)
      {
        Logger.Log("Server thread aborted. That's okay. " + ex?.ToString());
      }
      catch (SocketException ex)
      {
        Logger.Log("Server Thread stopped. That's okay. " + ex?.ToString());
      }
      catch (Exception ex)
      {
        Logger.LogError("Server Exception: " + ex?.ToString());
      }
    }

    public bool Start(int port)
    {
      if (this.Active)
        return false;
      this.receiveQueue = new ConcurrentQueue<Message>();
      Logger.Log("Server: Start port=" + port.ToString());
      this.listenerThread = new Thread((ThreadStart) (() => this.Listen(port)));
      this.listenerThread.IsBackground = true;
      this.listenerThread.Priority = ThreadPriority.BelowNormal;
      this.listenerThread.Start();
      return true;
    }

    public void Stop()
    {
      if (!this.Active)
        return;
      Logger.Log("Server: stopping...");
      this.listener?.Stop();
      this.listenerThread?.Interrupt();
      this.listenerThread = (Thread) null;
      foreach (KeyValuePair<int, Server.ClientToken> client1 in this.clients)
      {
        TcpClient client2 = client1.Value.client;
        try
        {
          client2.GetStream().Close();
        }
        catch
        {
        }
        client2.Close();
      }
      this.clients.Clear();
    }

    public bool Send(int connectionId, byte[] data)
    {
      if (data.Length <= this.MaxMessageSize)
      {
        Server.ClientToken clientToken;
        if (this.clients.TryGetValue(connectionId, out clientToken))
        {
          clientToken.sendQueue.Enqueue(data);
          clientToken.sendPending.Set();
          return true;
        }
        Logger.Log("Server.Send: invalid connectionId: " + connectionId.ToString());
        return false;
      }
      Logger.LogError("Client.Send: message too big: " + data.Length.ToString() + ". Limit: " + this.MaxMessageSize.ToString());
      return false;
    }

    public string GetClientAddress(int connectionId)
    {
      Server.ClientToken clientToken;
      return this.clients.TryGetValue(connectionId, out clientToken) ? ((IPEndPoint) clientToken.client.Client.RemoteEndPoint).Address.ToString() : "";
    }

    public bool Disconnect(int connectionId)
    {
      Server.ClientToken clientToken;
      if (!this.clients.TryGetValue(connectionId, out clientToken))
        return false;
      clientToken.client.Close();
      Logger.Log("Server.Disconnect connectionId:" + connectionId.ToString());
      return true;
    }

    private class ClientToken
    {
      public SafeQueue<byte[]> sendQueue = new SafeQueue<byte[]>();
      public ManualResetEvent sendPending = new ManualResetEvent(false);
      public TcpClient client;

      public ClientToken(TcpClient client)
      {
        this.client = client;
      }
    }
  }
}
