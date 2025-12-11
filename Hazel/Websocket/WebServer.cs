
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

namespace Hazel.Websocket
{
  public class WebServer
  {
    private readonly IWebSocketServerFactory webSocketServerFactory = (IWebSocketServerFactory) new WebSocketServerFactory();
    private Dictionary<int, WebConnectionOld> clients = new Dictionary<int, WebConnectionOld>();
    public bool NoDelay = true;
    private const int MaxMessageSize = 262144;
    private TcpListener listener;
    private CancellationTokenSource cancellation;
    private static int counter;
    public bool _secure;
    public WebServer.SslConfiguration _sslConfig;

    public event System.Action<WebConnectionOld> Connected;

    public event System.Action<WebConnectionOld> Disconnected;

    public event System.Action<int, Exception> ReceivedError;

    public static int NextConnectionId()
    {
      int num = Interlocked.Increment(ref WebServer.counter);
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

    public WebConnectionOld GetClient(int connectionId)
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
        while (true)
        {
          TcpClient tcpClient = await this.listener.AcceptTcpClientAsync();
          this.ProcessTcpClient(tcpClient, this.cancellation.Token, tcpClient.Client.RemoteEndPoint.ToString());
        }
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

    private async void ProcessTcpClient(TcpClient tcpClient, CancellationToken token, string ip)
    {
      WebServer webServer = this;
      try
      {
        Stream stream = (Stream) tcpClient.GetStream();
        if (webServer._secure)
        {
          SslStream sslStream = new SslStream(stream, false, new RemoteCertificateValidationCallback(webServer.CertVerificationCallback));
          sslStream.AuthenticateAsServer((X509Certificate) webServer._sslConfig.Certificate, webServer._sslConfig.ClientCertificateRequired, webServer._sslConfig.EnabledSslProtocols, webServer._sslConfig.CheckCertificateRevocation);
          stream = (Stream) sslStream;
        }
        WebSocketHttpContext context = await webServer.webSocketServerFactory.ReadHttpHeaderFromStreamAsync(stream, token);
        if (!context.IsWebSocketRequest)
          return;
        WebSocketServerOptions options = new WebSocketServerOptions()
        {
          KeepAliveInterval = TimeSpan.FromSeconds(30.0),
          SubProtocol = "binary"
        };
        WebSocket webSocket = await webServer.webSocketServerFactory.AcceptWebSocketAsync(context, options, new CancellationToken());
        await webServer.ReceiveLoopAsync(webSocket, token, ip);
      }
      catch (ObjectDisposedException ex)
      {
      }
      catch (Exception ex)
      {
        System.Action<int, Exception> receivedError = webServer.ReceivedError;
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
          System.Action<int, Exception> receivedError = webServer.ReceivedError;
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

    private async Task ReceiveLoopAsync(
      WebSocket webSocket,
      CancellationToken token,
      string ip)
    {
      int num = (^this).\u003C\u003E1__state;
      WebConnectionOld con;
      byte[] buffer;
      try
      {
        int connectionId = WebServer.NextConnectionId();
        con = new WebConnectionOld(webSocket, ip, connectionId);
        this.clients.Add(connectionId, con);
        buffer = new byte[262144];
        try
        {
          System.Action<WebConnectionOld> connected = this.Connected;
          if (connected != null)
            connected(con);
          TaskAwaiter<WebSocketReceiveResult> awaiter1;
          TaskAwaiter<byte[]> awaiter2;
          while (true)
          {
            awaiter1 = webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), token).GetAwaiter();
            if (awaiter1.IsCompleted)
            {
              WebSocketReceiveResult result1 = awaiter1.GetResult();
              if (result1.MessageType != WebSocketMessageType.Close)
              {
                awaiter2 = this.ReadFrames(connectionId, result1, webSocket, buffer, token).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                  byte[] result2 = awaiter2.GetResult();
                  if (result2.Length != 0)
                  {
                    try
                    {
                      ++con.messagesReceived;
                      con.DataReceived(result2);
                    }
                    catch (Exception ex)
                    {
                      System.Action<int, Exception> receivedError = this.ReceivedError;
                      if (receivedError != null)
                        receivedError(connectionId, ex);
                    }
                  }
                  else
                    goto label_20;
                }
                else
                  goto label_8;
              }
              else
                goto label_20;
            }
            else
              break;
          }
          (^this).\u003C\u003E1__state = num = 0;
          TaskAwaiter<WebSocketReceiveResult> taskAwaiter1 = awaiter1;
          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WebSocketReceiveResult>, WebServer.\u003CReceiveLoopAsync\u003Ed__26>(ref awaiter1, this);
          return;
label_8:
          (^this).\u003C\u003E1__state = num = 1;
          TaskAwaiter<byte[]> taskAwaiter2 = awaiter2;
          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, WebServer.\u003CReceiveLoopAsync\u003Ed__26>(ref awaiter2, this);
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
            con.Connected = false;
            this.clients.Remove(connectionId);
            System.Action<WebConnectionOld> disconnected = this.Disconnected;
            if (disconnected != null)
              disconnected(con);
          }
        }
      }
      catch (Exception ex)
      {
        (^this).\u003C\u003E1__state = -2;
        con = (WebConnectionOld) null;
        buffer = (byte[]) null;
        (^this).\u003C\u003Et__builder.SetException(ex);
        return;
      }
label_20:
      (^this).\u003C\u003E1__state = -2;
      con = (WebConnectionOld) null;
      buffer = (byte[]) null;
      (^this).\u003C\u003Et__builder.SetResult();
    }

    private async Task<byte[]> ReadFrames(
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
          return new byte[0];
        }
        result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer, count, 262144 - count), CancellationToken.None);
        count += result.Count;
      }
      byte[] numArray = new byte[count];
      System.Buffer.BlockCopy((Array) buffer, 0, (Array) numArray, 0, count);
      return numArray;
    }

    public void Stop()
    {
      if (!this.Active)
        return;
      this.cancellation.Cancel();
      this.listener.Stop();
      this.clients.Clear();
      this.listener = (TcpListener) null;
    }

    public async void Send(int connectionId, byte[] data)
    {
      int num;
      WebConnectionOld webConnectionOld;
      if (num == 0 || this.clients.TryGetValue(connectionId, out webConnectionOld))
      {
        try
        {
          await webConnectionOld.socket.SendAsync(new ArraySegment<byte>(data), WebSocketMessageType.Binary, true, this.cancellation.Token);
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

    public async void Send(WebConnectionOld client, byte[] data)
    {
      try
      {
        await client.socket.SendAsync(new ArraySegment<byte>(data), WebSocketMessageType.Binary, true, this.cancellation.Token);
      }
      catch (ObjectDisposedException ex)
      {
        this.Disconnect(client.id);
      }
      catch (Exception ex)
      {
        if (this.clients.ContainsKey(client.id))
        {
          System.Action<int, Exception> receivedError = this.ReceivedError;
          if (receivedError != null)
            receivedError(client.id, ex);
        }
        this.Disconnect(client.id);
      }
    }

    public bool Disconnect(int connectionId)
    {
      WebConnectionOld webConnectionOld;
      if (!this.clients.TryGetValue(connectionId, out webConnectionOld))
        return false;
      webConnectionOld.Connected = false;
      this.clients.Remove(connectionId);
      webConnectionOld.socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
      System.Action<WebConnectionOld> disconnected = this.Disconnected;
      if (disconnected != null)
        disconnected(webConnectionOld);
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
