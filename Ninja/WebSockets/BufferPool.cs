
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja.WebSockets
{
  public class BufferPool : IBufferPool
  {
    private const int DEFAULT_BUFFER_SIZE = 16384;
    private readonly ConcurrentStack<byte[]> _bufferPoolStack;
    private readonly int _bufferSize;

    public BufferPool()
      : this(16384)
    {
    }

    public BufferPool(int bufferSize)
    {
      this._bufferSize = bufferSize;
      this._bufferPoolStack = new ConcurrentStack<byte[]>();
    }

    public MemoryStream GetBuffer()
    {
      byte[] result;
      if (!this._bufferPoolStack.TryPop(out result))
        result = new byte[this._bufferSize];
      return (MemoryStream) new BufferPool.PublicBufferMemoryStream(result, this);
    }

    protected void ReturnBuffer(byte[] buffer)
    {
      this._bufferPoolStack.Push(buffer);
    }

    protected class PublicBufferMemoryStream : MemoryStream
    {
      private readonly BufferPool _bufferPoolInternal;
      private byte[] _buffer;
      private MemoryStream _ms;

      public PublicBufferMemoryStream(byte[] buffer, BufferPool bufferPool)
        : base(new byte[0])
      {
        this._bufferPoolInternal = bufferPool;
        this._buffer = buffer;
        this._ms = new MemoryStream(buffer, 0, buffer.Length, true, true);
      }

      public override long Length
      {
        get
        {
          return base.Length;
        }
      }

      public override IAsyncResult BeginRead(
        byte[] buffer,
        int offset,
        int count,
        AsyncCallback callback,
        object state)
      {
        return this._ms.BeginRead(buffer, offset, count, callback, state);
      }

      public override IAsyncResult BeginWrite(
        byte[] buffer,
        int offset,
        int count,
        AsyncCallback callback,
        object state)
      {
        return this._ms.BeginWrite(buffer, offset, count, callback, state);
      }

      public override bool CanRead
      {
        get
        {
          return this._ms.CanRead;
        }
      }

      public override bool CanSeek
      {
        get
        {
          return this._ms.CanSeek;
        }
      }

      public override bool CanTimeout
      {
        get
        {
          return this._ms.CanTimeout;
        }
      }

      public override bool CanWrite
      {
        get
        {
          return this._ms.CanWrite;
        }
      }

      public override int Capacity
      {
        get
        {
          return this._ms.Capacity;
        }
        set
        {
          this._ms.Capacity = value;
        }
      }

      public override void Close()
      {
        Array.Clear((Array) this._buffer, 0, (int) this._ms.Position);
        this._ms.Close();
        this._bufferPoolInternal.ReturnBuffer(this._buffer);
      }

      public override Task CopyToAsync(
        Stream destination,
        int bufferSize,
        CancellationToken cancellationToken)
      {
        return this._ms.CopyToAsync(destination, bufferSize, cancellationToken);
      }

      public override int EndRead(IAsyncResult asyncResult)
      {
        return this._ms.EndRead(asyncResult);
      }

      public override void EndWrite(IAsyncResult asyncResult)
      {
        this._ms.EndWrite(asyncResult);
      }

      public override void Flush()
      {
        this._ms.Flush();
      }

      public override Task FlushAsync(CancellationToken cancellationToken)
      {
        return this._ms.FlushAsync(cancellationToken);
      }

      public override byte[] GetBuffer()
      {
        return this._buffer;
      }

      public override long Position
      {
        get
        {
          return this._ms.Position;
        }
        set
        {
          this._ms.Position = value;
        }
      }

      public override int Read(byte[] buffer, int offset, int count)
      {
        return this._ms.Read(buffer, offset, count);
      }

      private void EnlargeBufferIfRequired(int count)
      {
        if ((long) count <= (long) this._buffer.Length - this._ms.Position)
          return;
        int position = (int) this._ms.Position;
        int length = this._buffer.Length * 2;
        int num = count + this._buffer.Length - position;
        if (num > length)
          length = (int) Math.Pow(2.0, Math.Ceiling(Math.Log((double) num) / Math.Log(2.0)));
        byte[] buffer = new byte[length];
        Buffer.BlockCopy((Array) this._buffer, 0, (Array) buffer, 0, position);
        MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length, true, true);
        memoryStream.Position = (long) position;
        this._ms = memoryStream;
        this._buffer = buffer;
      }

      public override void WriteByte(byte value)
      {
        this.EnlargeBufferIfRequired(1);
        this._ms.WriteByte(value);
      }

      public override void Write(byte[] buffer, int offset, int count)
      {
        this.EnlargeBufferIfRequired(count);
        this._ms.Write(buffer, offset, count);
      }

      public override Task WriteAsync(
        byte[] buffer,
        int offset,
        int count,
        CancellationToken cancellationToken)
      {
        this.EnlargeBufferIfRequired(count);
        return this._ms.WriteAsync(buffer, offset, count);
      }

      public override object InitializeLifetimeService()
      {
        return this._ms.InitializeLifetimeService();
      }

      public override Task<int> ReadAsync(
        byte[] buffer,
        int offset,
        int count,
        CancellationToken cancellationToken)
      {
        return this._ms.ReadAsync(buffer, offset, count, cancellationToken);
      }

      public override int ReadByte()
      {
        return this._ms.ReadByte();
      }

      public override int ReadTimeout
      {
        get
        {
          return this._ms.ReadTimeout;
        }
        set
        {
          this._ms.ReadTimeout = value;
        }
      }

      public override long Seek(long offset, SeekOrigin loc)
      {
        return this._ms.Seek(offset, loc);
      }

      public override void SetLength(long value)
      {
        this.EnlargeBufferIfRequired((int) value);
      }

      public override byte[] ToArray()
      {
        return this._ms.ToArray();
      }

      public override int WriteTimeout
      {
        get
        {
          return this._ms.WriteTimeout;
        }
        set
        {
          this._ms.WriteTimeout = value;
        }
      }

      public override bool TryGetBuffer(out ArraySegment<byte> buffer)
      {
        buffer = new ArraySegment<byte>(this._buffer, 0, (int) this._ms.Position);
        return true;
      }

      public override void WriteTo(Stream stream)
      {
        this._ms.WriteTo(stream);
      }
    }
  }
}
