
public class CreatureJavelin : Creature
{
  public Spell spell;

  public override ZCreature Get()
  {
    return (ZCreature) new ZCreatureJavelin();
  }
}
