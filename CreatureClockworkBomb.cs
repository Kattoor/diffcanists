
public class CreatureClockworkBomb : Creature
{
  public SpellClockworkBomb spell;

  public override ZCreature Get()
  {
    return (ZCreature) new ZCreatureClockworkBomb();
  }
}
