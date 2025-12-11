
using MoonSharp.Interpreter;

namespace Educative
{
  public class ContainerTower
  {
    [MoonSharpHidden]
    public ZTower tower;
    private int _hashCode;

    [MoonSharpHidden]
    public ContainerTower(ZTower t)
    {
      this.tower = t;
      this._hashCode = (ZComponent) t != (object) null ? t.GetHashCode() : 0;
    }

    public int health
    {
      get
      {
        return this.tower.Health;
      }
      set
      {
        this.tower.Health = value;
        this.tower.creature.UpdateHealthTxt();
        if (this.tower.Health > 0)
          return;
        this.tower.creature.DestroyTower(false, true);
      }
    }

    public int maxHealth
    {
      get
      {
        return this.tower.MaxHealth;
      }
      set
      {
        this.tower.MaxHealth = value;
      }
    }

    public int x
    {
      get
      {
        return this.tower.position.x.ToInt();
      }
      set
      {
        this.tower.position = new MyLocation((FixedInt) value, this.tower.position.y);
        this.tower.ShouldFall();
      }
    }

    public int y
    {
      get
      {
        return this.tower.position.y.ToInt();
      }
      set
      {
        this.tower.position = new MyLocation(this.tower.position.x, (FixedInt) value);
        this.tower.ShouldFall();
      }
    }

    public Point position
    {
      get
      {
        MyLocation position = this.tower.position;
        double x = (double) position.x.ToInt();
        position = this.tower.position;
        double y = (double) position.y.ToInt();
        return new Point(x, y);
      }
      set
      {
        this.tower.position = new MyLocation((FixedInt) (float) value.x, (FixedInt) (float) value.y);
        this.tower.ShouldFall();
      }
    }

    public bool isDead
    {
      get
      {
        return (ZComponent) this.tower == (object) null || (ZComponent) this.tower.creature == (object) null || (ZComponent) this.tower.creature.tower == (object) null || this.tower.Health <= 0;
      }
    }

    public TowerType getType()
    {
      return this.tower.type;
    }

    public void kill()
    {
      this.tower.creature.DestroyTower(false, true);
    }

    public override int GetHashCode()
    {
      return this._hashCode;
    }
  }
}
