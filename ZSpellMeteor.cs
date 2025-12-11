
using System.Collections.Generic;
using UnityEngine;

public class ZSpellMeteor : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellMeteor zspellMeteor = this;
    zspellMeteor.isMoving = true;
    zspellMeteor.zb = MapGenerator.getOutlineArray(zspellMeteor.radius);
    MyLocation velocity = zspellMeteor.velocity;
    if (gotoStatic)
      yield return 0.0f;
label_43:
    while (!zspellMeteor.isDead)
    {
      zspellMeteor.pX = zspellMeteor.position.x;
      zspellMeteor.pY = zspellMeteor.position.y;
      FixedInt fixedInt1 = zspellMeteor.position.x + zspellMeteor.velocity.x;
      FixedInt fixedInt2 = zspellMeteor.position.y + zspellMeteor.velocity.y;
      zspellMeteor.validX = zspellMeteor.pX;
      zspellMeteor.validY = zspellMeteor.pY;
      zspellMeteor.steps = 1;
      FixedInt x1 = zspellMeteor.velocity.x;
      FixedInt y1 = zspellMeteor.velocity.y;
      FixedInt fixedInt3 = zspellMeteor.velocity.x;
      FixedInt fixedInt4 = zspellMeteor.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellMeteor.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellMeteor.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellMeteor.velocity.x / zspellMeteor.steps;
        fixedInt4 = zspellMeteor.velocity.y / zspellMeteor.steps;
      }
      bool flag1 = false;
      bool flag2 = false;
      while (zspellMeteor.steps > 0)
      {
        if (zspellMeteor.map.SpellCheckEffectors(zspellMeteor.toCollideCheck, (ZSpell) zspellMeteor, (int) zspellMeteor.validX, (int) zspellMeteor.validY))
        {
          zspellMeteor.position = new MyLocation(zspellMeteor.validX, zspellMeteor.validY);
          yield return 0.0f;
          goto label_43;
        }
        else
        {
          --zspellMeteor.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellMeteor.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellMeteor.zb.Count) - zspellMeteor.radius;
          if (num1 < 0)
            num1 += zspellMeteor.zb.Count;
          for (int index1 = 0; index1 < zspellMeteor.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellMeteor.zb.Count;
            if (!zspellMeteor.map.SpellCheckPosition((int) (fixedInt3 + zspellMeteor.pX) + zspellMeteor.zb[index2].x, (int) (fixedInt4 + zspellMeteor.pY) + zspellMeteor.zb[index2].y, zspellMeteor.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellMeteor.pX);
              int num3 = (int) (fixedInt4 + zspellMeteor.pY);
              if (!flag1 || !zspellMeteor.map.CheckPositionOnlyMap(num2 + zspellMeteor.zb[index2].x, num3 + zspellMeteor.zb[index2].y))
              {
                int x2 = num2 + zspellMeteor.zb[index2].x;
                int y2 = num3 + zspellMeteor.zb[index2].y;
                ++zspellMeteor.timesBounced;
                zspellMeteor.map.ServerBitBlt((int) zspellMeteor.explosionCutout, (int) zspellMeteor.validX, (int) zspellMeteor.validY, true, true);
                zspellMeteor.OnExplosion();
                zspellMeteor.MoveSurroundings(zspellMeteor.EXORADIUS + 5);
                zspellMeteor.ApplyExplosionForce(zspellMeteor.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                if ((Object) zspellMeteor.toSummon != (Object) null && zspellMeteor.spellEnum != SpellEnum.Arcane_Meteor)
                {
                  Spell component = zspellMeteor.toSummon.GetComponent<Spell>();
                  for (int index3 = 0; index3 < 4; ++index3)
                  {
                    MyLocation power = Inert.Velocity(zspellMeteor.game.RandomFixedInt(0, 360), 15);
                    ZSpell.BaseFire(component, zspellMeteor.parent, zspellMeteor.position, Quaternion.identity, power, true, false, true);
                  }
                }
                if (zspellMeteor.spellEnum == SpellEnum.Fire_Cannon)
                {
                  ZCreature zcreature = zspellMeteor.map.PhysicsCollideCreature((ZCreature) null, x2, y2, 0);
                  if ((ZComponent) zcreature != (object) null && (ZComponent) zcreature.tower != (object) null)
                    flag2 = true;
                }
                AudioManager.Play(zspellMeteor.explosionClip);
              }
              flag1 = true;
            }
          }
          zspellMeteor.validX = zspellMeteor.pX;
          zspellMeteor.validY = zspellMeteor.pY;
          zspellMeteor.pX = zspellMeteor.pX + fixedInt3;
          zspellMeteor.pY = zspellMeteor.pY + fixedInt4;
        }
      }
      if (flag2)
        zspellMeteor.position = zspellMeteor.position + zspellMeteor.velocity * 419430L;
      else
        zspellMeteor.position = zspellMeteor.position + zspellMeteor.velocity;
      if (zspellMeteor.position.y < zspellMeteor.radius)
      {
        zspellMeteor.moving = (IEnumerator<float>) null;
        zspellMeteor.velocity = MyLocation.zero;
        zspellMeteor.isMoving = false;
        zspellMeteor.Splash();
        zspellMeteor.DestroyDelay();
        break;
      }
      if (zspellMeteor.addVelocity)
      {
        zspellMeteor.addVelocity = false;
        zspellMeteor.velocity = zspellMeteor.velocity + zspellMeteor.addedVelocity;
        zspellMeteor.velocity.x = Mathd.Clamp(zspellMeteor.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellMeteor.velocity.y = Mathd.Clamp(zspellMeteor.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellMeteor.ResetAddedVelocity();
      }
      else if (zspellMeteor.affectedByGravity && zspellMeteor.velocity.y > -ZMap.MaxSpeed)
        zspellMeteor.velocity.y += zspellMeteor.map.Gravity;
      else if (!zspellMeteor.affectedByGravity && zspellMeteor.velocity.y > -10 && zspellMeteor.maxDuration > 150)
        zspellMeteor.affectedByGravity = true;
      zspellMeteor.Wind();
      ++zspellMeteor.curDuration;
      zspellMeteor.Undie();
      if (zspellMeteor.curDuration >= zspellMeteor.maxDuration || zspellMeteor.timesBounced >= zspellMeteor.amount)
      {
        zspellMeteor.Explode();
        zspellMeteor.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
