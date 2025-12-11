
using System.Net;

namespace Hazel
{
  public abstract class NetworkConnection : Connection
  {
    public EndPoint RemoteEndPoint { get; protected set; }

    public IPMode IPMode { get; protected set; }
  }
}
