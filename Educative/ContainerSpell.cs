
using MoonSharp.Interpreter;

namespace Educative
{
  public class ContainerSpell
  {
    [MoonSharpHidden]
    public SpellSlot slot;

    [MoonSharpHidden]
    public ContainerSpell(SpellSlot s)
    {
      this.slot = s;
    }

    public int uses
    {
      get
      {
        return this.slot.UsedUses;
      }
      set
      {
        this.slot.SetUses = value;
      }
    }

    public int maxUses
    {
      get
      {
        return this.slot.MaxUses;
      }
      set
      {
        this.slot.MaxUses = value;
      }
    }

    public int rechargeTime
    {
      get
      {
        return this.slot.RechargeTime;
      }
      set
      {
        this.slot.RechargeTime = value;
      }
    }

    public int lastTurnFired
    {
      get
      {
        return this.slot.LastTurnFired;
      }
      set
      {
        this.slot.SetTurnFired = value;
      }
    }

    public bool isPresent
    {
      get
      {
        return this.slot.isPresent;
      }
      set
      {
        this.slot.isPresent = value;
      }
    }

    public bool locked
    {
      get
      {
        return this.slot.disabledturn == 999;
      }
      set
      {
        this.slot.disabledturn = value ? 999 : 0;
      }
    }

    public int turnsTillFirstUse
    {
      get
      {
        return this.slot.TurnsTillFirstUse;
      }
      set
      {
        this.slot.TurnsTillFirstUse = value;
      }
    }

    public SpellEnum spellEnum
    {
      get
      {
        return this.slot.spell.spellEnum;
      }
    }

    public CastType castType
    {
      get
      {
        return this.slot.spell.type;
      }
    }

    public DamageType damageType
    {
      get
      {
        return this.slot.spell.damageType;
      }
    }

    public BookOf book
    {
      get
      {
        return this.slot.spell.bookOf;
      }
    }

    public int damage
    {
      get
      {
        return this.slot.spell.damage;
      }
    }

    public int explosionRadius
    {
      get
      {
        return this.slot.spell.EXORADIUS;
      }
    }

    public string description
    {
      get
      {
        return Descriptions.GetSpellDescription(this.slot.spell.name, this.slot, true).description;
      }
    }

    public string descriptionOnly
    {
      get
      {
        return Descriptions.GetSpellDescription(this.slot.spell.name, this.slot, false).description;
      }
    }

    public string descriptionExtra
    {
      get
      {
        return Descriptions.GetSpellDescription(this.slot.spell.name, this.slot, false).extra;
      }
    }

    public string name
    {
      get
      {
        return this.slot.spell.name;
      }
    }
  }
}
