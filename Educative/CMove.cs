
namespace Educative
{
  public class CMove : Command
  {
    public int entity = -2;
    public Point point_location = new Point(0.0, 0.0);

    public CMove()
    {
      this.type = Command.Type.Move;
    }
  }
}
