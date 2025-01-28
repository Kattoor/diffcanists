
using System.Collections.Generic;
using UnityEngine;

public class ZSpellConductorRod : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellConductorRod zspellConductorRod = this;
    zspellConductorRod.isMoving = true;
    zspellConductorRod.zb = MapGenerator.getOutlineArray(zspellConductorRod.radius);
    if (zspellConductorRod.spellEnum == SpellEnum.Conductor_Rod && (ZComponent) zspellConductorRod.parent != (object) null && zspellConductorRod.parent.familiarLevelStorm > 0)
      zspellConductorRod.clientObj.GetComponent<SpriteRenderer>().sprite = ClientResources.Instance.paperClip;
    if (gotoStatic)
      yield return 0.0f;
label_54:
    while (!zspellConductorRod.isDead)
    {
      zspellConductorRod.pX = zspellConductorRod.position.x;
      zspellConductorRod.pY = zspellConductorRod.position.y;
      FixedInt fixedInt1 = zspellConductorRod.position.x + zspellConductorRod.velocity.x;
      FixedInt fixedInt2 = zspellConductorRod.position.y + zspellConductorRod.velocity.y;
      zspellConductorRod.validX = zspellConductorRod.pX;
      zspellConductorRod.validY = zspellConductorRod.pY;
      zspellConductorRod.steps = 1;
      FixedInt x1 = zspellConductorRod.velocity.x;
      FixedInt y1 = zspellConductorRod.velocity.y;
      FixedInt fixedInt3 = zspellConductorRod.velocity.x;
      FixedInt fixedInt4 = zspellConductorRod.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellConductorRod.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellConductorRod.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellConductorRod.velocity.x / zspellConductorRod.steps;
        fixedInt4 = zspellConductorRod.velocity.y / zspellConductorRod.steps;
      }
      while (zspellConductorRod.steps > 0)
      {
        if (zspellConductorRod.map.SpellCheckEffectors(zspellConductorRod.toCollideCheck, (ZSpell) zspellConductorRod, (int) zspellConductorRod.validX, (int) zspellConductorRod.validY))
        {
          zspellConductorRod.position = new MyLocation(zspellConductorRod.validX, zspellConductorRod.validY);
          yield return 0.0f;
          goto label_54;
        }
        else
        {
          --zspellConductorRod.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellConductorRod.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellConductorRod.zb.Count) - zspellConductorRod.radius;
          if (num1 < 0)
            num1 += zspellConductorRod.zb.Count;
          for (int index1 = 0; index1 < zspellConductorRod.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellConductorRod.zb.Count;
            int num2 = (int) (fixedInt3 + zspellConductorRod.pX);
            int num3 = (int) (fixedInt4 + zspellConductorRod.pY);
            if (!zspellConductorRod.map.SpellCheckPosition(num2 + zspellConductorRod.zb[index2].x, num3 + zspellConductorRod.zb[index2].y, zspellConductorRod.toCollideCheck, Inert.mask_spell_movement))
            {
              int x2 = num2 + zspellConductorRod.zb[index2].x;
              int y2 = num3 + zspellConductorRod.zb[index2].y;
              ++zspellConductorRod.timesBounced;
              zspellConductorRod.position = new MyLocation(zspellConductorRod.validX, zspellConductorRod.validY);
              int num4 = num2 + zspellConductorRod.zb[index2].x;
              int num5 = num3 + zspellConductorRod.zb[index2].y;
              AudioManager.Play(zspellConductorRod.explosionClip);
              zspellConductorRod.hitCreature = zspellConductorRod.map.PhysicsCollideCreature((ZCreature) null, x2, y2, 0);
              goto label_29;
            }
          }
          zspellConductorRod.validX = zspellConductorRod.pX;
          zspellConductorRod.validY = zspellConductorRod.pY;
          zspellConductorRod.pX = zspellConductorRod.pX + fixedInt3;
          zspellConductorRod.pY = zspellConductorRod.pY + fixedInt4;
        }
      }
      zspellConductorRod.position = zspellConductorRod.position + zspellConductorRod.velocity;
      if (zspellConductorRod.position.y < zspellConductorRod.radius)
      {
        zspellConductorRod.moving = (IEnumerator<float>) null;
        zspellConductorRod.velocity = MyLocation.zero;
        zspellConductorRod.isMoving = false;
        zspellConductorRod.Splash();
        zspellConductorRod.DestroyDelay();
        break;
      }
      if (zspellConductorRod.addVelocity)
      {
        zspellConductorRod.addVelocity = false;
        zspellConductorRod.velocity = zspellConductorRod.velocity + zspellConductorRod.addedVelocity;
        zspellConductorRod.velocity.x = Mathd.Clamp(zspellConductorRod.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellConductorRod.velocity.y = Mathd.Clamp(zspellConductorRod.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellConductorRod.addedVelocity.x = (FixedInt) 0;
        zspellConductorRod.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellConductorRod.affectedByGravity && zspellConductorRod.velocity.y > -ZMap.MaxSpeed)
        zspellConductorRod.velocity.y += zspellConductorRod.map.Gravity;
      else if (!zspellConductorRod.affectedByGravity && zspellConductorRod.velocity.y > -10 && zspellConductorRod.maxDuration > 150)
        zspellConductorRod.affectedByGravity = true;
      zspellConductorRod.Wind();
label_29:
      if (zspellConductorRod.Rotates && (Object) zspellConductorRod.transform != (Object) null)
        zspellConductorRod.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellConductorRod.velocity.y.ToFloat(), zspellConductorRod.velocity.x.ToFloat()) * 57.29578f);
      ++zspellConductorRod.curDuration;
      zspellConductorRod.Undie();
      if (zspellConductorRod.timesBounced >= 1)
      {
        if (zspellConductorRod.spellEnum == SpellEnum.Conductor_Rod)
        {
          zspellConductorRod.transform?.GetChild(1).gameObject.SetActive(true);
          int max = zspellConductorRod.parent.familiar.Has(FamiliarType.Storm) ? (1 + zspellConductorRod.parent.familiarLevelStorm) / 2 + 5 : 5;
          int num = 0;
          int amount = Mathf.Clamp(((int) FixedInt.Abs(zspellConductorRod.position.x - zspellConductorRod.target.x) + num) / 52, 3, max);
          zspellConductorRod.game.ongoing.RunSpell(ZSpell.IEnumeratorLightningStrike(zspellConductorRod.parent, new MyLocation(zspellConductorRod.position.x, (FixedInt) zspellConductorRod.map.Height), -30, 30, amount, true, (int) zspellConductorRod.position.x, (int) zspellConductorRod.position.y, zspellConductorRod.hitCreature), true);
        }
        else if (zspellConductorRod.spellEnum == SpellEnum.Collision_Course)
          ZSpell.BaseFire(Inert.GetSpell(SpellEnum.Starfire), zspellConductorRod.parent, new MyLocation(zspellConductorRod.position.x, (FixedInt) (zspellConductorRod.parent.game.map.Height + 1000)), Quaternion.identity, new MyLocation(0, -40), true, false);
        if (zspellConductorRod.game.AllowExpansion && (ZComponent) zspellConductorRod.parent != (object) null || zspellConductorRod.spellEnum == SpellEnum.Collision_Course)
        {
          ZEffector effector = zspellConductorRod.effector;
          effector.game = zspellConductorRod.parent.game;
          effector.whoSummoned = zspellConductorRod.parent;
          effector.followParent = false;
          effector.position = zspellConductorRod.position;
          effector.active = false;
          effector.rotation = zspellConductorRod.GetRotation;
          zspellConductorRod.parent.effectors.Add(effector);
          zspellConductorRod.game.forceRysncPause = true;
          if (zspellConductorRod.spellEnum == SpellEnum.Electrostatic_Charge)
          {
            if (zspellConductorRod.game.isClient)
              zspellConductorRod.transform?.GetChild(0).gameObject.SetActive(true);
            zspellConductorRod.game.staticCharge.Add(effector);
            effector.active = true;
            effector.collider.effector = effector;
            effector.collider.world = effector.world;
            effector.collider.Move(zspellConductorRod.position);
            effector.CheckInitialSpawn_Creatures(effector.collider.radius);
            break;
          }
          zspellConductorRod.parent = zspellConductorRod.hitCreature;
          if (!((ZComponent) zspellConductorRod.hitCreature != (object) null))
            break;
          Transform transform = zspellConductorRod.transform;
          if (transform == null)
            break;
          transform.SetParent(zspellConductorRod.hitCreature.transform);
          break;
        }
        zspellConductorRod.DestroyConductorRodDelay();
        break;
      }
      if (zspellConductorRod.curDuration >= zspellConductorRod.maxDuration)
      {
        zspellConductorRod.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }

  protected void DestroyConductorRodDelay()
  {
    this.isDead = true;
    this.isNull = true;
    ZComponent.Destroy<GameObject>(this.gameObject, 2f);
    if (this.game.isClient)
    {
      ParticleSystem[] componentsInChildren = this.gameObject?.GetComponentsInChildren<ParticleSystem>();
      if (componentsInChildren != null)
      {
        foreach (ParticleSystem particleSystem in componentsInChildren)
          particleSystem.Stop(true, ParticleSystemStopBehavior.StopEmitting);
      }
    }
    this.effector.isNull = true;
  }
}
