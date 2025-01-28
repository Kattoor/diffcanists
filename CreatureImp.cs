
public class CreatureImp : Creature
{
  public override ZCreature Get()
  {
    return (ZCreature) new ZCreatureImp();
  }
}
