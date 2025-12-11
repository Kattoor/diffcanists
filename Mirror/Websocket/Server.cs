
using Ninja.WebSockets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Mirror.Websocket
{
  public class Server
  {
    private readonly IWebSocketServerFactory webSocketServerFactory = (IWebSocketServerFactory) new WebSocketServerFactory();
    private Dictionary<int, WebSocket> clients = new Dictionary<int, WebSocket>();
    public bool NoDelay = true;
    private const int MaxMessageSize = 262144;
    private TcpListener listener;
    private CancellationTokenSource cancellation;
    private static int counter;
    public bool _secure;
    public Server.SslConfiguration _sslConfig;

    public event System.Action<int> Connected;

    public event System.Action<int, ArraySegment<byte>> ReceivedData;

    public event System.Action<int> Disconnected;

    public event System.Action<int, Exception> ReceivedError;

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
        return this.listener != null;
      }
    }

    public WebSocket GetClient(int connectionId)
    {
      return this.clients[connectionId];
    }

    public async void Listen(int port)
    {
      try
      {
        this.cancellation = new CancellationTokenSource();
        this.listener = TcpListener.Create(port);
        this.listener.Server.NoDelay = this.NoDelay;
        this.listener.Start();
        Debug.Log((object) string.Format("Websocket server started listening on port {0}", (object) port));
        while (true)
          this.ProcessTcpClient(await this.listener.AcceptTcpClientAsync(), this.cancellation.Token);
      }
      catch (ObjectDisposedException ex)
      {
      }
      catch (Exception ex)
      {
        System.Action<int, Exception> receivedError = this.ReceivedError;
        if (receivedError == null)
          return;
        receivedError(0, ex);
      }
    }

    private async void ProcessTcpClient(TcpClient tcpClient, CancellationToken token)
    {
      Server server = this;
      try
      {
        Stream stream = (Stream) tcpClient.GetStream();
        if (server._secure)
        {
          SslStream sslStream = new SslStream(stream, false, new RemoteCertificateValidationCallback(server.CertVerificationCallback));
          sslStream.AuthenticateAsServer((X509Certificate) server._sslConfig.Certificate, server._sslConfig.ClientCertificateRequired, server._sslConfig.EnabledSslProtocols, server._sslConfig.CheckCertificateRevocation);
          stream = (Stream) sslStream;
        }
        WebSocketHttpContext context = await server.webSocketServerFactory.ReadHttpHeaderFromStreamAsync(stream, token);
        if (context.IsWebSocketRequest)
        {
          WebSocketServerOptions options = new WebSocketServerOptions()
          {
            KeepAliveInterval = TimeSpan.FromSeconds(30.0),
            SubProtocol = "binary"
          };
          WebSocket webSocket = await server.webSocketServerFactory.AcceptWebSocketAsync(context, options, new CancellationToken());
          await server.ReceiveLoopAsync(webSocket, token);
        }
        else
          Debug.Log((object) "Http header contains no web socket upgrade request. Ignoring");
      }
      catch (ObjectDisposedException ex)
      {
      }
      catch (Exception ex)
      {
        System.Action<int, Exception> receivedError = server.ReceivedError;
        if (receivedError == null)
          return;
        receivedError(0, ex);
      }
      finally
      {
        try
        {
          tcpClient.Client.Close();
          tcpClient.Close();
        }
        catch (Exception ex)
        {
          System.Action<int, Exception> receivedError = server.ReceivedError;
          if (receivedError != null)
            receivedError(0, ex);
        }
      }
    }

    private bool CertVerificationCallback(
      object sender,
      X509Certificate certificate,
      X509Chain chain,
      SslPolicyErrors sslPolicyErrors)
    {
      return true;
    }

    private async Task ReceiveLoopAsync(WebSocket webSocket, CancellationToken token)
    {
      int num = (^this).\u003C\u003E1__state;
      byte[] buffer;
      try
      {
        int connectionId = Server.NextConnectionId();
        this.clients.Add(connectionId, webSocket);
        buffer = new byte[262144];
        try
        {
          System.Action<int> connected = this.Connected;
          if (connected != null)
            connected(connectionId);
          TaskAwaiter<WebSocketReceiveResult> awaiter1;
          WebSocketReceiveResult result1;
          TaskAwaiter<ArraySegment<byte>> awaiter2;
          while (true)
          {
            awaiter1 = webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), token).GetAwaiter();
            if (awaiter1.IsCompleted)
            {
              result1 = awaiter1.GetResult();
              if (result1.MessageType != WebSocketMessageType.Close)
              {
                awaiter2 = this.ReadFrames(connectionId, result1, webSocket, buffer, token).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                  ArraySegment<byte> result2 = awaiter2.GetResult();
                  if (result2.Count != 0)
                  {
                    try
                    {
                      System.Action<int, ArraySegment<byte>> receivedData = this.ReceivedData;
                      if (receivedData != null)
                        receivedData(connectionId, result2);
                    }
                    catch (Exception ex)
                    {
                      System.Action<int, Exception> receivedError = this.ReceivedError;
                      if (receivedError != null)
                        receivedError(connectionId, ex);
                    }
                  }
                  else
                    goto label_22;
                }
                else
                  goto label_9;
              }
              else
                goto label_7;
            }
            else
              break;
          }
          (^this).\u003C\u003E1__state = num = 0;
          TaskAwaiter<WebSocketReceiveResult> taskAwaiter1 = awaiter1;
          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WebSocketReceiveResult>, Server.\u003CReceiveLoopAsync\u003Ed__29>(ref awaiter1, this);
          return;
label_7:
          Debug.Log((object) string.Format("Client initiated close. Status: {0} Description: {1}", (object) result1.CloseStatus, (object) result1.CloseStatusDescription));
          goto label_22;
label_9:
          (^this).\u003C\u003E1__state = num = 1;
          TaskAwaiter<ArraySegment<byte>> taskAwaiter2 = awaiter2;
          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ArraySegment<byte>>, Server.\u003CReceiveLoopAsync\u003Ed__29>(ref awaiter2, this);
          return;
        }
        catch (Exception ex)
        {
          System.Action<int, Exception> receivedError = this.ReceivedError;
          if (receivedError != null)
            receivedError(connectionId, ex);
        }
        finally
        {
          if (num < 0)
          {
            this.clients.Remove(connectionId);
            System.Action<int> disconnected = this.Disconnected;
            if (disconnected != null)
              disconnected(connectionId);
          }
        }
      }
      catch (Exception ex)
      {
        (^this).\u003C\u003E1__state = -2;
        buffer = (byte[]) null;
        (^this).\u003C\u003Et__builder.SetException(ex);
        return;
      }
label_22:
      (^this).\u003C\u003E1__state = -2;
      buffer = (byte[]) null;
      (^this).\u003C\u003Et__builder.SetResult();
    }

    private async Task<ArraySegment<byte>> ReadFrames(
      int connectionId,
      WebSocketReceiveResult result,
      WebSocket webSocket,
      byte[] buffer,
      CancellationToken token)
    {
      int count = result.Count;
      while (!result.EndOfMessage)
      {
        if (count >= 262144)
        {
          await webSocket.CloseAsync(WebSocketCloseStatus.MessageTooBig, string.Format("Maximum message size: {0} bytes.", (object) 262144), CancellationToken.None);
          System.Action<int, Exception> receivedError = this.ReceivedError;
          if (receivedError != null)
            receivedError(connectionId, (Exception) new WebSocketException(WebSocketError.HeaderError));
          return new ArraySegment<byte>();
        }
        result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer, count, 262144 - count), CancellationToken.None);
        count += result.Count;
      }
      return new ArraySegment<byte>(buffer, 0, count);
    }

    public void Stop()
    {
      if (!this.Active)
        return;
      Debug.Log((object) "Server: stopping...");
      this.cancellation.Cancel();
      this.listener.Stop();
      this.clients.Clear();
      this.listener = (TcpListener) null;
    }

    public async void Send(int connectionId, byte[] data)
    {
      int num;
      WebSocket webSocket;
      if (num == 0 || this.clients.TryGetValue(connectionId, out webSocket))
      {
        try
        {
          await webSocket.SendAsync(new ArraySegment<byte>(data), WebSocketMessageType.Binary, true, this.cancellation.Token);
        }
        catch (ObjectDisposedException ex)
        {
          this.Disconnect(connectionId);
        }
        catch (Exception ex)
        {
          if (this.clients.ContainsKey(connectionId))
          {
            System.Action<int, Exception> receivedError = this.ReceivedError;
            if (receivedError != null)
              receivedError(connectionId, ex);
          }
          this.Disconnect(connectionId);
        }
      }
      else
      {
        System.Action<int, Exception> receivedError = this.ReceivedError;
        if (receivedError == null)
          return;
        receivedError(connectionId, (Exception) new SocketException(10057));
      }
    }

    public string GetClientAddress(int connectionId)
    {
      return this.clients.TryGetValue(connectionId, out WebSocket _) ? "" : (string) null;
    }

    public bool Disconnect(int connectionId)
    {
      WebSocket webSocket;
      if (!this.clients.TryGetValue(connectionId, out webSocket))
        return false;
      this.clients.Remove(connectionId);
      webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
      Debug.Log((object) ("Server.Disconnect connectionId:" + connectionId.ToString()));
      return true;
    }

    public override string ToString()
    {
      return this.Active ? string.Format("Websocket server {0}", (object) this.listener.LocalEndpoint) : "";
    }

    public class SslConfiguration
    {
      public X509Certificate2 Certificate;
      public bool ClientCertificateRequired;
      public SslProtocols EnabledSslProtocols;
      public bool CheckCertificateRevocation;
    }
  }
}
