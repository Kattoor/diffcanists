
public class SpellSoulJar : Creature
{
  public override ZCreature Get()
  {
    return (ZCreature) new ZSpellSoulJar();
  }
}
