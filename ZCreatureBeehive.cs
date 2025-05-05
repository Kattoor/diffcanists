
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ZCreatureBeehive : ZCreature
{
  public List<ZCreature> bees = new List<ZCreature>();

  public override void OnNextTurn()
  {
    for (int index1 = this.bees.Count - 1; index1 >= 0; --index1)
    {
      if (index1 < this.bees.Count)
      {
        if ((ZComponent) this.bees[index1] == (object) null || this.bees[index1].isDead || this.bees[index1].team != this.team)
        {
          this.bees.RemoveAt(index1);
        }
        else
        {
          ZCreature bee = this.bees[index1];
          if (bee.invulnerable > 0)
            --bee.invulnerable;
          if (bee.superStunned)
            bee.superStunned = false;
          else
            bee.stunned = false;
          for (int index2 = bee.effectors.Count - 1; index2 >= 0; --index2)
          {
            if (ZComponent.IsNull((ZComponent) bee.effectors[index2]) || bee.effectors[index2].dead)
              bee.effectors.RemoveAt(index2);
            else
              bee.effectors[index2].TurnPassed(index2, false, false);
          }
          for (int index3 = bee.destroyableEffectors.Count - 1; index3 >= 0; --index3)
          {
            if (ZComponent.IsNull((ZComponent) bee.destroyableEffectors[index3]))
              bee.destroyableEffectors.RemoveAt(index3);
            else
              bee.destroyableEffectors[index3].TurnPassed(index3, true, false);
          }
          if (bee.halfHealing > 0)
            --bee.halfHealing;
          if (bee.bleeding && bee.health > 1)
          {
            --bee.bleedCounter;
            bee.DoDamage(Mathf.Min(bee.health - 1, 10));
            ZSpell.RandomBlood(bee.game, bee.position);
          }
        }
      }
    }
    if (this.race != CreatureRace.Undead)
      return;
    for (int count = this.bees.Count; count < 3; ++count)
      this.CreateBee();
  }

  public override void OnDeath(bool playDeathClip = true)
  {
    foreach (ZCreature bee in this.bees)
    {
      if ((ZComponent) bee != (object) null && !bee.isDead)
        bee.OnDeath(playDeathClip);
    }
    base.OnDeath(playDeathClip);
  }

  public void CreateBee()
  {
    MyLocation position = this.position;
    for (int index = 0; index < 50; ++index)
    {
      MyLocation target = this.position + new MyLocation(this.game.RandomInt(-50, 50), this.game.RandomInt(-50, 50));
      if (this.bees.Count < 3 && this.game.map.CheckCircle((int) target.x, (int) target.y, Inert.Instance.undeadBee.radius, (ZCreature) null, Inert.mask_movement_NoEffector))
      {
        ZSpell.FireSummon(Inert.GetSpell(SpellEnum.Summon_Undead_Bees), this.game, (ZCreature) this, target, 1);
        break;
      }
    }
  }

  public override void DoFlipFlop(float scaleX)
  {
    for (int index = this.bees.Count - 1; index >= 0; --index)
    {
      if (index < this.bees.Count)
      {
        ZCreature bee = this.bees[index];
        if ((ZComponent) bee == (object) null || bee.isDead)
          this.bees.RemoveAt(index);
        else
          bee.DoFlipFlop(scaleX);
      }
    }
    base.DoFlipFlop(scaleX);
  }

  public override void MoveLeft(int extraBits = 0)
  {
    for (int index = this.bees.Count - 1; index >= 0; --index)
    {
      if (index < this.bees.Count)
      {
        ZCreature bee = this.bees[index];
        if ((ZComponent) bee == (object) null || bee.isDead)
          this.bees.RemoveAt(index);
        else if (!bee.stunned)
        {
          if (bee.flying && !bee.entangledOrGravity)
          {
            bee.velocity = new MyLocation((FixedInt) ((double) bee.transformscale < 0.0 ? -11010048L : -6291456L), (FixedInt) 0);
            bee.SetScale(-1f);
            bee.moving = this.game.ongoing.RunCoroutine(bee.FlyMove(true));
          }
          else
            bee.MoveLeft();
        }
      }
    }
    this.SetScale(-1f);
  }

  public override void MoveRight(int extraBits = 0)
  {
    for (int index = this.bees.Count - 1; index >= 0; --index)
    {
      if (index < this.bees.Count)
      {
        ZCreature bee = this.bees[index];
        if ((ZComponent) bee == (object) null || bee.isDead)
          this.bees.RemoveAt(index);
        else if (!bee.stunned)
        {
          if (bee.flying && !bee.entangledOrGravity)
          {
            bee.velocity = new MyLocation((FixedInt) ((double) bee.transformscale > 0.0 ? 9437184L : 4194304L), (FixedInt) 0);
            bee.SetScale(1f);
            bee.moving = this.game.ongoing.RunCoroutine(bee.FlyMove(true));
          }
          else
            bee.MoveRight();
        }
      }
    }
    this.SetScale(1f);
  }

  public override void DoHighJump(int extraBits)
  {
    for (int index = this.bees.Count - 1; index >= 0; --index)
    {
      if (index < this.bees.Count)
      {
        ZCreature bee = this.bees[index];
        if ((ZComponent) bee == (object) null || bee.isDead)
          this.bees.RemoveAt(index);
        else if (!bee.stunned)
          bee.DoHighJump(extraBits);
      }
    }
  }

  public override void DoLongJump(int extraBits)
  {
    for (int index = this.bees.Count - 1; index >= 0; --index)
    {
      if (index < this.bees.Count)
      {
        ZCreature bee = this.bees[index];
        if ((ZComponent) bee == (object) null || bee.isDead)
          this.bees.RemoveAt(index);
        else if (!bee.stunned)
          bee.DoLongJump(extraBits);
      }
    }
  }
}
