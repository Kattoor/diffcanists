
public class CreatureThorn : Creature
{
  public Spell spell;

  public override ZCreature Get()
  {
    return (ZCreature) new ZCreatureThorn();
  }
}
