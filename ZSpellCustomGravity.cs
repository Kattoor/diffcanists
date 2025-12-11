
using System.Collections.Generic;
using UnityEngine;

public class ZSpellCustomGravity : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellCustomGravity zspellCustomGravity = this;
    zspellCustomGravity.isMoving = true;
    zspellCustomGravity.zb = MapGenerator.getOutlineArray(zspellCustomGravity.radius);
    if (gotoStatic)
      yield return 0.0f;
label_45:
    while (!zspellCustomGravity.isDead)
    {
      zspellCustomGravity.pX = zspellCustomGravity.position.x;
      zspellCustomGravity.pY = zspellCustomGravity.position.y;
      FixedInt fixedInt1 = zspellCustomGravity.position.x + zspellCustomGravity.velocity.x;
      FixedInt fixedInt2 = zspellCustomGravity.position.y + zspellCustomGravity.velocity.y;
      zspellCustomGravity.validX = zspellCustomGravity.pX;
      zspellCustomGravity.validY = zspellCustomGravity.pY;
      zspellCustomGravity.steps = 1;
      FixedInt x = zspellCustomGravity.velocity.x;
      FixedInt y = zspellCustomGravity.velocity.y;
      FixedInt fixedInt3 = zspellCustomGravity.velocity.x;
      FixedInt fixedInt4 = zspellCustomGravity.velocity.y;
      if (x > 1 || x < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x) > FixedInt.Abs(y))
          zspellCustomGravity.steps = (int) FixedInt.Abs(x) + 1;
        else
          zspellCustomGravity.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellCustomGravity.velocity.x / zspellCustomGravity.steps;
        fixedInt4 = zspellCustomGravity.velocity.y / zspellCustomGravity.steps;
      }
      while (zspellCustomGravity.steps > 0)
      {
        if (zspellCustomGravity.map.SpellCheckEffectors(zspellCustomGravity.toCollideCheck, (ZSpell) zspellCustomGravity, (int) zspellCustomGravity.validX, (int) zspellCustomGravity.validY))
        {
          zspellCustomGravity.position = new MyLocation(zspellCustomGravity.validX, zspellCustomGravity.validY);
          yield return 0.0f;
          goto label_45;
        }
        else
        {
          --zspellCustomGravity.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellCustomGravity.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellCustomGravity.zb.Count) - zspellCustomGravity.radius;
          if (num1 < 0)
            num1 += zspellCustomGravity.zb.Count;
          for (int index1 = 0; index1 < zspellCustomGravity.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellCustomGravity.zb.Count;
            if (!zspellCustomGravity.map.SpellCheckPosition((int) (fixedInt3 + zspellCustomGravity.pX) + zspellCustomGravity.zb[index2].x, (int) (fixedInt4 + zspellCustomGravity.pY) + zspellCustomGravity.zb[index2].y, zspellCustomGravity.toCollideCheck, Inert.mask_spell_movement))
            {
              int xInt = (int) (fixedInt3 + zspellCustomGravity.pX);
              int num2 = (int) (fixedInt4 + zspellCustomGravity.pY);
              if (!zspellCustomGravity.explodeOnImpact)
              {
                zspellCustomGravity.position = new MyLocation(zspellCustomGravity.validX, zspellCustomGravity.validY);
                MyLocation zero = MyLocation.zero;
                int num3 = xInt + zspellCustomGravity.zb[index2].x;
                int num4 = num2 + zspellCustomGravity.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellCustomGravity.map.SpellCheckPosition(num3 + index3, num4 + index4, zspellCustomGravity.toCollideCheck, Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                zero.Normalize();
                MyLocation.Reflect(zspellCustomGravity.velocity, ref zero, out zspellCustomGravity.velocity);
                zspellCustomGravity.velocity = zspellCustomGravity.velocity * zspellCustomGravity.elasticity;
                if (MyLocation.Distance(MyLocation.zero, zspellCustomGravity.velocity) <= 1 && !zspellCustomGravity.ShouldSpellFall(false))
                {
                  while (zspellCustomGravity.curDuration < zspellCustomGravity.maxDuration)
                  {
                    ++zspellCustomGravity.curDuration;
                    yield return 0.0f;
                    if (zspellCustomGravity.ShouldSpellFall(false))
                      goto label_42;
                  }
                  zspellCustomGravity.Explode();
                  zspellCustomGravity.ApplyExplosionForce(zspellCustomGravity.position + zspellCustomGravity.addedDeathVector, 0, true, (ISpellBridge) null, (ZCreature) null);
                  zspellCustomGravity.DestroyDelay();
                  yield break;
                }
                else
                  goto label_42;
              }
              else
              {
                zspellCustomGravity.velocity.y = (FixedInt) 0;
                zspellCustomGravity.velocity.x = (FixedInt) 0;
                zspellCustomGravity.addedDeathVector = Inert.Velocity(Inert.AngleOfVelocity(zspellCustomGravity.velocity), zspellCustomGravity.radius);
                zspellCustomGravity.position = new MyLocation(xInt, num2 + zspellCustomGravity.zb[index2].y);
                zspellCustomGravity.moving = (IEnumerator<float>) null;
                zspellCustomGravity.isMoving = false;
                zspellCustomGravity.OnDeath(true);
                yield break;
              }
            }
          }
          zspellCustomGravity.validX = zspellCustomGravity.pX;
          zspellCustomGravity.validY = zspellCustomGravity.pY;
          zspellCustomGravity.pX = zspellCustomGravity.pX + fixedInt3;
          zspellCustomGravity.pY = zspellCustomGravity.pY + fixedInt4;
        }
      }
      zspellCustomGravity.position = zspellCustomGravity.position + zspellCustomGravity.velocity;
      if (zspellCustomGravity.position.y < zspellCustomGravity.radius)
      {
        zspellCustomGravity.moving = (IEnumerator<float>) null;
        zspellCustomGravity.velocity = MyLocation.zero;
        zspellCustomGravity.isMoving = false;
        zspellCustomGravity.Splash();
        zspellCustomGravity.DestroyDelay();
        break;
      }
      if (zspellCustomGravity.addVelocity)
      {
        zspellCustomGravity.addVelocity = false;
        zspellCustomGravity.velocity = zspellCustomGravity.velocity + zspellCustomGravity.addedVelocity;
        zspellCustomGravity.velocity.x = Mathd.Clamp(zspellCustomGravity.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellCustomGravity.velocity.y = Mathd.Clamp(zspellCustomGravity.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellCustomGravity.addedVelocity.x = (FixedInt) 0;
        zspellCustomGravity.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellCustomGravity.affectedByGravity && zspellCustomGravity.velocity.y > -ZMap.MaxSpeed)
        zspellCustomGravity.velocity.y += zspellCustomGravity.CustomGravity;
      else if (!zspellCustomGravity.affectedByGravity && zspellCustomGravity.velocity.y > -10 && zspellCustomGravity.maxDuration > 150)
        zspellCustomGravity.affectedByGravity = true;
      if (zspellCustomGravity.Rotates)
        zspellCustomGravity.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellCustomGravity.velocity.y.ToFloat(), zspellCustomGravity.velocity.x.ToFloat()) * 57.29578f);
label_42:
      ++zspellCustomGravity.curDuration;
      if (zspellCustomGravity.curDuration >= zspellCustomGravity.maxDuration)
      {
        zspellCustomGravity.Explode();
        zspellCustomGravity.ApplyExplosionForce(zspellCustomGravity.position + zspellCustomGravity.addedDeathVector, 0, true, (ISpellBridge) null, (ZCreature) null);
        zspellCustomGravity.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
