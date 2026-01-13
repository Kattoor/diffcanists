
using MoonSharp.Interpreter;
using UnityEngine;

namespace Educative
{
  public class ContainerCreature
  {
    [MoonSharpHidden]
    public ZCreature creature;
    [MoonSharpHidden]
    private int _hashCode;

    [MoonSharpHidden]
    public ContainerCreature(ZCreature c)
    {
      this.creature = c;
      this._hashCode = (ZComponent) c != (object) null ? c.GetHashCode() : 0;
    }

    public int team
    {
      get
      {
        return this.creature.team;
      }
    }

    public string name
    {
      get
      {
        return this.creature.name;
      }
    }

    public SpellEnum spellEnum
    {
      get
      {
        return this.creature.spellEnum;
      }
    }

    public int health
    {
      get
      {
        return this.creature.health;
      }
      set
      {
        this.creature.health = value;
        this.creature.UpdateHealthTxt();
        if (this.creature.health > 0)
          return;
        this.creature.OnDeath(true);
      }
    }

    public int maxHealth
    {
      get
      {
        return this.creature.maxHealth;
      }
      set
      {
        this.creature.maxHealth = value;
      }
    }

    public int healthAndTower
    {
      get
      {
        return this.creature.GetCurrentHealth();
      }
    }

    public int shield
    {
      get
      {
        return this.creature.shield;
      }
      set
      {
        this.creature.CreateProtectionShield(false);
        this.creature.shield = value;
        this.creature.UpdateHealthTxt();
      }
    }

    public int x
    {
      get
      {
        return this.creature.position.x.ToInt();
      }
      set
      {
        this.creature.MoveToPosition = new MyLocation((FixedInt) value, this.creature.position.y);
        this.creature.Demount(false);
        this.creature.Fall(false);
      }
    }

    public int y
    {
      get
      {
        return this.creature.position.y.ToInt();
      }
      set
      {
        this.creature.MoveToPosition = new MyLocation(this.creature.position.x, (FixedInt) value);
        this.creature.Demount(false);
        this.creature.Fall(false);
      }
    }

    public Point position
    {
      get
      {
        MyLocation position = this.creature.position;
        double x = (double) position.x.ToInt();
        position = this.creature.position;
        double y = (double) position.y.ToInt();
        return new Point(x, y);
      }
      set
      {
        this.creature.MoveToPosition = new MyLocation((FixedInt) (float) value.x, (FixedInt) (float) value.y);
        this.creature.Demount(false);
        this.creature.Fall(false);
      }
    }

    public ContainerPlayer parent
    {
      get
      {
        return new ContainerPlayer(this.creature.parent);
      }
      set
      {
        this.creature.SwitchTeams(value.person, false, true);
      }
    }

    public int weight
    {
      get
      {
        return (int) ((FixedInt) 100 - this.creature.massMulti * 100);
      }
      set
      {
        this.creature.massMulti = Mathd.Clamp((FixedInt) ((float) (100 - value) / 100f), (FixedInt) 0, (FixedInt) 1);
      }
    }

    public int radius
    {
      get
      {
        return this.creature.GetRadius();
      }
      set
      {
        this.SetRadius(value);
      }
    }

    public bool inTower
    {
      get
      {
        return (ZComponent) this.creature.tower != (object) null;
      }
    }

    public bool isMoving
    {
      get
      {
        return this.creature.isMoving;
      }
    }

    public bool stunned
    {
      get
      {
        return this.creature.stunned;
      }
      set
      {
        if (this.creature.stunned == value)
          return;
        this.creature.stunned = value;
        if (!value || !this.creature.game.isClient)
          return;
        ParticleDucks component = Object.Instantiate<GameObject>(Inert.Instance.GetDucks(), this.creature.transform.position + new Vector3(0.0f, (float) (this.radius + 15)), Quaternion.Euler(-55f, 0.0f, 0.0f), this.creature.transform).GetComponent<ParticleDucks>();
        component.c = this.creature.clientObj;
        this.creature.myducks = component;
      }
    }

    public bool superStunned
    {
      get
      {
        return this.creature.superStunned;
      }
      set
      {
        if (this.creature.superStunned == value)
          return;
        this.creature.stunned = value;
        this.creature.superStunned = value;
        if (!value || !this.creature.game.isClient)
          return;
        ParticleDucks component = Object.Instantiate<GameObject>(Inert.Instance.GetDucks(), this.creature.transform.position + new Vector3(0.0f, (float) (this.radius + 15)), Quaternion.Euler(-55f, 0.0f, 0.0f), this.creature.transform).GetComponent<ParticleDucks>();
        component.c = this.creature.clientObj;
        this.creature.myducks = component;
        component.SetRed();
      }
    }

    public bool waterWalking
    {
      get
      {
        return this.creature.waterWalking;
      }
      set
      {
        this.creature.waterWalking = value;
      }
    }

    public bool frostWalking
    {
      get
      {
        return this.creature.frostWalking;
      }
      set
      {
        this.creature.frostWalking = value;
      }
    }

    public bool inWater
    {
      get
      {
        return this.creature.inWater;
      }
    }

    public bool diesInWater
    {
      get
      {
        return this.creature.diesInWater;
      }
      set
      {
        this.creature.diesInWater = value;
      }
    }

    public CreatureType type
    {
      get
      {
        return this.creature.type;
      }
      set
      {
        this.creature.type = value;
      }
    }

    public CreatureRace race
    {
      get
      {
        return this.creature.race;
      }
      set
      {
        this.creature.race = value;
      }
    }

    public bool yourTurn
    {
      get
      {
        return this.creature.parent.yourTurn;
      }
    }

    public bool isRider
    {
      get
      {
        return (ZComponent) this.creature.mount != (object) null;
      }
    }

    public bool isMounted
    {
      get
      {
        return (ZComponent) this.creature.rider != (object) null;
      }
    }

    public bool isDead
    {
      get
      {
        return (ZComponent) this.creature == (object) null || this.creature.isDead;
      }
    }

    public bool isPawn
    {
      get
      {
        return this.creature.isPawn;
      }
    }

    public bool isFlying
    {
      get
      {
        return this.creature.flying;
      }
      set
      {
        this.creature.flying = value;
        this.creature.permenantFlight = value;
      }
    }

    public bool isMountable
    {
      get
      {
        return this.creature.mountable;
      }
    }

    public bool canMount
    {
      get
      {
        return this.creature.canMount;
      }
    }

    public bool arcaneMonster
    {
      get
      {
        return this.creature.FullArcane;
      }
      set
      {
        bool flag = value;
        if (this.creature.FullArcane == flag)
          return;
        this.creature.FullArcane = flag;
        if (!flag)
          return;
        this.creature.TutorialArcaneMonster();
      }
    }

    public bool takeDamage
    {
      get
      {
        return this.creature.invulnerable < 99999;
      }
      set
      {
        this.creature.invulnerable = value ? 0 : 99999;
      }
    }

    public ContainerCreature getRider()
    {
      return !this.isMounted ? (ContainerCreature) null : new ContainerCreature(this.creature.rider);
    }

    public ContainerCreature getMount()
    {
      return !this.isRider ? (ContainerCreature) null : new ContainerCreature(this.creature.mount);
    }

    public ContainerTower getTower()
    {
      return !this.inTower ? (ContainerTower) null : new ContainerTower(this.creature.tower);
    }

    public void LongJump(int dir)
    {
      if (this.isMoving)
        return;
      this.setDirection(dir);
      this.creature.LongJump(0);
    }

    public void HighJump(int dir)
    {
      if (this.isMoving)
        return;
      this.setDirection(dir);
      this.creature.HighJump(0);
    }

    public void Walk(int dir)
    {
      if (this.isMoving)
        return;
      this.setDirection(dir);
      this.creature.animator?.Play(AnimateState.Walk, 0.05f, true);
      if (dir < 0 || dir == 0 && (double) this.creature.transformscale < 0.0)
        this.creature.MoveLeft(0);
      else
        this.creature.MoveRight(0);
    }

    public void setDirection(int dir)
    {
      if (dir > 0)
      {
        if ((double) this.creature.transformscale >= 0.0)
          return;
        this.creature.SetScale((float) dir);
      }
      else
      {
        if (dir >= 0 || (double) this.creature.transformscale <= 0.0)
          return;
        this.creature.SetScale((float) dir);
      }
    }

    public int getDirection()
    {
      return (double) this.creature.transformscale <= 0.0 ? -1 : 1;
    }

    public int getFamiliarLevel(BookOf book)
    {
      int index = (int) book;
      return index < 0 || index >= this.creature.parent.familiarLevels.Length ? 0 : this.creature.parent.familiarLevels[index];
    }

    public int getActivateableFamiliarLevel()
    {
      return this.creature.familiarLevelActivateable;
    }

    public BookOf getActivateableFamiliarBookID()
    {
      return this.creature.parent.ActivateableFamiliar;
    }

    public void increaseFamiliarLevel(BookOf book = BookOf.Nothing, bool dealDmg = true, bool capAt5 = true)
    {
      int index = (int) book;
      if (index == -1)
        index = (int) this.getActivateableFamiliarBookID();
      if (index < 0 || index >= this.creature.parent.familiarLevels.Length)
        return;
      if (!capAt5 || this.creature.parent.familiarLevels[index] < 5)
        ++this.creature.parent.familiarLevels[index];
      if (dealDmg)
        this.creature.DoDamage(20, DamageType.None, (ZCreature) null, false, (ISpellBridge) null);
      if (this.creature.hasDarkDefenses)
        this.creature.DarkDefenses(true);
      this.creature.parent.familiarBook |= (FamiliarType) (1 << index);
      this.creature.game.CreateFamiliar((BookOf) index, this.creature.parent, true, false);
      if (!this.creature.game.isClient)
        return;
      this.creature.UpdateHealthTxt();
      if (!((Object) Player.Instance != (Object) null) || this.creature.parent != Player.Instance.person)
        return;
      HUD.instance.fullBookTextLevel.text = "Level " + this.creature.familiarLevelActivateable.ToString();
    }

    public bool inside(ContainerIndicator a)
    {
      return Mathd.Abs((FixedInt) MyLocation.Distance(this.creature.position, a.position.ToMyLocation())) < (FixedInt) (float) a.radius;
    }

    public bool inside(Point a, double radius)
    {
      return Mathd.Abs((FixedInt) MyLocation.Distance(this.creature.position, a.ToMyLocation())) < (FixedInt) (float) radius;
    }

    public bool overlap(ContainerIndicator a)
    {
      return Mathd.Abs((FixedInt) MyLocation.Distance(this.creature.position, a.position.ToMyLocation())) < (FixedInt) (float) a.radius + this.creature.GetRadius();
    }

    public bool overlap(Point a, double radius = 0.0)
    {
      return Mathd.Abs((FixedInt) MyLocation.Distance(this.creature.position, a.ToMyLocation())) < (FixedInt) (float) radius + this.creature.GetRadius();
    }

    public void die(bool playSound = true)
    {
      this.creature?.OnDeath(playSound);
    }

    private void SetRadius(int i)
    {
      int num1 = 18;
      if (this.creature.spellEnum != SpellEnum.None)
      {
        Spell spell = Inert.GetSpell(this.creature.spellEnum);
        if ((Object) spell != (Object) null)
          num1 = spell.radius;
      }
      i = Mathf.Clamp(i, 1, 8192);
      FixedInt fixedInt = (FixedInt) i / num1;
      float num2 = fixedInt.ToFloat();
      if ((Object) this.creature.transform != (Object) null)
        this.creature.transform.localScale = new Vector3(num2, num2, 1f);
      this.creature.radius = i;
      this.creature.zb = MapGenerator.getOutlineArray(this.creature.radius);
      double scale = (double) this.creature.scale;
      this.creature.scale = num2;
      this.creature.scaleFixed = fixedInt;
      this.creature.collider.radius = this.creature.radius;
      this.creature.collider.Moved();
      this.creature.SetScale(1f);
    }

    public ContainerSpell addSpell(object s)
    {
      Spell spell = ContainerGame.getSpell(s, (ZCreature) null);
      if (!((Object) spell != (Object) null))
        return (ContainerSpell) null;
      SpellSlot s1 = new SpellSlot(spell);
      if (s.GetType() == typeof (ContainerSpell))
        s1 = new SpellSlot(((ContainerSpell) s).slot);
      this.creature.spells.Add(s1);
      return new ContainerSpell(s1);
    }

    public void removeSpell(object s)
    {
      Spell spell = ContainerGame.getSpell(s, this.creature);
      if (!((Object) spell != (Object) null))
        return;
      for (int index = 0; index < this.creature.spells.Count; ++index)
      {
        if (this.creature.spells[index].spell.spellEnum == spell.spellEnum)
          this.creature.spells.RemoveAt(index);
      }
    }

    public void removeSpell(ContainerSpell spell)
    {
      for (int index = 0; index < this.creature.spells.Count; ++index)
      {
        if (this.creature.spells[index] == spell.slot)
        {
          this.creature.spells.RemoveAt(index);
          break;
        }
      }
    }

    public Table getSpells(Script script)
    {
      Table table = new Table(script);
      int num = 1;
      foreach (SpellSlot spell in this.creature.spells)
      {
        table[(object) num] = (object) new ContainerSpell(spell);
        ++num;
      }
      return table;
    }

    public ContainerSpell getSpell(object spellObj)
    {
      if (spellObj == null)
        return (ContainerSpell) null;
      SpellSlot s = (SpellSlot) null;
      if (spellObj.GetType() == typeof (string))
      {
        Spell spell = Inert.GetSpell((string) spellObj);
        if ((Object) spell != (Object) null)
          s = this.creature.GetSpellSlot(spell.spellEnum);
      }
      else if (spellObj.GetType() == typeof (double) || spellObj.GetType() == typeof (int))
        s = this.creature.spells[(int) spellObj - 1];
      else if (spellObj.GetType() == typeof (SpellEnum))
        s = this.creature.GetSpellSlot((SpellEnum) spellObj);
      return s == null ? (ContainerSpell) null : new ContainerSpell(s);
    }

    public int getSpellCount()
    {
      return this.creature.spells.Count;
    }

    public int castedCount(SpellEnum spellID)
    {
      return this.creature.parent.GetSpellCast(spellID);
    }

    public int castedCountThisTurn()
    {
      return this.creature.parent.spellsCastTHISTurn;
    }

    public int castedDamage(SpellEnum spellID)
    {
      return this.creature.parent.GetSpellDamage(spellID);
    }

    public int getMinionCount()
    {
      return this.creature.parent.GetMinionCount();
    }

    public void castSpell(
      object spellObj,
      Point target,
      double angle = 0.0,
      double power = 1.0,
      Point secTarget = null)
    {
      Spell spell = ContainerGame.getSpell(spellObj, this.creature);
      if (!((Object) spell != (Object) null))
        return;
      if (secTarget == (Point) null)
        secTarget = new Point(-1000.0, -1000.0);
      this.creature.game.serverState.busy = ServerState.Busy.Moving;
      ZSpell.FireWhich(spell, this.creature, this.creature.position, FixedInt.Create(angle), FixedInt.Create(power), new MyLocation((int) target.x, (int) target.y), new MyLocation((int) secTarget.x, (int) secTarget.y), 0, false, (SpellSlot) null, false, (ZPerson) null);
      if (!((ZComponent) this.creature == (object) Player.Instance?.person?.first()))
        return;
      Player.Instance.UnselectSpell();
    }

    public float angleToFire(object spellObj, Point target, float power = 1f)
    {
      Spell spell = ContainerGame.getSpell(spellObj, this.creature);
      if (!((Object) spell != (Object) null))
        return (float) (int) (FixedInt) 1L;
      MyLocation myLocation = target.ToMyLocation() - this.creature.position;
      myLocation.Normalize();
      FixedInt d = FixedInt.Abs(this.creature.position.x - (FixedInt) (float) target.x);
      FixedInt fixedInt = (FixedInt) spell.speedMax;
      if (fixedInt <= 0)
        fixedInt = (FixedInt) 1000;
      FixedInt x = spell.affectedByGravity ? ZSpell.AngleToGoDistance(fixedInt * (FixedInt) power, -this.creature.game.gravity, d, (FixedInt) (float) target.y - this.creature.position.y, true) : FixedInt.Atan2(myLocation.y, myLocation.x) * FixedInt.Rad2Deg;
      if (target.x < this.creature.position.x.ToDouble() && !FixedInt.InvalidAngle(x))
        x = (FixedInt) 180 - x;
      return x.ToFloat();
    }

    public float powerToFire(object spellObj, Point target, float angle = 45f)
    {
      Spell spell = ContainerGame.getSpell(spellObj, this.creature);
      if (!((Object) spell != (Object) null))
        return 1f;
      (target.ToMyLocation() - this.creature.position).Normalize();
      FixedInt distance = FixedInt.Abs(this.creature.position.x - (FixedInt) (float) target.x);
      FixedInt fixedInt = (FixedInt) spell.speedMax;
      if (fixedInt <= 0)
        fixedInt = (FixedInt) 1000;
      return (ZSpell.CalculateStartingVelocity(-this.creature.game.gravity, distance, (FixedInt) (float) target.y - this.creature.position.y, (FixedInt) angle) / fixedInt).ToFloat();
    }

    public void fireAt(object spellObj, ContainerCreature target, double anglevariance = 0.0)
    {
      this.fireAt(spellObj, target.position, anglevariance, (Point) null);
    }

    public void fireAt(object spellObj, Point target, double anglevariance = 0.0, Point secTarget = null)
    {
      Spell spell = ContainerGame.getSpell(spellObj, this.creature);
      if (!((Object) spell != (Object) null))
        return;
      MyLocation myLocation = target.ToMyLocation() - this.creature.position;
      myLocation.Normalize();
      FixedInt d = FixedInt.Abs(this.creature.position.x - (FixedInt) (float) target.x);
      FixedInt v = (FixedInt) spell.speedMax;
      if (v <= 0)
        v = (FixedInt) 1000;
      FixedInt fixedInt = spell.affectedByGravity ? ZSpell.AngleToGoDistance(v / 2, -this.creature.game.gravity, d, (FixedInt) (float) target.y - this.creature.position.y, true) : FixedInt.Atan2(myLocation.y, myLocation.x) * FixedInt.Rad2Deg;
      FixedInt power = (FixedInt) 524288L;
      if (d > 10 && FixedInt.InvalidAngle(fixedInt))
      {
        power = (FixedInt) 1;
        fixedInt = ZSpell.AngleToGoDistance(v, -this.creature.game.gravity, d, (FixedInt) (float) target.y - this.creature.position.y, false);
        if (FixedInt.InvalidAngle(fixedInt))
          fixedInt = (FixedInt) 47185920L;
      }
      if (target.x < this.creature.position.x.ToDouble())
        fixedInt = (FixedInt) 180 - fixedInt;
      if (spell.type == CastType.Power)
        fixedInt += (FixedInt) Random.Range(-(float) anglevariance, (float) anglevariance);
      this.creature.game.serverState.busy = ServerState.Busy.Moving;
      if (secTarget == (Point) null)
        secTarget = new Point(-1000.0, -1000.0);
      ZSpell.FireWhich(spell, this.creature, this.creature.position, fixedInt, power, new MyLocation((int) target.x, (int) target.y), new MyLocation((int) secTarget.x, (int) secTarget.y), 0, false, (SpellSlot) null, false, (ZPerson) null);
    }

    public Table getEffectors(Script script)
    {
      Table table = new Table(script);
      int num = 1;
      foreach (ZEffector effector in this.creature.effectors)
      {
        if (!ZComponent.IsNull((ZComponent) effector))
        {
          table[(object) num] = (object) new ContainerEffector(effector);
          ++num;
        }
      }
      foreach (ZEffector destroyableEffector in this.creature.destroyableEffectors)
      {
        if (!ZComponent.IsNull((ZComponent) destroyableEffector))
        {
          table[(object) num] = (object) new ContainerEffector(destroyableEffector);
          ++num;
        }
      }
      return table;
    }

    public Table getEffectors(Script script, bool destroyable)
    {
      Table table = new Table(script);
      int num = 1;
      if (!destroyable)
      {
        foreach (ZEffector effector in this.creature.effectors)
        {
          if (!ZComponent.IsNull((ZComponent) effector))
          {
            table[(object) num] = (object) new ContainerEffector(effector);
            ++num;
          }
        }
      }
      if (destroyable)
      {
        foreach (ZEffector destroyableEffector in this.creature.destroyableEffectors)
        {
          if (!ZComponent.IsNull((ZComponent) destroyableEffector))
          {
            table[(object) num] = (object) new ContainerEffector(destroyableEffector);
            ++num;
          }
        }
      }
      return table;
    }

    public override bool Equals(object obj)
    {
      return !(typeof (ContainerCreature) != obj?.GetType()) && (ZComponent) this.creature == (object) ((ContainerCreature) obj).creature;
    }

    public override int GetHashCode()
    {
      return this._hashCode;
    }

    public static bool operator ==(ContainerCreature v, ContainerCreature x)
    {
      return (object) x == null ? (object) v == null : (ZComponent) v.creature == (object) x.creature;
    }

    public static bool operator !=(ContainerCreature v, ContainerCreature x)
    {
      return (object) x == null ? v != null : (ZComponent) v.creature != (object) x.creature;
    }
  }
}
