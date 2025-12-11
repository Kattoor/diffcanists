
namespace Educative
{
  public class CCreateIndicator : Command
  {
    public float lifetime = -1f;
    public Point point_point = new Point(0.0, 0.0);
    public int radius = 256;
    public string hexColor = "#ffffffff";
    public CCreateIndicator.Kinds kind;
    public float angle;

    public CCreateIndicator()
    {
      this.type = Command.Type.CreateIndicator;
    }

    public enum Kinds
    {
      Area,
      Point,
      MovingArrow,
      Arrow,
      Meter_Fill,
      Meter_Flash,
      Meter_Bolt,
      Meter_Target,
    }
  }
}
