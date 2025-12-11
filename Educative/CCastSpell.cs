
namespace Educative
{
  public class CCastSpell : Command
  {
    public int entity = -2;
    public SpellEnum spellEnum = SpellEnum.Fire_Ball;
    public Point point_target = new Point(0.0, 0.0);
    public float power = 1f;
    public float angle;

    public CCastSpell()
    {
      this.type = Command.Type.CastSpell;
    }
  }
}
