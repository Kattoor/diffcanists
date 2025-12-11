
using System.Collections.Generic;
using UnityEngine;

public class ZSpellMechanicalArrow : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellMechanicalArrow zspellMechanicalArrow = this;
    if ((ZComponent) zspellMechanicalArrow.parent != (object) null && zspellMechanicalArrow.parent.parent.localTurn == 0)
      zspellMechanicalArrow.maxDuration = 900;
    zspellMechanicalArrow.isMoving = true;
    zspellMechanicalArrow.zb = MapGenerator.getOutlineArray(zspellMechanicalArrow.radius);
    if (gotoStatic)
      yield return 0.0f;
label_46:
    while (!zspellMechanicalArrow.isDead)
    {
      zspellMechanicalArrow.pX = zspellMechanicalArrow.position.x;
      zspellMechanicalArrow.pY = zspellMechanicalArrow.position.y;
      FixedInt fixedInt1 = zspellMechanicalArrow.position.x + zspellMechanicalArrow.velocity.x;
      FixedInt fixedInt2 = zspellMechanicalArrow.position.y + zspellMechanicalArrow.velocity.y;
      zspellMechanicalArrow.validX = zspellMechanicalArrow.pX;
      zspellMechanicalArrow.validY = zspellMechanicalArrow.pY;
      zspellMechanicalArrow.steps = 1;
      FixedInt x = zspellMechanicalArrow.velocity.x;
      FixedInt y = zspellMechanicalArrow.velocity.y;
      FixedInt fixedInt3 = zspellMechanicalArrow.velocity.x;
      FixedInt fixedInt4 = zspellMechanicalArrow.velocity.y;
      if (x > 1 || x < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x) > FixedInt.Abs(y))
          zspellMechanicalArrow.steps = (int) FixedInt.Abs(x) + 1;
        else
          zspellMechanicalArrow.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellMechanicalArrow.velocity.x / zspellMechanicalArrow.steps;
        fixedInt4 = zspellMechanicalArrow.velocity.y / zspellMechanicalArrow.steps;
      }
      while (zspellMechanicalArrow.steps > 0)
      {
        if (zspellMechanicalArrow.map.SpellCheckEffectors(zspellMechanicalArrow.toCollideCheck, (ZSpell) zspellMechanicalArrow, (int) zspellMechanicalArrow.validX, (int) zspellMechanicalArrow.validY))
        {
          zspellMechanicalArrow.position = new MyLocation(zspellMechanicalArrow.validX, zspellMechanicalArrow.validY);
          yield return 0.0f;
          goto label_46;
        }
        else
        {
          --zspellMechanicalArrow.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellMechanicalArrow.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellMechanicalArrow.zb.Count) - zspellMechanicalArrow.radius;
          if (num1 < 0)
            num1 += zspellMechanicalArrow.zb.Count;
          for (int index1 = 0; index1 < zspellMechanicalArrow.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellMechanicalArrow.zb.Count;
            if (!zspellMechanicalArrow.map.SpellCheckPosition((int) (fixedInt3 + zspellMechanicalArrow.pX) + zspellMechanicalArrow.zb[index2].x, (int) (fixedInt4 + zspellMechanicalArrow.pY) + zspellMechanicalArrow.zb[index2].y, zspellMechanicalArrow.toCollideCheck, Inert.mask_spell_movement))
            {
              int xInt = (int) (fixedInt3 + zspellMechanicalArrow.pX);
              int num2 = (int) (fixedInt4 + zspellMechanicalArrow.pY);
              zspellMechanicalArrow.position = new MyLocation(xInt, num2 + zspellMechanicalArrow.zb[index2].y);
              zspellMechanicalArrow.moving = (IEnumerator<float>) null;
              zspellMechanicalArrow.isMoving = false;
              if (zspellMechanicalArrow.spellEnum == SpellEnum.Mechanical_Arrow && zspellMechanicalArrow.curDuration > 120)
                zspellMechanicalArrow.damage -= zspellMechanicalArrow.curDuration - 120;
              zspellMechanicalArrow.OnDeath(true);
              zspellMechanicalArrow.velocity.y = (FixedInt) 0;
              zspellMechanicalArrow.velocity.x = (FixedInt) 0;
              yield break;
            }
          }
          zspellMechanicalArrow.validX = zspellMechanicalArrow.pX;
          zspellMechanicalArrow.validY = zspellMechanicalArrow.pY;
          zspellMechanicalArrow.pX = zspellMechanicalArrow.pX + fixedInt3;
          zspellMechanicalArrow.pY = zspellMechanicalArrow.pY + fixedInt4;
        }
      }
      zspellMechanicalArrow.position = zspellMechanicalArrow.position + zspellMechanicalArrow.velocity;
      if (zspellMechanicalArrow.position.y < zspellMechanicalArrow.radius)
      {
        zspellMechanicalArrow.moving = (IEnumerator<float>) null;
        zspellMechanicalArrow.isMoving = false;
        if (zspellMechanicalArrow.spellEnum == SpellEnum.Water_Ball)
        {
          zspellMechanicalArrow.position = new MyLocation(zspellMechanicalArrow.position.x, (FixedInt) zspellMechanicalArrow.radius);
          zspellMechanicalArrow.velocity.y = -zspellMechanicalArrow.velocity.y;
          zspellMechanicalArrow.OnDeath(true);
          break;
        }
        zspellMechanicalArrow.velocity = MyLocation.zero;
        zspellMechanicalArrow.Splash();
        zspellMechanicalArrow.DestroyDelay();
        break;
      }
      if (zspellMechanicalArrow.addVelocity)
      {
        zspellMechanicalArrow.addVelocity = false;
        zspellMechanicalArrow.velocity = zspellMechanicalArrow.velocity + zspellMechanicalArrow.addedVelocity;
        zspellMechanicalArrow.velocity.x = Mathd.Clamp(zspellMechanicalArrow.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellMechanicalArrow.velocity.y = Mathd.Clamp(zspellMechanicalArrow.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellMechanicalArrow.addedVelocity.x = (FixedInt) 0;
        zspellMechanicalArrow.addedVelocity.y = (FixedInt) 0;
      }
      if (zspellMechanicalArrow.goToTarget)
      {
        if (zspellMechanicalArrow.curDuration >= zspellMechanicalArrow.maxTargetFrames)
          zspellMechanicalArrow.goToTarget = false;
        else
          zspellMechanicalArrow.RotateToward();
      }
      else if (zspellMechanicalArrow.affectedByGravity && zspellMechanicalArrow.velocity.y > -ZMap.MaxSpeed)
        zspellMechanicalArrow.velocity.y += zspellMechanicalArrow.map.Gravity;
      else if (!zspellMechanicalArrow.affectedByGravity && zspellMechanicalArrow.velocity.y > -10 && zspellMechanicalArrow.maxDuration > 150)
        zspellMechanicalArrow.affectedByGravity = true;
      zspellMechanicalArrow.Wind();
      if (zspellMechanicalArrow.Rotates && (Object) zspellMechanicalArrow.transform != (Object) null)
        zspellMechanicalArrow.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellMechanicalArrow.velocity.y.ToFloat(), zspellMechanicalArrow.velocity.x.ToFloat()) * 57.29578f);
      ++zspellMechanicalArrow.curDuration;
      if (zspellMechanicalArrow.curDuration >= zspellMechanicalArrow.maxDuration)
      {
        if (zspellMechanicalArrow.game.isClient)
          AudioManager.Play(AudioManager.instance.mechArrowExplode);
        zspellMechanicalArrow.OnExplosionMechanicalArrow();
        zspellMechanicalArrow.DestroyDelay();
        break;
      }
      if (zspellMechanicalArrow.curDuration % 30 == 0)
        ZSpell.BaseFire(zspellMechanicalArrow.toSummon.GetComponent<Spell>(), zspellMechanicalArrow.parent, zspellMechanicalArrow.position, Quaternion.identity, new MyLocation(0, -5), true, false, true);
      yield return 0.0f;
    }
  }
}
