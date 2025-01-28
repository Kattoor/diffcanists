
using System.IO;

namespace Ninja.WebSockets
{
  public interface IBufferPool
  {
    MemoryStream GetBuffer();
  }
}
