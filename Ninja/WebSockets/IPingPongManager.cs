
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja.WebSockets
{
  internal interface IPingPongManager
  {
    event EventHandler<PongEventArgs> Pong;

    Task SendPing(ArraySegment<byte> payload, CancellationToken cancellation);
  }
}
