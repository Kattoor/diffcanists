
using System.Collections.Generic;
using UnityEngine;

public class ZSpellArrow : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellArrow zspellArrow = this;
    zspellArrow.isMoving = true;
    zspellArrow.zb = MapGenerator.getOutlineArray(zspellArrow.radius);
    if (gotoStatic)
      yield return 0.0f;
label_44:
    while (!zspellArrow.isDead)
    {
      zspellArrow.pX = zspellArrow.position.x;
      zspellArrow.pY = zspellArrow.position.y;
      FixedInt fixedInt1 = zspellArrow.position.x + zspellArrow.velocity.x;
      FixedInt fixedInt2 = zspellArrow.position.y + zspellArrow.velocity.y;
      zspellArrow.validX = zspellArrow.pX;
      zspellArrow.validY = zspellArrow.pY;
      zspellArrow.steps = 1;
      FixedInt x1 = zspellArrow.velocity.x;
      FixedInt y = zspellArrow.velocity.y;
      FixedInt fixedInt3 = zspellArrow.velocity.x;
      FixedInt fixedInt4 = zspellArrow.velocity.y;
      if (x1 > 1 || x1 < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y))
          zspellArrow.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellArrow.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellArrow.velocity.x / zspellArrow.steps;
        fixedInt4 = zspellArrow.velocity.y / zspellArrow.steps;
      }
      while (zspellArrow.steps > 0)
      {
        if (zspellArrow.map.SpellCheckEffectors(zspellArrow.toCollideCheck, (ZSpell) zspellArrow, (int) zspellArrow.validX, (int) zspellArrow.validY))
        {
          zspellArrow.position = new MyLocation(zspellArrow.validX, zspellArrow.validY);
          yield return 0.0f;
          goto label_44;
        }
        else
        {
          --zspellArrow.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellArrow.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellArrow.zb.Count) - zspellArrow.radius;
          if (num1 < 0)
            num1 += zspellArrow.zb.Count;
          for (int index1 = 0; index1 < zspellArrow.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellArrow.zb.Count;
            if (!zspellArrow.map.SpellCheckPosition((int) (fixedInt3 + zspellArrow.pX) + zspellArrow.zb[index2].x, (int) (fixedInt4 + zspellArrow.pY) + zspellArrow.zb[index2].y, zspellArrow.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellArrow.pX);
              int num3 = (int) (fixedInt4 + zspellArrow.pY);
              AudioManager.Play(zspellArrow.explosionClip);
              int x2 = zspellArrow.zb[index2].x;
              int num4 = num2 + x2;
              int num5 = num3 + zspellArrow.zb[index2].y;
              if (!zspellArrow.map.CheckPositionOnlyMap(num4, num5))
              {
                zspellArrow.velocity.y = (FixedInt) 0;
                zspellArrow.velocity.x = (FixedInt) 0;
                zspellArrow.moving = (IEnumerator<float>) null;
                zspellArrow.isMoving = false;
                zspellArrow.map.ServerBitBlt((int) zspellArrow.explosionCutout, num4, num5, true, true);
                zspellArrow.damage = 0;
                zspellArrow.ApplyExplosionForce(new MyLocation(num4, num5), 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellArrow.isDead = true;
                zspellArrow.isNull = true;
                if (zspellArrow.game.isClient && !zspellArrow.game.resyncing)
                  ZComponent.Instantiate<GameObject>(zspellArrow.explosion, new Vector3((float) num4, (float) num5), Quaternion.identity, zspellArrow.game.GetMapTransform());
                ZComponent.Destroy<GameObject>(zspellArrow.gameObject);
                yield break;
              }
              else if ((ZComponent) zspellArrow.map.PhysicsCollideCreature(zspellArrow.toCollideCheck, num4, num5, 0) != (object) null)
              {
                zspellArrow.velocity.y = (FixedInt) 0;
                zspellArrow.velocity.x = (FixedInt) 0;
                zspellArrow.position = new MyLocation(zspellArrow.validX, zspellArrow.validY);
                zspellArrow.moving = (IEnumerator<float>) null;
                zspellArrow.isMoving = false;
                zspellArrow.map.ServerBitBlt((int) zspellArrow.explosionCutout, num4, num5, true, true);
                if (zspellArrow.curDuration < 3)
                  zspellArrow.damageType = DamageType.Wallop;
                zspellArrow.ApplyExplosionForce(new MyLocation(num4, num5), 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellArrow.isDead = true;
                zspellArrow.isNull = true;
                if (zspellArrow.game.isClient && !zspellArrow.game.resyncing)
                  ZComponent.Instantiate<GameObject>(zspellArrow.explosion, new Vector3((float) num4, (float) num5), Quaternion.identity, zspellArrow.game.GetMapTransform());
                ZComponent.Destroy<GameObject>(zspellArrow.gameObject);
                yield break;
              }
              else
              {
                zspellArrow.velocity.y = (FixedInt) 0;
                zspellArrow.velocity.x = (FixedInt) 0;
                zspellArrow.moving = (IEnumerator<float>) null;
                zspellArrow.isMoving = false;
                zspellArrow.map.ServerBitBlt((int) zspellArrow.explosionCutout, num4, num5, true, true);
                zspellArrow.damage = 0;
                zspellArrow.ApplyExplosionForce(new MyLocation(num4, num5), 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellArrow.isDead = true;
                zspellArrow.isNull = true;
                if (zspellArrow.game.isClient && !zspellArrow.game.resyncing)
                  ZComponent.Instantiate<GameObject>(zspellArrow.explosion, new Vector3((float) num4, (float) num5), Quaternion.identity, zspellArrow.game.GetMapTransform());
                ZComponent.Destroy<GameObject>(zspellArrow.gameObject);
                yield break;
              }
            }
          }
          zspellArrow.validX = zspellArrow.pX;
          zspellArrow.validY = zspellArrow.pY;
          zspellArrow.pX = zspellArrow.pX + fixedInt3;
          zspellArrow.pY = zspellArrow.pY + fixedInt4;
        }
      }
      zspellArrow.position = zspellArrow.position + zspellArrow.velocity;
      if (zspellArrow.position.y < zspellArrow.radius)
      {
        zspellArrow.moving = (IEnumerator<float>) null;
        zspellArrow.velocity = MyLocation.zero;
        zspellArrow.isMoving = false;
        zspellArrow.Splash();
        zspellArrow.DestroyDelay();
        break;
      }
      if (zspellArrow.addVelocity)
      {
        zspellArrow.addVelocity = false;
        zspellArrow.velocity = zspellArrow.velocity + zspellArrow.addedVelocity;
        zspellArrow.velocity.x = Mathd.Clamp(zspellArrow.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellArrow.velocity.y = Mathd.Clamp(zspellArrow.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellArrow.addedVelocity.x = (FixedInt) 0;
        zspellArrow.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellArrow.affectedByGravity && zspellArrow.velocity.y > -ZMap.MaxSpeed)
        zspellArrow.velocity.y += zspellArrow.map.Gravity;
      else if (!zspellArrow.affectedByGravity && zspellArrow.velocity.y > -10 && zspellArrow.maxDuration > 150)
        zspellArrow.affectedByGravity = true;
      zspellArrow.Wind();
      if (zspellArrow.Rotates && (Object) zspellArrow.transform != (Object) null)
        zspellArrow.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellArrow.velocity.y.ToFloat(), zspellArrow.velocity.x.ToFloat()) * 57.29578f);
      ++zspellArrow.curDuration;
      if (zspellArrow.curDuration >= zspellArrow.maxDuration)
      {
        zspellArrow.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
