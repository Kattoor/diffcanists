
using System;

namespace Ninja.WebSockets.Exceptions
{
  [Serializable]
  public class ServerListenerSocketException : Exception
  {
    public ServerListenerSocketException()
    {
    }

    public ServerListenerSocketException(string message)
      : base(message)
    {
    }

    public ServerListenerSocketException(string message, Exception inner)
      : base(message, inner)
    {
    }
  }
}
