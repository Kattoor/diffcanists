
using System;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja.WebSockets.Internal
{
  internal static class WebSocketFrameReader
  {
    public static async Task<WebSocketFrame> ReadAsync(
      Stream fromStream,
      ArraySegment<byte> intoBuffer,
      CancellationToken cancellationToken)
    {
      ArraySegment<byte> smallBuffer;
      WebSocketFrame result;
      try
      {
        smallBuffer = new ArraySegment<byte>(new byte[8]);
        TaskAwaiter awaiter1 = BinaryReaderWriter.ReadExactly(2, fromStream, smallBuffer, cancellationToken).GetAwaiter();
        TaskAwaiter taskAwaiter1;
        int num1;
        if (!awaiter1.IsCompleted)
        {
          (^this).\u003C\u003E1__state = num1 = 0;
          taskAwaiter1 = awaiter1;
          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WebSocketFrameReader.\u003CReadAsync\u003Ed__0>(ref awaiter1, this);
          return;
        }
        awaiter1.GetResult();
        byte num2 = smallBuffer.Array[0];
        byte byte2 = smallBuffer.Array[1];
        byte num3 = 128;
        byte num4 = 15;
        bool isFinBitSet = ((int) num2 & (int) num3) == (int) num3;
        WebSocketOpCode opCode = (WebSocketOpCode) ((int) num2 & (int) num4);
        byte num5 = 128;
        bool isMaskBitSet = ((int) byte2 & (int) num5) == (int) num5;
        TaskAwaiter<uint> awaiter2 = WebSocketFrameReader.ReadLength(byte2, smallBuffer, fromStream, cancellationToken).GetAwaiter();
        if (!awaiter2.IsCompleted)
        {
          (^this).\u003C\u003E1__state = num1 = 1;
          TaskAwaiter<uint> taskAwaiter2 = awaiter2;
          (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<uint>, WebSocketFrameReader.\u003CReadAsync\u003Ed__0>(ref awaiter2, this);
          return;
        }
        int count = (int) awaiter2.GetResult();
        try
        {
          if (isMaskBitSet)
          {
            ArraySegment<byte> maskKey = new ArraySegment<byte>(smallBuffer.Array, 0, 4);
            TaskAwaiter awaiter3 = BinaryReaderWriter.ReadExactly(maskKey.Count, fromStream, maskKey, cancellationToken).GetAwaiter();
            if (!awaiter3.IsCompleted)
            {
              (^this).\u003C\u003E1__state = num1 = 2;
              taskAwaiter1 = awaiter3;
              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WebSocketFrameReader.\u003CReadAsync\u003Ed__0>(ref awaiter3, this);
              return;
            }
            awaiter3.GetResult();
            TaskAwaiter awaiter4 = BinaryReaderWriter.ReadExactly(count, fromStream, intoBuffer, cancellationToken).GetAwaiter();
            if (!awaiter4.IsCompleted)
            {
              (^this).\u003C\u003E1__state = num1 = 3;
              taskAwaiter1 = awaiter4;
              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WebSocketFrameReader.\u003CReadAsync\u003Ed__0>(ref awaiter4, this);
              return;
            }
            awaiter4.GetResult();
            WebSocketFrameCommon.ToggleMask(maskKey, new ArraySegment<byte>(intoBuffer.Array, intoBuffer.Offset, count));
            maskKey = new ArraySegment<byte>();
          }
          else
          {
            TaskAwaiter awaiter3 = BinaryReaderWriter.ReadExactly(count, fromStream, intoBuffer, cancellationToken).GetAwaiter();
            if (!awaiter3.IsCompleted)
            {
              (^this).\u003C\u003E1__state = num1 = 4;
              taskAwaiter1 = awaiter3;
              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, WebSocketFrameReader.\u003CReadAsync\u003Ed__0>(ref awaiter3, this);
              return;
            }
            awaiter3.GetResult();
          }
        }
        catch (InternalBufferOverflowException ex)
        {
          throw new InternalBufferOverflowException(string.Format("Supplied buffer too small to read {0} bytes from {1} frame", (object) 0, (object) Enum.GetName(typeof (WebSocketOpCode), (object) opCode)), (Exception) ex);
        }
        result = opCode != WebSocketOpCode.ConnectionClose ? new WebSocketFrame(isFinBitSet, opCode, count) : WebSocketFrameReader.DecodeCloseFrame(isFinBitSet, opCode, count, intoBuffer);
      }
      catch (Exception ex)
      {
        (^this).\u003C\u003E1__state = -2;
        smallBuffer = new ArraySegment<byte>();
        (^this).\u003C\u003Et__builder.SetException(ex);
        return;
      }
      (^this).\u003C\u003E1__state = -2;
      smallBuffer = new ArraySegment<byte>();
      (^this).\u003C\u003Et__builder.SetResult(result);
    }

    private static WebSocketFrame DecodeCloseFrame(
      bool isFinBitSet,
      WebSocketOpCode opCode,
      int count,
      ArraySegment<byte> buffer)
    {
      WebSocketCloseStatus closeStatus;
      string closeStatusDescription;
      if (count >= 2)
      {
        Array.Reverse<byte>((M0[]) buffer.Array, buffer.Offset, 2);
        int uint16 = (int) BitConverter.ToUInt16(buffer.Array, buffer.Offset);
        closeStatus = !Enum.IsDefined(typeof (WebSocketCloseStatus), (object) uint16) ? WebSocketCloseStatus.Empty : (WebSocketCloseStatus) uint16;
        int index = buffer.Offset + 2;
        int count1 = count - 2;
        closeStatusDescription = count1 <= 0 ? (string) null : Encoding.UTF8.GetString(buffer.Array, index, count1);
      }
      else
      {
        closeStatus = WebSocketCloseStatus.Empty;
        closeStatusDescription = (string) null;
      }
      return new WebSocketFrame(isFinBitSet, opCode, count, closeStatus, closeStatusDescription);
    }

    private static async Task<uint> ReadLength(
      byte byte2,
      ArraySegment<byte> smallBuffer,
      Stream fromStream,
      CancellationToken cancellationToken)
    {
      uint num = (uint) byte2 & (uint) sbyte.MaxValue;
      switch (num)
      {
        case 126:
          num = (uint) await BinaryReaderWriter.ReadUShortExactly(fromStream, false, smallBuffer, cancellationToken);
          break;
        case (uint) sbyte.MaxValue:
          num = (uint) await BinaryReaderWriter.ReadULongExactly(fromStream, false, smallBuffer, cancellationToken);
          if (num > 2147483648U || num < 0U)
            throw new ArgumentOutOfRangeException(string.Format("Payload length out of range. Min 0 max 2GB. Actual {0:#,##0} bytes.", (object) num));
          break;
      }
      return num;
    }
  }
}
