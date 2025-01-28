
using System.Collections.Generic;
using UnityEngine;

public class ZSpellEntangle : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellEntangle zspellEntangle = this;
    zspellEntangle.isMoving = true;
    zspellEntangle.zb = MapGenerator.getOutlineArray(zspellEntangle.radius);
    if (gotoStatic)
      yield return 0.0f;
label_44:
    while (!zspellEntangle.isDead)
    {
      zspellEntangle.pX = zspellEntangle.position.x;
      zspellEntangle.pY = zspellEntangle.position.y;
      FixedInt fixedInt1 = zspellEntangle.position.x + zspellEntangle.velocity.x;
      FixedInt fixedInt2 = zspellEntangle.position.y + zspellEntangle.velocity.y;
      zspellEntangle.validX = zspellEntangle.pX;
      zspellEntangle.validY = zspellEntangle.pY;
      zspellEntangle.steps = 1;
      FixedInt x1 = zspellEntangle.velocity.x;
      FixedInt y = zspellEntangle.velocity.y;
      FixedInt fixedInt3 = zspellEntangle.velocity.x;
      FixedInt fixedInt4 = zspellEntangle.velocity.y;
      if (x1 > 1 || x1 < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y))
          zspellEntangle.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellEntangle.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellEntangle.velocity.x / zspellEntangle.steps;
        fixedInt4 = zspellEntangle.velocity.y / zspellEntangle.steps;
      }
      while (zspellEntangle.steps > 0)
      {
        if (zspellEntangle.map.SpellCheckEffectors(zspellEntangle.toCollideCheck, (ZSpell) zspellEntangle, (int) zspellEntangle.validX, (int) zspellEntangle.validY))
        {
          zspellEntangle.position = new MyLocation(zspellEntangle.validX, zspellEntangle.validY);
          yield return 0.0f;
          goto label_44;
        }
        else
        {
          --zspellEntangle.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellEntangle.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellEntangle.zb.Count) - zspellEntangle.radius;
          if (num1 < 0)
            num1 += zspellEntangle.zb.Count;
          for (int index1 = 0; index1 < zspellEntangle.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellEntangle.zb.Count;
            if (!zspellEntangle.map.SpellCheckPosition((int) (fixedInt3 + zspellEntangle.pX) + zspellEntangle.zb[index2].x, (int) (fixedInt4 + zspellEntangle.pY) + zspellEntangle.zb[index2].y, zspellEntangle.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellEntangle.pX);
              int num3 = (int) (fixedInt4 + zspellEntangle.pY);
              AudioManager.Play(zspellEntangle.explosionClip);
              int x2 = zspellEntangle.zb[index2].x;
              int num4 = num2 + x2;
              int num5 = num3 + zspellEntangle.zb[index2].y;
              if (!zspellEntangle.map.CheckPositionOnlyMap(num4, num5))
              {
                zspellEntangle.velocity.y = (FixedInt) 0;
                zspellEntangle.velocity.x = (FixedInt) 0;
                zspellEntangle.moving = (IEnumerator<float>) null;
                zspellEntangle.isMoving = false;
                zspellEntangle.map.ServerBitBlt((int) zspellEntangle.explosionCutout, num4, num5, true, true);
                zspellEntangle.ApplyExplosionForce(new MyLocation(num4, num5), 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellEntangle.isDead = true;
                zspellEntangle.isNull = true;
                if (zspellEntangle.game.isClient && !zspellEntangle.game.resyncing)
                  ZComponent.Instantiate<GameObject>(zspellEntangle.explosion, new Vector3((float) num4, (float) num5), Quaternion.identity, zspellEntangle.game.GetMapTransform());
                ZComponent.Destroy<GameObject>(zspellEntangle.gameObject);
                yield break;
              }
              else
              {
                ZCreature zcreature = zspellEntangle.map.PhysicsCollideCreature(zspellEntangle.toCollideCheck, num4, num5, Inert.mask_spell_movement);
                if ((ZComponent) zcreature != (object) null && (ZComponent) zcreature.mount != (object) null)
                  zcreature = zcreature.mount;
                if ((ZComponent) zcreature != (object) null && zcreature.race != CreatureRace.Effector && (!zcreature.entangled && !ZEffector.InSanctuary(zcreature.game.world, zcreature.position)))
                {
                  zcreature.entangledShield = zcreature.shield;
                  zcreature.entangled = true;
                  zspellEntangle.velocity.y = (FixedInt) 0;
                  zspellEntangle.velocity.x = (FixedInt) 0;
                  zspellEntangle.position = new MyLocation(zspellEntangle.validX, zspellEntangle.validY);
                  zspellEntangle.moving = (IEnumerator<float>) null;
                  zspellEntangle.isMoving = false;
                  zspellEntangle.map.ServerBitBlt((int) zspellEntangle.explosionCutout, num4, num5, true, true);
                  zspellEntangle.ApplyExplosionForce(new MyLocation(num4, num5), 0, true, (ISpellBridge) null, (ZCreature) null);
                  zspellEntangle.isDead = true;
                  zspellEntangle.isNull = true;
                  if (zspellEntangle.game.isClient && (Object) zcreature.transform != (Object) null)
                  {
                    ZComponent.Instantiate<GameObject>(zspellEntangle.explosion, new Vector3((float) num4, (float) num5), Quaternion.identity, zspellEntangle.game.GetMapTransform());
                    ZComponent.Instantiate<GameObject>(zspellEntangle.toSummon, zcreature.transform.position, Quaternion.identity, zcreature.transform).GetComponent<ParticleEntangle>().SetCreature(zcreature.clientObj, zspellEntangle.spellEnum != SpellEnum.Entangle_Kraken);
                  }
                  ZComponent.Destroy<GameObject>(zspellEntangle.gameObject);
                  yield break;
                }
                else
                {
                  zspellEntangle.velocity.y = (FixedInt) 0;
                  zspellEntangle.velocity.x = (FixedInt) 0;
                  zspellEntangle.moving = (IEnumerator<float>) null;
                  zspellEntangle.isMoving = false;
                  zspellEntangle.map.ServerBitBlt((int) zspellEntangle.explosionCutout, num4, num5, true, true);
                  zspellEntangle.ApplyExplosionForce(new MyLocation(num4, num5), 0, true, (ISpellBridge) null, (ZCreature) null);
                  zspellEntangle.isDead = true;
                  zspellEntangle.isNull = true;
                  if (zspellEntangle.game.isClient && !zspellEntangle.game.resyncing)
                    ZComponent.Instantiate<GameObject>(zspellEntangle.explosion, new Vector3((float) num4, (float) num5), Quaternion.identity, zspellEntangle.game.GetMapTransform());
                  ZComponent.Destroy<GameObject>(zspellEntangle.gameObject);
                  yield break;
                }
              }
            }
          }
          zspellEntangle.validX = zspellEntangle.pX;
          zspellEntangle.validY = zspellEntangle.pY;
          zspellEntangle.pX = zspellEntangle.pX + fixedInt3;
          zspellEntangle.pY = zspellEntangle.pY + fixedInt4;
        }
      }
      zspellEntangle.position = zspellEntangle.position + zspellEntangle.velocity;
      if (zspellEntangle.position.y < zspellEntangle.radius)
      {
        zspellEntangle.moving = (IEnumerator<float>) null;
        zspellEntangle.velocity = MyLocation.zero;
        zspellEntangle.isMoving = false;
        zspellEntangle.Splash();
        zspellEntangle.DestroyDelay();
        break;
      }
      if (zspellEntangle.addVelocity)
      {
        zspellEntangle.addVelocity = false;
        zspellEntangle.velocity = zspellEntangle.velocity + zspellEntangle.addedVelocity;
        zspellEntangle.velocity.x = Mathd.Clamp(zspellEntangle.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellEntangle.velocity.y = Mathd.Clamp(zspellEntangle.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellEntangle.addedVelocity.x = (FixedInt) 0;
        zspellEntangle.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellEntangle.affectedByGravity && zspellEntangle.velocity.y > -ZMap.MaxSpeed)
        zspellEntangle.velocity.y += zspellEntangle.map.Gravity;
      else if (!zspellEntangle.affectedByGravity && zspellEntangle.velocity.y > -10 && zspellEntangle.maxDuration > 150)
        zspellEntangle.affectedByGravity = true;
      zspellEntangle.Wind();
      ++zspellEntangle.curDuration;
      if (zspellEntangle.curDuration >= zspellEntangle.maxDuration)
      {
        zspellEntangle.DestroyDelay();
        break;
      }
      if (zspellEntangle.game.isClient && zspellEntangle.Rotates && (Object) zspellEntangle.transform != (Object) null)
        zspellEntangle.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellEntangle.velocity.y.ToFloat(), zspellEntangle.velocity.x.ToFloat()) * 57.29578f);
      yield return 0.0f;
    }
  }
}
