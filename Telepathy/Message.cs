
#nullable disable
namespace Telepathy
{
  public struct Message(int connectionId, EventType eventType, byte[] data)
  {
    public readonly int connectionId = connectionId;
    public readonly EventType eventType = eventType;
    public readonly byte[] data = data;
  }
}
