
namespace Educative
{
  public class CAddSpell : Command
  {
    public int entity = -2;
    public SpellEnum spellEnum = SpellEnum.Fire_Ball;
    public int cooldown = -1;
    public int turnsFirstUse = -1;
    public int maxUses = -1;
    public bool bool_remove;

    public CAddSpell()
    {
      this.type = Command.Type.AddSpell;
    }
  }
}
