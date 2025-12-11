
using System.Collections.Generic;
using UnityEngine;

public class ZSpellWaterDrop : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellWaterDrop zspellWaterDrop = this;
    zspellWaterDrop.isMoving = true;
    zspellWaterDrop.zb = MapGenerator.getOutlineArray(zspellWaterDrop.radius);
    if (!gotoStatic)
      zspellWaterDrop.curDestroyTerrainBounces = zspellWaterDrop.destroyTerrainBounces;
    if (zspellWaterDrop.spellEnum == SpellEnum.Starfire_Shard && (ZComponent) zspellWaterDrop.parent != (object) null && (zspellWaterDrop.parent.familiarLevelCosmos > 0 && !gotoStatic))
    {
      if (zspellWaterDrop.parent.familiarLevelCosmos == 1)
        zspellWaterDrop.explosionCutout = ExplosionCutout.Forty_Five;
      else if (zspellWaterDrop.parent.familiarLevelCosmos == 2)
        zspellWaterDrop.explosionCutout = ExplosionCutout.Fifty;
      else if (zspellWaterDrop.parent.familiarLevelCosmos == 3)
        zspellWaterDrop.explosionCutout = ExplosionCutout.Sixty;
      else if (zspellWaterDrop.parent.familiarLevelCosmos == 4)
        zspellWaterDrop.explosionCutout = ExplosionCutout.Sixty;
      else
        zspellWaterDrop.explosionCutout = ExplosionCutout.Seventy_Five;
    }
    if (gotoStatic)
      yield return 0.0f;
label_69:
    while (!zspellWaterDrop.isDead)
    {
      zspellWaterDrop.pX = zspellWaterDrop.position.x;
      zspellWaterDrop.pY = zspellWaterDrop.position.y;
      FixedInt fixedInt1 = zspellWaterDrop.position.x + zspellWaterDrop.velocity.x;
      FixedInt fixedInt2 = zspellWaterDrop.position.y + zspellWaterDrop.velocity.y;
      zspellWaterDrop.validX = zspellWaterDrop.pX;
      zspellWaterDrop.validY = zspellWaterDrop.pY;
      zspellWaterDrop.steps = 1;
      FixedInt x1 = zspellWaterDrop.velocity.x;
      FixedInt y1 = zspellWaterDrop.velocity.y;
      FixedInt fixedInt3 = zspellWaterDrop.velocity.x;
      FixedInt fixedInt4 = zspellWaterDrop.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellWaterDrop.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellWaterDrop.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellWaterDrop.velocity.x / zspellWaterDrop.steps;
        fixedInt4 = zspellWaterDrop.velocity.y / zspellWaterDrop.steps;
      }
      while (zspellWaterDrop.steps > 0)
      {
        if (zspellWaterDrop.map.SpellCheckEffectors(zspellWaterDrop.toCollideCheck, (ZSpell) zspellWaterDrop, (int) zspellWaterDrop.validX, (int) zspellWaterDrop.validY))
        {
          zspellWaterDrop.position = new MyLocation(zspellWaterDrop.validX, zspellWaterDrop.validY);
          yield return 0.0f;
          goto label_69;
        }
        else
        {
          --zspellWaterDrop.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellWaterDrop.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellWaterDrop.zb.Count) - zspellWaterDrop.radius;
          if (num1 < 0)
            num1 += zspellWaterDrop.zb.Count;
          for (int index1 = 0; index1 < zspellWaterDrop.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellWaterDrop.zb.Count;
            int num2 = (int) (fixedInt3 + zspellWaterDrop.pX);
            int num3 = (int) (fixedInt4 + zspellWaterDrop.pY);
            if ((zspellWaterDrop.curDuration < 3 ? (!zspellWaterDrop.map.CheckPositionOnlyMap(num2 + zspellWaterDrop.zb[index2].x, num3 + zspellWaterDrop.zb[index2].y) ? 1 : 0) : (!zspellWaterDrop.map.SpellCheckPosition(num2 + zspellWaterDrop.zb[index2].x, num3 + zspellWaterDrop.zb[index2].y, zspellWaterDrop.toCollideCheck, Inert.mask_spell_movement) ? 1 : 0)) != 0)
            {
              int x2 = num2 + zspellWaterDrop.zb[index2].x;
              int y2 = num3 + zspellWaterDrop.zb[index2].y;
              if (zspellWaterDrop.spellEnum == SpellEnum.Firecrackers || !zspellWaterDrop.map.CheckPositionOnlyMap(x2, y2))
              {
                if (zspellWaterDrop.timesBounced < zspellWaterDrop.Bounces)
                {
                  ++zspellWaterDrop.timesBounced;
                  zspellWaterDrop.position = new MyLocation(zspellWaterDrop.validX, zspellWaterDrop.validY);
                  MyLocation zero = MyLocation.zero;
                  int num4 = num2 + zspellWaterDrop.zb[index2].x;
                  int num5 = num3 + zspellWaterDrop.zb[index2].y;
                  for (int index3 = -2; index3 <= 2; ++index3)
                  {
                    for (int index4 = -2; index4 <= 2; ++index4)
                    {
                      if (zspellWaterDrop.map.SpellCheckPosition(num4 + index3, num5 + index4, zspellWaterDrop.toCollideCheck, Inert.mask_movement_NoEffector))
                      {
                        zero.x += index3;
                        zero.y += index4;
                      }
                    }
                  }
                  bool flag = false;
                  if (zspellWaterDrop.destroyTerrainFirstBounce && zspellWaterDrop.curDestroyTerrainBounces > 0)
                  {
                    --zspellWaterDrop.curDestroyTerrainBounces;
                    zspellWaterDrop.map.ServerBitBlt((int) zspellWaterDrop.explosionCutout, x2, y2, true, true);
                    zspellWaterDrop.MoveSurroundings(zspellWaterDrop.EXORADIUS + 5);
                    if (MyLocation.Distance(MyLocation.zero, zspellWaterDrop.velocity) > 40)
                      flag = true;
                  }
                  if (!flag)
                  {
                    zero.Normalize();
                    MyLocation ret;
                    MyLocation.Reflect(zspellWaterDrop.velocity, ref zero, out ret);
                    zspellWaterDrop.velocity = ret;
                    zspellWaterDrop.velocity = zspellWaterDrop.velocity * zspellWaterDrop.elasticity;
                  }
                  if (zspellWaterDrop.game.isClient && !zspellWaterDrop.game.resyncing && (Object) zspellWaterDrop.toSummon != (Object) null)
                    ZComponent.Instantiate<GameObject>(zspellWaterDrop.toSummon, new Vector3((float) x2, (float) y2), Quaternion.identity, zspellWaterDrop.game.GetMapTransform());
                  if (zspellWaterDrop.ApplyExplosionForce(zspellWaterDrop.position, Inert.mask_Phantom, true, (ISpellBridge) null, (ZCreature) null))
                  {
                    zspellWaterDrop.StopAndDie();
                    zspellWaterDrop.OnExplosionGeneric();
                    yield break;
                  }
                  else
                  {
                    zspellWaterDrop.Undie();
                    if (zspellWaterDrop.damageType == DamageType.Water && zspellWaterDrop.game.isClient)
                    {
                      AudioManager.Play(AudioManager.instance.waterBounce);
                      goto label_62;
                    }
                    else
                      goto label_62;
                  }
                }
                else
                {
                  zspellWaterDrop.velocity.y = (FixedInt) 0;
                  zspellWaterDrop.velocity.x = (FixedInt) 0;
                  zspellWaterDrop.position = new MyLocation(zspellWaterDrop.validX, zspellWaterDrop.validY);
                  zspellWaterDrop.moving = (IEnumerator<float>) null;
                  zspellWaterDrop.isMoving = false;
                  zspellWaterDrop.OnDeath(true);
                  zspellWaterDrop.OnExplosionGeneric();
                  yield break;
                }
              }
              else
              {
                zspellWaterDrop.velocity.y = (FixedInt) 0;
                zspellWaterDrop.velocity.x = (FixedInt) 0;
                zspellWaterDrop.position = new MyLocation(zspellWaterDrop.validX, zspellWaterDrop.validY);
                zspellWaterDrop.moving = (IEnumerator<float>) null;
                zspellWaterDrop.isMoving = false;
                zspellWaterDrop.map.ServerBitBlt((int) zspellWaterDrop.explosionCutout, x2, y2, true, true);
                zspellWaterDrop.OnDeath(true);
                zspellWaterDrop.OnExplosionGeneric();
                yield break;
              }
            }
          }
          zspellWaterDrop.validX = zspellWaterDrop.pX;
          zspellWaterDrop.validY = zspellWaterDrop.pY;
          zspellWaterDrop.pX = zspellWaterDrop.pX + fixedInt3;
          zspellWaterDrop.pY = zspellWaterDrop.pY + fixedInt4;
        }
      }
      zspellWaterDrop.position = zspellWaterDrop.position + zspellWaterDrop.velocity;
      if (zspellWaterDrop.position.y < zspellWaterDrop.radius)
      {
        zspellWaterDrop.moving = (IEnumerator<float>) null;
        zspellWaterDrop.velocity = MyLocation.zero;
        zspellWaterDrop.isMoving = false;
        zspellWaterDrop.Splash();
        zspellWaterDrop.DestroyDelay();
        break;
      }
      if (zspellWaterDrop.addVelocity)
      {
        zspellWaterDrop.addVelocity = false;
        zspellWaterDrop.velocity = zspellWaterDrop.velocity + zspellWaterDrop.addedVelocity;
        zspellWaterDrop.velocity.x = Mathd.Clamp(zspellWaterDrop.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellWaterDrop.velocity.y = Mathd.Clamp(zspellWaterDrop.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellWaterDrop.ResetAddedVelocity();
      }
      else if (zspellWaterDrop.affectedByGravity && zspellWaterDrop.velocity.y > -ZMap.MaxSpeed)
        zspellWaterDrop.velocity.y += zspellWaterDrop.map.Gravity;
      else if (!zspellWaterDrop.affectedByGravity && zspellWaterDrop.velocity.y > -10 && zspellWaterDrop.maxDuration > 150)
        zspellWaterDrop.affectedByGravity = true;
      zspellWaterDrop.Wind();
label_62:
      if (zspellWaterDrop.Rotates && (Object) zspellWaterDrop.transform != (Object) null)
        zspellWaterDrop.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellWaterDrop.velocity.y.ToFloat(), zspellWaterDrop.velocity.x.ToFloat()) * 57.29578f);
      ++zspellWaterDrop.curDuration;
      if (zspellWaterDrop.curDuration >= zspellWaterDrop.maxDuration)
      {
        if (zspellWaterDrop.spellEnum == SpellEnum.Firecrackers)
        {
          zspellWaterDrop.OnDeath(true);
          zspellWaterDrop.OnExplosionGeneric();
          break;
        }
        zspellWaterDrop.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
