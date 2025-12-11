
using Hazel;
using Ninja.WebSockets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class WebListener : ConnectionListener
{
  private readonly IWebSocketServerFactory webSocketServerFactory = (IWebSocketServerFactory) new WebSocketServerFactory();
  private Dictionary<int, WebConnection> clients = new Dictionary<int, WebConnection>();
  public bool NoDelay = true;
  public bool _secure = true;
  public WebListener.SslConfiguration _sslConfig = new WebListener.SslConfiguration();
  private const int MaxMessageSize = 1048576;
  private TcpListener listener;
  private CancellationTokenSource cancellation;
  private static int counter;

  public override void StartNoTry()
  {
    throw new NotImplementedException();
  }

  public override void Start()
  {
    throw new NotImplementedException();
  }

  public event System.Action<int, Exception> ReceivedError;

  public static int NextConnectionId()
  {
    int num = Interlocked.Increment(ref WebListener.counter);
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

  public WebConnection GetClient(int connectionId)
  {
    return this.clients[connectionId];
  }

  public async void Listen(int port)
  {
    WebListener w = this;
    try
    {
      if (w._secure)
        w._sslConfig.SetKey(w);
      w.cancellation = new CancellationTokenSource();
      w.listener = TcpListener.Create(port);
      w.listener.Server.NoDelay = w.NoDelay;
      w.listener.Start();
      while (true)
      {
        TcpClient tcpClient = await w.listener.AcceptTcpClientAsync();
        w.ProcessTcpClient(tcpClient, w.cancellation.Token, tcpClient.Client.RemoteEndPoint.ToString());
      }
    }
    catch (ObjectDisposedException ex)
    {
    }
    catch (Exception ex)
    {
      System.Action<int, Exception> receivedError = w.ReceivedError;
      if (receivedError == null)
        return;
      receivedError(0, ex);
    }
  }

  private async void ProcessTcpClient(TcpClient tcpClient, CancellationToken token, string ip)
  {
    try
    {
      WebSocketHttpContext context = await this.webSocketServerFactory.ReadHttpHeaderFromStreamAsync((Stream) tcpClient.GetStream(), token);
      if (context.IsWebSocketRequest)
      {
        WebSocketServerOptions options = new WebSocketServerOptions()
        {
          KeepAliveInterval = TimeSpan.FromSeconds(30.0),
          SubProtocol = "binary"
        };
        await this.ReceiveLoopAsync(await this.webSocketServerFactory.AcceptWebSocketAsync(context, options, new CancellationToken()), token, ip);
      }
      else
        Debug.Log((object) "Http header contains no web socket upgrade request. Ignoring");
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
    finally
    {
      try
      {
        tcpClient.Client.Close();
        tcpClient.Close();
      }
      catch (Exception ex)
      {
        System.Action<int, Exception> receivedError = this.ReceivedError;
        if (receivedError != null)
          receivedError(0, ex);
      }
    }
  }

  private async Task ReceiveLoopAsync(WebSocket webSocket, CancellationToken token, string ip)
  {
    int num = (^this).\u003C\u003E1__state;
    WebListener webListener = this;
    WebConnection con;
    byte[] buffer;
    try
    {
      int connectionId = WebListener.NextConnectionId();
      con = new WebConnection(webSocket, ip, connectionId);
      con.cancellation = new CancellationTokenSource();
      webListener.clients.Add(connectionId, con);
      buffer = new byte[1048576];
      try
      {
        webListener.InvokeNewConnection(new byte[0], (Connection) con);
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
              awaiter2 = webListener.ReadFrames(connectionId, result1, webSocket, buffer, token).GetAwaiter();
              if (awaiter2.IsCompleted)
              {
                byte[] result2 = awaiter2.GetResult();
                if (result2.Length != 0)
                {
                  try
                  {
                    con.Statistics.LogReceive(result2.Length, result2.Length + 4);
                    con.InvokeDataReceived(result2, SendOption.Reliable);
                  }
                  catch (Exception ex)
                  {
                    System.Action<int, Exception> receivedError = webListener.ReceivedError;
                    if (receivedError != null)
                      receivedError(connectionId, ex);
                  }
                }
                else
                  goto label_18;
              }
              else
                goto label_7;
            }
            else
              goto label_18;
          }
          else
            break;
        }
        (^this).\u003C\u003E1__state = num = 0;
        TaskAwaiter<WebSocketReceiveResult> taskAwaiter1 = awaiter1;
        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WebSocketReceiveResult>, WebListener.\u003CReceiveLoopAsync\u003Ed__21>(ref awaiter1, this);
        return;
label_7:
        (^this).\u003C\u003E1__state = num = 1;
        TaskAwaiter<byte[]> taskAwaiter2 = awaiter2;
        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, WebListener.\u003CReceiveLoopAsync\u003Ed__21>(ref awaiter2, this);
        return;
      }
      catch (Exception ex)
      {
        System.Action<int, Exception> receivedError = webListener.ReceivedError;
        if (receivedError != null)
          receivedError(connectionId, ex);
      }
      finally
      {
        if (num < 0)
        {
          con.SetDisconnected();
          webListener.clients.Remove(connectionId);
          con.InvokeDisconnected((Exception) null);
          con.Dispose();
        }
      }
    }
    catch (Exception ex)
    {
      (^this).\u003C\u003E1__state = -2;
      con = (WebConnection) null;
      buffer = (byte[]) null;
      (^this).\u003C\u003Et__builder.SetException(ex);
      return;
    }
label_18:
    (^this).\u003C\u003E1__state = -2;
    con = (WebConnection) null;
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
      if (count >= 1048576)
      {
        await webSocket.CloseAsync(WebSocketCloseStatus.MessageTooBig, string.Format("Maximum message size: {0} bytes.", (object) 1048576), CancellationToken.None);
        System.Action<int, Exception> receivedError = this.ReceivedError;
        if (receivedError != null)
          receivedError(connectionId, (Exception) new WebSocketException(WebSocketError.HeaderError));
        return new byte[0];
      }
      result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer, count, 1048576 - count), CancellationToken.None);
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
    WebConnection webConnection;
    if (num == 0 || this.clients.TryGetValue(connectionId, out webConnection))
    {
      try
      {
        await webConnection.webSocket.SendAsync(new ArraySegment<byte>(data), WebSocketMessageType.Binary, true, this.cancellation.Token);
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

  public async void Send(WebConnection client, byte[] data)
  {
    try
    {
      await client.webSocket.SendAsync(new ArraySegment<byte>(data), WebSocketMessageType.Binary, true, this.cancellation.Token);
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
    WebConnection webConnection;
    if (!this.clients.TryGetValue(connectionId, out webConnection))
      return false;
    webConnection.SetDisconnected();
    this.clients.Remove(connectionId);
    webConnection.webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
    webConnection.InvokeDisconnected((Exception) null);
    return true;
  }

  public override string ToString()
  {
    return this.Active ? string.Format("Websocket server {0}", (object) this.listener.LocalEndpoint) : "";
  }

  public class SslConfiguration
  {
    public SslProtocols EnabledSslProtocols = SslProtocols.Tls12;
    public X509Certificate2 Certificate;
    public bool ClientCertificateRequired;
    public bool CheckCertificateRevocation;

    public void SetKey(WebListener w)
    {
    }
  }
}
