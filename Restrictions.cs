
using System;

[Serializable]
public class Restrictions
{
  public BitBools availableSpells = new BitBools();
  public BitBools altSpells = new BitBools();
  public int elementals = -1;
  public int alternateEle = -1;
  public const byte Version = 2;

  public int GetElementals(bool altBook)
  {
    return !altBook ? this.elementals : this.alternateEle;
  }

  public BitBools Getspells(bool altBook)
  {
    return !altBook ? this.availableSpells : this.altSpells;
  }

  public Restrictions()
  {
    this.availableSpells.SetAll();
    this.altSpells.SetAll();
  }

  public static Restrictions Combine(Restrictions a, Restrictions b)
  {
    Restrictions restrictions = new Restrictions();
    for (int index = 0; index < 8; ++index)
    {
      restrictions.availableSpells.array[index] = a.availableSpells.array[index] & b.availableSpells.array[index];
      restrictions.altSpells.array[index] = a.altSpells.array[index] & b.altSpells.array[index];
    }
    restrictions.elementals = a.elementals & b.elementals;
    return restrictions;
  }

  public bool AnyRestricted()
  {
    return !this.availableSpells.AllOn() || this.elementals != -1 || this.alternateEle != -1 || !this.altSpells.AllOn();
  }

  public bool HasRestricted(SpellsOnly spells)
  {
    for (int index = 0; index < 16; ++index)
    {
      bool flag = spells.IsAlt((int) spells.spells[index]);
      if (spells.spells[index] < byte.MaxValue && (!flag && !this.availableSpells[(int) spells.spells[index]] || flag && !this.altSpells[(int) spells.spells[index]]))
        return true;
    }
    return false;
  }

  public bool CleanseSpells(SpellsOnly spells)
  {
    for (int index = 0; index < 16; ++index)
    {
      bool flag = spells.IsAlt((int) spells.spells[index]);
      if (spells.spells[index] < byte.MaxValue && (!flag && !this.availableSpells[(int) spells.spells[index]] || flag && !this.altSpells[(int) spells.spells[index]]))
        spells.spells[index] = byte.MaxValue;
    }
    return false;
  }

  public int CleanseElemental(SpellsOnly spells, int i)
  {
    if (spells.UsingAltBook((BookOf) i))
    {
      if ((this.alternateEle & 1 << i) != 0)
        return i;
      for (i = 0; i < 32; ++i)
      {
        if ((this.alternateEle & 1 << i) != 0)
          return i;
      }
      return -1;
    }
    if ((this.elementals & 1 << i) != 0)
      return i;
    for (i = 0; i < 32; ++i)
    {
      if ((this.elementals & 1 << i) != 0)
        return i;
    }
    return -1;
  }

  public bool CheckRestricted(SpellsOnly spells, int i)
  {
    if (i < 0 || i >= 256)
      return true;
    return !spells.IsAlt(i) ? !this.availableSpells[i] : !this.altSpells[i];
  }

  public bool CheckElemental(SpellsOnly spells, int i)
  {
    return ((spells.UsingAltBook((BookOf) i) ? this.alternateEle : this.elementals) & 1 << i) == 0;
  }

  public static bool IsSpellRestricted(SpellsOnly spells, int i, Restrictions def = null)
  {
    if (i < 0 || i >= 256)
      return true;
    if (def != null)
      return !spells.IsAlt(i) ? def.availableSpells[i] : def.altSpells[i];
    if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && Client._gameFacts.settings.restrictions != null)
      return !spells.IsAlt(i) ? !Client._gameFacts.settings.restrictions.availableSpells[i] : !Client._gameFacts.settings.restrictions.altSpells[i];
    if (!Client.viewSpellLocks.ViewRestricted() && !((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null) || Server._restrictions == null)
      return false;
    int num = spells.IsAlt(i) ? (Server._restrictions.altSpells[i] ? 1 : 0) : (Server._restrictions.availableSpells[i] ? 1 : 0);
    return false;
  }

  public static bool IsElementalRestricted(SpellsOnly spells, int i, Restrictions def = null)
  {
    if (def != null)
      return ((spells.UsingAltBook((BookOf) i) ? def.alternateEle : def.elementals) & 1 << i) == 0;
    if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && Client._gameFacts.settings.restrictions != null)
      return (Client._gameFacts.settings.restrictions.GetElementals(spells.UsingAltBook((BookOf) i)) & 1 << i) == 0;
    if (!Client.viewSpellLocks.ViewRestricted() && !((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null) || Server._restrictions == null)
      return false;
    int num = ((spells.UsingAltBook((BookOf) i) ? Server._restrictions.alternateEle : Server._restrictions.elementals) & 1 << i) == 0 ? 1 : 0;
    return false;
  }

  public void Copy(Restrictions r)
  {
    this.availableSpells.Copy(r.availableSpells);
    this.altSpells.Copy(r.altSpells);
    this.alternateEle = r.alternateEle;
    this.elementals = r.elementals;
  }

  public void Serialize(myBinaryWriter w)
  {
    this.availableSpells.Serialize(w);
    w.Write(this.elementals);
    this.altSpells.Serialize(w);
    w.Write(this.alternateEle);
  }

  public void DeserializeInstance(myBinaryReader w)
  {
    this.availableSpells.Deserialize(w);
    this.elementals = w.ReadInt32();
  }

  public void DeserializeInstance2(myBinaryReader w)
  {
    this.availableSpells.Deserialize(w);
    this.elementals = w.ReadInt32();
    this.altSpells.Deserialize(w);
    this.alternateEle = w.ReadInt32();
  }

  public static Restrictions Deserialize(myBinaryReader w, byte version)
  {
    Restrictions restrictions = new Restrictions();
    if (version <= (byte) 1)
      restrictions.DeserializeInstance(w);
    else
      restrictions.DeserializeInstance2(w);
    return restrictions;
  }

  public bool ToggleSpell(int i, bool alt)
  {
    this.Getspells(alt)[i] = !this.Getspells(alt)[i];
    PopupRestrictions.Instance.SpellEnabled(i, this.Getspells(alt)[i], alt);
    return this.Getspells(alt)[i];
  }

  public bool ToggleSpell(int i, bool v, bool alt)
  {
    this.Getspells(alt)[i] = v;
    PopupRestrictions.Instance.SpellEnabled(i, this.Getspells(alt)[i], alt);
    return this.Getspells(alt)[i];
  }

  public bool ToggleBook(int e, bool alt)
  {
    int num = e * 12;
    bool v = true;
    BitBools bitBools = this.Getspells(alt);
    for (int index = 0; index < 12; ++index)
    {
      if (bitBools[num + index])
      {
        v = false;
        break;
      }
    }
    for (int index = 0; index < 12; ++index)
    {
      bitBools[num + index] = v;
      PopupRestrictions.Instance.SpellEnabled(num + index, v, alt);
    }
    return v;
  }

  public bool ToggleElemental(int i, bool alt)
  {
    if (alt)
    {
      this.alternateEle ^= 1 << i;
      PopupRestrictions.Instance.ElementalEnabled(i, (uint) (this.alternateEle & 1 << i) > 0U, alt);
      return (uint) (this.alternateEle & 1 << i) > 0U;
    }
    this.elementals ^= 1 << i;
    PopupRestrictions.Instance.ElementalEnabled(i, (uint) (this.elementals & 1 << i) > 0U, alt);
    return (uint) (this.elementals & 1 << i) > 0U;
  }

  public bool ToggleCastType(int e)
  {
    --e;
    CastType castType = (CastType) e;
    bool v = true;
    int num = (int) (RandomExtensions.LastBook() + 1) * 12;
    for (int index = 0; index < num; ++index)
    {
      if (Inert.Instance.spells[index].type == castType && this.availableSpells[index])
      {
        v = false;
        break;
      }
    }
    if (v)
    {
      for (int index = 0; index < num; ++index)
      {
        if (Inert.Instance.altSpells != null && Inert.Instance.altSpells[index].type == castType && this.altSpells[index])
        {
          v = false;
          break;
        }
      }
    }
    for (int index = 0; index < num; ++index)
    {
      if (Inert.Instance.spells[index].type == castType)
      {
        this.availableSpells[index] = v;
        PopupRestrictions.Instance.SpellEnabled(index, v, false);
      }
    }
    for (int index = 0; index < num; ++index)
    {
      if (Inert.Instance.altSpells != null && Inert.Instance.altSpells[index].type == castType)
      {
        this.altSpells[index] = v;
        PopupRestrictions.Instance.SpellEnabled(index, v, true);
      }
    }
    return v;
  }

  public bool ToggleSpellType(int e)
  {
    --e;
    SpellType spellType = (SpellType) e;
    bool v = true;
    int num = (int) (RandomExtensions.LastBook() + 1) * 12;
    for (int index = 0; index < num; ++index)
    {
      if (Inert.Instance.spells[index].spellType == spellType && this.availableSpells[index])
      {
        v = false;
        break;
      }
    }
    if (v)
    {
      for (int index = 0; index < num; ++index)
      {
        if (Inert.Instance.altSpells != null && Inert.Instance.altSpells[index].spellType == spellType && this.altSpells[index])
        {
          v = false;
          break;
        }
      }
    }
    for (int index = 0; index < num; ++index)
    {
      if (Inert.Instance.spells[index].spellType == spellType)
      {
        this.availableSpells[(int) (byte) index] = v;
        PopupRestrictions.Instance.SpellEnabled(index, v, false);
      }
    }
    for (int index = 0; index < num; ++index)
    {
      if (Inert.Instance.altSpells != null && Inert.Instance.altSpells[index].spellType == spellType)
      {
        this.altSpells[index] = v;
        PopupRestrictions.Instance.SpellEnabled(index, v, true);
      }
    }
    return v;
  }
}
