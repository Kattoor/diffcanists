
using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;

namespace Telepathy
{
  public abstract class Common
  {
    public static int messageQueueSizeWarning = 100000;
    protected ConcurrentQueue<Message> receiveQueue = new ConcurrentQueue<Message>();
    public bool NoDelay = true;
    public int MaxMessageSize = 16384;
    public int SendTimeout = 5000;
    [ThreadStatic]
    private static byte[] header;
    [ThreadStatic]
    private static byte[] payload;

    public int ReceiveQueueCount
    {
      get
      {
        return this.receiveQueue.Count;
      }
    }

    public bool GetNextMessage(out Message message)
    {
      return this.receiveQueue.TryDequeue(out message);
    }

    protected static bool SendMessagesBlocking(NetworkStream stream, byte[][] messages)
    {
      try
      {
        int count = 0;
        for (int index = 0; index < messages.Length; ++index)
          count += 4 + messages[index].Length;
        if (Common.payload == null || Common.payload.Length < count)
          Common.payload = new byte[count];
        int destinationIndex = 0;
        for (int index = 0; index < messages.Length; ++index)
        {
          if (Common.header == null)
            Common.header = new byte[4];
          Utils.IntToBytesBigEndianNonAlloc(messages[index].Length, Common.header);
          Array.Copy((Array) Common.header, 0, (Array) Common.payload, destinationIndex, Common.header.Length);
          Array.Copy((Array) messages[index], 0, (Array) Common.payload, destinationIndex + Common.header.Length, messages[index].Length);
          destinationIndex += Common.header.Length + messages[index].Length;
        }
        stream.Write(Common.payload, 0, count);
        return true;
      }
      catch (Exception ex)
      {
        Logger.Log("Send: stream.Write exception: " + (object) ex);
        return false;
      }
    }

    protected static bool ReadMessageBlocking(
      NetworkStream stream,
      int MaxMessageSize,
      out byte[] content)
    {
      content = (byte[]) null;
      if (Common.header == null)
        Common.header = new byte[4];
      if (!stream.ReadExactly(Common.header, 4))
        return false;
      int intBigEndian = Utils.BytesToIntBigEndian(Common.header);
      if (intBigEndian <= MaxMessageSize)
      {
        content = new byte[intBigEndian];
        return stream.ReadExactly(content, intBigEndian);
      }
      Logger.LogWarning("ReadMessageBlocking: possible allocation attack with a header of: " + (object) intBigEndian + " bytes.");
      return false;
    }

    protected static void ReceiveLoop(
      int connectionId,
      TcpClient client,
      ConcurrentQueue<Message> receiveQueue,
      int MaxMessageSize)
    {
      NetworkStream stream = client.GetStream();
      DateTime now = DateTime.Now;
      try
      {
        receiveQueue.Enqueue(new Message(connectionId, EventType.Connected, (byte[]) null));
        byte[] content;
        while (Common.ReadMessageBlocking(stream, MaxMessageSize, out content))
        {
          receiveQueue.Enqueue(new Message(connectionId, EventType.Data, content));
          if (receiveQueue.Count > Common.messageQueueSizeWarning && (DateTime.Now - now).TotalSeconds > 10.0)
          {
            Logger.LogWarning("ReceiveLoop: messageQueue is getting big(" + (object) receiveQueue.Count + "), try calling GetNextMessage more often. You can call it more than once per frame!");
            now = DateTime.Now;
          }
        }
      }
      catch (Exception ex)
      {
        Logger.Log("ReceiveLoop: finished receive function for connectionId=" + (object) connectionId + " reason: " + (object) ex);
      }
      finally
      {
        stream.Close();
        client.Close();
        receiveQueue.Enqueue(new Message(connectionId, EventType.Disconnected, (byte[]) null));
      }
    }

    protected static void SendLoop(
      int connectionId,
      TcpClient client,
      SafeQueue<byte[]> sendQueue,
      ManualResetEvent sendPending)
    {
      NetworkStream stream = client.GetStream();
      try
      {
        while (client.Connected)
        {
          sendPending.Reset();
          byte[][] result;
          if (sendQueue.TryDequeueAll(out result) && !Common.SendMessagesBlocking(stream, result))
            break;
          sendPending.WaitOne();
        }
      }
      catch (ThreadAbortException ex)
      {
      }
      catch (ThreadInterruptedException ex)
      {
      }
      catch (Exception ex)
      {
        Logger.Log("SendLoop Exception: connectionId=" + (object) connectionId + " reason: " + (object) ex);
      }
      finally
      {
        stream.Close();
        client.Close();
      }
    }
  }
}
