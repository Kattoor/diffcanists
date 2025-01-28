
namespace Educative
{
  public class CPanCamera : Command
  {
    public Point point_area = new Point(0.0, 0.0);
    public bool bool_interuptable = true;
    public bool bool_instant;

    public CPanCamera()
    {
      this.type = Command.Type.PanCamera;
    }
  }
}
