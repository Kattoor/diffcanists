
using System.Collections.Generic;
using UnityEngine;

public class ZSpellCallingBell : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellCallingBell zspellCallingBell = this;
    zspellCallingBell.isMoving = true;
    zspellCallingBell.zb = MapGenerator.getOutlineArray(zspellCallingBell.radius);
    if (gotoStatic)
      yield return 0.0f;
label_47:
    while (!zspellCallingBell.isDead)
    {
      zspellCallingBell.pX = zspellCallingBell.position.x;
      zspellCallingBell.pY = zspellCallingBell.position.y;
      FixedInt fixedInt1 = zspellCallingBell.position.x + zspellCallingBell.velocity.x;
      FixedInt fixedInt2 = zspellCallingBell.position.y + zspellCallingBell.velocity.y;
      zspellCallingBell.validX = zspellCallingBell.pX;
      zspellCallingBell.validY = zspellCallingBell.pY;
      zspellCallingBell.steps = 1;
      FixedInt x1 = zspellCallingBell.velocity.x;
      FixedInt y1 = zspellCallingBell.velocity.y;
      FixedInt fixedInt3 = zspellCallingBell.velocity.x;
      FixedInt fixedInt4 = zspellCallingBell.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellCallingBell.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellCallingBell.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellCallingBell.velocity.x / zspellCallingBell.steps;
        fixedInt4 = zspellCallingBell.velocity.y / zspellCallingBell.steps;
      }
      while (zspellCallingBell.steps > 0)
      {
        if (zspellCallingBell.map.SpellCheckEffectors(zspellCallingBell.toCollideCheck, (ZSpell) zspellCallingBell, (int) zspellCallingBell.validX, (int) zspellCallingBell.validY))
        {
          zspellCallingBell.position = new MyLocation(zspellCallingBell.validX, zspellCallingBell.validY);
          yield return 0.0f;
          goto label_47;
        }
        else
        {
          --zspellCallingBell.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellCallingBell.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellCallingBell.zb.Count) - zspellCallingBell.radius;
          if (num1 < 0)
            num1 += zspellCallingBell.zb.Count;
          for (int index1 = 0; index1 < zspellCallingBell.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellCallingBell.zb.Count;
            if (!zspellCallingBell.map.SpellCheckPosition((int) (fixedInt3 + zspellCallingBell.pX) + zspellCallingBell.zb[index2].x, (int) (fixedInt4 + zspellCallingBell.pY) + zspellCallingBell.zb[index2].y, zspellCallingBell.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellCallingBell.pX);
              int num3 = (int) (fixedInt4 + zspellCallingBell.pY);
              int x2 = zspellCallingBell.zb[index2].x;
              int x3 = num2 + x2;
              int y2 = num3 + zspellCallingBell.zb[index2].y;
              if (!zspellCallingBell.map.CheckPositionOnlyMap(x3, y2))
              {
                zspellCallingBell.isDead = true;
                zspellCallingBell.isNull = true;
                if (zspellCallingBell.game.isClient && !zspellCallingBell.game.resyncing)
                  ZComponent.Instantiate<GameObject>(zspellCallingBell.explosion, new Vector3((float) x3, (float) y2), Quaternion.identity, zspellCallingBell.game.GetMapTransform());
                ZComponent.Destroy<GameObject>(zspellCallingBell.gameObject);
                yield break;
              }
              else
              {
                ZCreature c = zspellCallingBell.map.PhysicsCollideCreature(zspellCallingBell.toCollideCheck, x3, y2, 0);
                if ((ZComponent) c != (object) null && c.race != CreatureRace.Effector && c.type != CreatureType.Recall_Device)
                {
                  while (zspellCallingBell.game.recallDevices.Count > 0)
                  {
                    int index3 = zspellCallingBell.game.RandomInt(0, zspellCallingBell.game.recallDevices.Count);
                    ZCreature recallDevice = zspellCallingBell.game.recallDevices[index3];
                    if (!ZComponent.IsNull((ZComponent) recallDevice))
                    {
                      zspellCallingBell.game.recallDevices.RemoveAt(index3);
                      recallDevice.OnDeath(true);
                      if ((ZComponent) c != (object) null)
                      {
                        ZSpell.FireTeleportNoDetower(zspellCallingBell.baseSpell, c, recallDevice.position);
                        break;
                      }
                      break;
                    }
                    zspellCallingBell.game.recallDevices.RemoveAt(index3);
                  }
                  zspellCallingBell.isDead = true;
                  zspellCallingBell.isNull = true;
                  if (zspellCallingBell.game.isClient && !zspellCallingBell.game.resyncing)
                    ZComponent.Instantiate<GameObject>(zspellCallingBell.explosion, new Vector3((float) x3, (float) y2), Quaternion.identity, zspellCallingBell.game.GetMapTransform());
                  ZComponent.Destroy<GameObject>(zspellCallingBell.gameObject);
                  yield break;
                }
                else
                {
                  zspellCallingBell.isDead = true;
                  zspellCallingBell.isNull = true;
                  if (zspellCallingBell.game.isClient && !zspellCallingBell.game.resyncing)
                    ZComponent.Instantiate<GameObject>(zspellCallingBell.explosion, new Vector3((float) x3, (float) y2), Quaternion.identity, zspellCallingBell.game.GetMapTransform());
                  ZComponent.Destroy<GameObject>(zspellCallingBell.gameObject);
                  yield break;
                }
              }
            }
          }
          zspellCallingBell.validX = zspellCallingBell.pX;
          zspellCallingBell.validY = zspellCallingBell.pY;
          zspellCallingBell.pX = zspellCallingBell.pX + fixedInt3;
          zspellCallingBell.pY = zspellCallingBell.pY + fixedInt4;
        }
      }
      zspellCallingBell.position = zspellCallingBell.position + zspellCallingBell.velocity;
      if (zspellCallingBell.position.y < zspellCallingBell.radius)
      {
        zspellCallingBell.moving = (IEnumerator<float>) null;
        zspellCallingBell.velocity = MyLocation.zero;
        zspellCallingBell.isMoving = false;
        zspellCallingBell.Splash();
        zspellCallingBell.DestroyDelay();
        break;
      }
      if (zspellCallingBell.addVelocity)
      {
        zspellCallingBell.addVelocity = false;
        zspellCallingBell.velocity = zspellCallingBell.velocity + zspellCallingBell.addedVelocity;
        zspellCallingBell.velocity.x = Mathd.Clamp(zspellCallingBell.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellCallingBell.velocity.y = Mathd.Clamp(zspellCallingBell.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellCallingBell.addedVelocity.x = (FixedInt) 0;
        zspellCallingBell.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellCallingBell.affectedByGravity && zspellCallingBell.velocity.y > -ZMap.MaxSpeed)
        zspellCallingBell.velocity.y += zspellCallingBell.map.Gravity;
      else if (!zspellCallingBell.affectedByGravity && zspellCallingBell.velocity.y > -10 && zspellCallingBell.maxDuration > 150)
        zspellCallingBell.affectedByGravity = true;
      zspellCallingBell.Wind();
      if (zspellCallingBell.Rotates)
        zspellCallingBell.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(zspellCallingBell.velocity.y.ToFloat(), zspellCallingBell.velocity.x.ToFloat()) * 57.29578f);
      ++zspellCallingBell.curDuration;
      if (zspellCallingBell.curDuration >= zspellCallingBell.maxDuration)
      {
        zspellCallingBell.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
