
using System.Net;

namespace Hazel
{
  public sealed class NetworkEndPoint : ConnectionEndPoint
  {
    public EndPoint EndPoint { get; set; }

    public IPMode IPMode { get; set; }

    public NetworkEndPoint(EndPoint endPoint, IPMode mode = IPMode.IPv4)
    {
      this.EndPoint = endPoint;
      this.IPMode = mode;
    }

    public NetworkEndPoint(IPAddress address, int port, IPMode mode = IPMode.IPv4)
      : this((EndPoint) new IPEndPoint(address, port), mode)
    {
    }

    public NetworkEndPoint(string IP, int port, IPMode mode = IPMode.IPv4)
      : this(IPAddress.Parse(IP), port, mode)
    {
    }

    public override string ToString()
    {
      return this.EndPoint.ToString();
    }
  }
}
