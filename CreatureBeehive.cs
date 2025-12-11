
public class CreatureBeehive : Creature
{
  public override ZCreature Get()
  {
    return (ZCreature) new ZCreatureBeehive();
  }
}
