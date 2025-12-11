
using Ninja.WebSockets;
using System;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Hazel.Websocket
{
  public class Client
  {
    public bool NoDelay = true;
    private const int MaxMessageSize = 2097152;
    private WebSocket webSocket;
    private CancellationTokenSource cancellation;
    private Uri uri;

    public event System.Action Connected;

    public event System.Action<byte[]> ReceivedData;

    public event System.Action Disconnected;

    public event System.Action<Exception> ReceivedError;

    public bool Connecting { get; set; }

    public bool IsConnected { get; set; }

    public async void Connect(Uri uri)
    {
      Client client = this;
      if (client.webSocket != null)
      {
        client.InvokeError(new Exception("Client already connected"));
      }
      else
      {
        client.uri = uri;
        client.Connecting = true;
        await Task.Run(new System.Action(client.\u003CConnect\u003Eb__25_0));
      }
    }

    private async void RunThread()
    {
      Client client = this;
      WebSocketClientOptions options = new WebSocketClientOptions()
      {
        NoDelay = true,
        KeepAliveInterval = TimeSpan.Zero,
        SecWebSocketProtocol = "binary"
      };
      WebSocketClientFactory socketClientFactory = new WebSocketClientFactory();
      client.cancellation = new CancellationTokenSource();
      try
      {
        WebSocket webSocket = await socketClientFactory.ConnectAsync(client.uri, options, client.cancellation.Token);
        using (client.webSocket = webSocket)
        {
          CancellationToken token = client.cancellation.Token;
          client.IsConnected = true;
          client.Connecting = false;
          UnityThreadHelper.Dispatcher.Dispatch2(new System.Action(client.\u003CRunThread\u003Eb__26_1));
          await client.ReceiveLoop(client.webSocket, token);
        }
      }
      catch (ObjectDisposedException ex)
      {
      }
      catch (Exception ex)
      {
        client.InvokeError(ex);
      }
      finally
      {
        client.Disconnect();
        UnityThreadHelper.Dispatcher.Dispatch2(new System.Action(client.\u003CRunThread\u003Eb__26_0));
      }
    }

    private void InvokeError(Exception ex)
    {
      if (this.ReceivedError == null)
        return;
      UnityThreadHelper.Dispatcher.Dispatch2((System.Action) (() =>
      {
        System.Action<Exception> receivedError = this.ReceivedError;
        if (receivedError == null)
          return;
        receivedError(ex);
      }));
    }

    private async Task ReceiveLoop(WebSocket webSocket, CancellationToken token)
    {
      Client client1 = this;
      byte[] buffer;
      try
      {
        buffer = new byte[2097152];
        TaskAwaiter<WebSocketReceiveResult> awaiter1;
        TaskAwaiter<byte[]> awaiter2;
        while (true)
        {
          Client client = client1;
          awaiter1 = webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), token).GetAwaiter();
          if (awaiter1.IsCompleted)
          {
            WebSocketReceiveResult result = awaiter1.GetResult();
            if (result != null)
            {
              if (result.MessageType != WebSocketMessageType.Close)
              {
                awaiter2 = client1.ReadFrames(result, webSocket, buffer).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                  byte[] data = awaiter2.GetResult();
                  if (data.Length != 0)
                  {
                    try
                    {
                      UnityThreadHelper.Dispatcher.Dispatch2((System.Action) (() =>
                      {
                        System.Action<byte[]> receivedData = client.ReceivedData;
                        if (receivedData == null)
                          return;
                        receivedData(data);
                      }));
                    }
                    catch (Exception ex)
                    {
                      client1.InvokeError(ex);
                    }
                  }
                  else
                    goto label_13;
                }
                else
                  goto label_7;
              }
              else
                goto label_13;
            }
            else
              goto label_13;
          }
          else
            break;
        }
        int num;
        (^this).\u003C\u003E1__state = num = 0;
        TaskAwaiter<WebSocketReceiveResult> taskAwaiter1 = awaiter1;
        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WebSocketReceiveResult>, Client.\u003CReceiveLoop\u003Ed__28>(ref awaiter1, this);
        return;
label_7:
        (^this).\u003C\u003E1__state = num = 1;
        TaskAwaiter<byte[]> taskAwaiter2 = awaiter2;
        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, Client.\u003CReceiveLoop\u003Ed__28>(ref awaiter2, this);
        return;
      }
      catch (Exception ex)
      {
        (^this).\u003C\u003E1__state = -2;
        buffer = (byte[]) null;
        (^this).\u003C\u003Et__builder.SetException(ex);
        return;
      }
label_13:
      (^this).\u003C\u003E1__state = -2;
      buffer = (byte[]) null;
      (^this).\u003C\u003Et__builder.SetResult();
    }

    private async Task<byte[]> ReadFrames(
      WebSocketReceiveResult result,
      WebSocket webSocket,
      byte[] buffer)
    {
      int count = result.Count;
      while (!result.EndOfMessage)
      {
        if (count >= 2097152)
        {
          await webSocket.CloseAsync(WebSocketCloseStatus.MessageTooBig, string.Format("Maximum message size: {0} bytes.", (object) 2097152), CancellationToken.None);
          this.InvokeError((Exception) new WebSocketException(WebSocketError.HeaderError));
          return new byte[0];
        }
        result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer, count, 2097152 - count), CancellationToken.None);
        count += result.Count;
      }
      byte[] numArray = new byte[count];
      System.Buffer.BlockCopy((Array) buffer, 0, (Array) numArray, 0, count);
      return numArray;
    }

    public void Disconnect()
    {
      this.cancellation?.Cancel();
      if (this.webSocket == null)
        return;
      this.webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
      this.webSocket = (WebSocket) null;
      this.Connecting = false;
      this.IsConnected = false;
    }

    public async void SendBytes(byte[] data)
    {
      int num;
      if (num != 0 && this.webSocket == null)
      {
        this.InvokeError((Exception) new SocketException(10057));
      }
      else
      {
        try
        {
          await this.webSocket.SendAsync(new ArraySegment<byte>(data), WebSocketMessageType.Binary, true, this.cancellation.Token);
        }
        catch (Exception ex)
        {
          this.Disconnect();
          this.InvokeError(ex);
        }
      }
    }

    public override string ToString()
    {
      if (this.IsConnected)
        return string.Format("Websocket connected to {0}", (object) this.uri);
      return this.Connecting ? string.Format("Websocket connecting to {0}", (object) this.uri) : "";
    }
  }
}
