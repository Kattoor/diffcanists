
using MoonSharp.Interpreter;
using UnityEngine;

namespace Educative
{
  public class ContainerPlayer
  {
    [MoonSharpHidden]
    public ZPerson person;
    [MoonSharpHidden]
    private int _hashCode;

    [MoonSharpHidden]
    public ContainerPlayer(ZPerson p)
    {
      this.person = p;
      this._hashCode = p != null ? p.GetHashCode() : 0;
    }

    public int localTurn
    {
      get
      {
        return this.person.localTurn;
      }
      set
      {
        this.person.localTurn = Mathf.Clamp(value, 0, int.MaxValue);
      }
    }

    public string name
    {
      get
      {
        return this.person.name;
      }
    }

    public int team
    {
      get
      {
        return (int) this.person.id;
      }
    }

    public bool yourTurn
    {
      get
      {
        return this.person.yourTurn;
      }
    }

    public Table getCreatures(Script script)
    {
      Table table = new Table(script);
      int num = 1;
      foreach (ZCreature c in this.person.controlled)
      {
        table[(object) num] = (object) new ContainerCreature(c);
        ++num;
      }
      return table;
    }

    public ContainerCreature getCreature(int index)
    {
      return new ContainerCreature(this.person.controlled[index - 1]);
    }

    public int getMinionCount()
    {
      return this.person.GetMinionCount();
    }

    public override int GetHashCode()
    {
      return this._hashCode;
    }
  }
}
