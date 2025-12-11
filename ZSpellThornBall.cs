
using System.Collections.Generic;
using UnityEngine;

public class ZSpellThornBall : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellThornBall zspellThornBall = this;
    zspellThornBall.isMoving = true;
    zspellThornBall.zb = MapGenerator.getOutlineArray(zspellThornBall.radius);
    if (gotoStatic)
      yield return 0.0f;
label_42:
    while (!zspellThornBall.isDead)
    {
      zspellThornBall.pX = zspellThornBall.position.x;
      zspellThornBall.pY = zspellThornBall.position.y;
      FixedInt fixedInt1 = zspellThornBall.position.x + zspellThornBall.velocity.x;
      FixedInt fixedInt2 = zspellThornBall.position.y + zspellThornBall.velocity.y;
      zspellThornBall.validX = zspellThornBall.pX;
      zspellThornBall.validY = zspellThornBall.pY;
      zspellThornBall.steps = 1;
      FixedInt x = zspellThornBall.velocity.x;
      FixedInt y = zspellThornBall.velocity.y;
      FixedInt fixedInt3 = zspellThornBall.velocity.x;
      FixedInt fixedInt4 = zspellThornBall.velocity.y;
      if (x > 1 || x < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x) > FixedInt.Abs(y))
          zspellThornBall.steps = (int) FixedInt.Abs(x) + 1;
        else
          zspellThornBall.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellThornBall.velocity.x / zspellThornBall.steps;
        fixedInt4 = zspellThornBall.velocity.y / zspellThornBall.steps;
      }
      while (zspellThornBall.steps > 0)
      {
        if (zspellThornBall.map.SpellCheckEffectors(zspellThornBall.toCollideCheck, (ZSpell) zspellThornBall, (int) zspellThornBall.validX, (int) zspellThornBall.validY))
        {
          zspellThornBall.position = new MyLocation(zspellThornBall.validX, zspellThornBall.validY);
          yield return 0.0f;
          goto label_42;
        }
        else
        {
          --zspellThornBall.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellThornBall.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellThornBall.zb.Count) - zspellThornBall.radius;
          if (num1 < 0)
            num1 += zspellThornBall.zb.Count;
          for (int index1 = 0; index1 < zspellThornBall.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellThornBall.zb.Count;
            int num2 = (int) (fixedInt3 + zspellThornBall.pX);
            int num3 = (int) (fixedInt4 + zspellThornBall.pY);
            if (!zspellThornBall.map.SpellCheckPosition(num2 + zspellThornBall.zb[index2].x, num3 + zspellThornBall.zb[index2].y, zspellThornBall.toCollideCheck, Inert.mask_spell_movement))
            {
              int num4 = num2 + zspellThornBall.zb[index2].x;
              int num5 = num3 + zspellThornBall.zb[index2].y;
              if (!zspellThornBall.map.CheckPositionOnlyMap(num4, num5))
              {
                zspellThornBall.velocity.y = (FixedInt) 0;
                zspellThornBall.velocity.x = (FixedInt) 0;
                zspellThornBall.moving = (IEnumerator<float>) null;
                zspellThornBall.isMoving = false;
                if (!ZEffector.InSanctuary(zspellThornBall.game.world, new MyLocation(num4, num5)))
                {
                  ZCreatureThorn thorn = ZCreatureCreate.CreateThorn(zspellThornBall.game, zspellThornBall.parent?.parent, zspellThornBall.toSummon.GetComponent<CreatureThorn>(), (Vector2) new Vector3((float) num4, (float) num5), Quaternion.identity, zspellThornBall.game.GetMapTransform());
                  thorn.game = zspellThornBall.game;
                  thorn.spell.game = zspellThornBall.game;
                  thorn.spell.parent = (ZComponent) zspellThornBall.parent != (object) null ? zspellThornBall.parent.parent?.first() : zspellThornBall.parent;
                  thorn.collider.world = zspellThornBall.world;
                  thorn.collider.Move(new MyLocation(num4, num5));
                  thorn.spell.position = new MyLocation(num4, num5);
                  thorn.position = new MyLocation(num4, num5);
                  thorn.parent = zspellThornBall.parent?.parent;
                  zspellThornBall.game.thorns.Add(thorn);
                  if (zspellThornBall.game.isClient)
                    AudioManager.Play(AudioManager.instance.pop);
                }
                else
                  ZEffector.SpawnVineExplosion(new Vector3((float) num4, (float) num5));
                zspellThornBall.isDead = true;
                zspellThornBall.isNull = true;
                ZComponent.Destroy<GameObject>(zspellThornBall.gameObject);
                yield break;
              }
              else
              {
                ZCreature zcreature = zspellThornBall.map.PhysicsCollideCreature(zspellThornBall.toCollideCheck, num4, num5, 0);
                if ((ZComponent) zcreature != (object) null && zcreature.GetType() != typeof (ZCreatureThorn))
                {
                  zspellThornBall.velocity.y = (FixedInt) 0;
                  zspellThornBall.velocity.x = (FixedInt) 0;
                  zspellThornBall.position = new MyLocation(num2 + zspellThornBall.zb[index2].x, num3 + zspellThornBall.zb[index2].y);
                  zspellThornBall.moving = (IEnumerator<float>) null;
                  zspellThornBall.isMoving = false;
                  zspellThornBall.map.ServerBitBlt((int) zspellThornBall.explosionCutout, num4, num5, true, true);
                  zspellThornBall.OnExplosion();
                  zspellThornBall.OnDeath(true);
                  yield break;
                }
                else
                {
                  zspellThornBall.velocity.y = (FixedInt) 0;
                  zspellThornBall.velocity.x = (FixedInt) 0;
                  zspellThornBall.moving = (IEnumerator<float>) null;
                  zspellThornBall.isMoving = false;
                  if (!ZEffector.InSanctuary(zspellThornBall.game.world, new MyLocation(num4, num5)))
                  {
                    ZCreatureThorn thorn = ZCreatureCreate.CreateThorn(zspellThornBall.game, zspellThornBall.parent?.parent, zspellThornBall.toSummon.GetComponent<CreatureThorn>(), (Vector2) new Vector3((float) num4, (float) num5), Quaternion.identity, zspellThornBall.game.GetMapTransform());
                    thorn.game = zspellThornBall.game;
                    thorn.spell.game = zspellThornBall.game;
                    thorn.spell.parent = zspellThornBall.parent;
                    thorn.collider.world = zspellThornBall.world;
                    thorn.collider.Move(new MyLocation(num4, num5));
                    thorn.spell.position = new MyLocation(num4, num5);
                    thorn.position = new MyLocation(num4, num5);
                    thorn.parent = zspellThornBall.parent?.parent;
                    zspellThornBall.game.thorns.Add(thorn);
                    if (zspellThornBall.game.isClient)
                      AudioManager.Play(AudioManager.instance.pop);
                  }
                  else
                    ZEffector.SpawnVineExplosion(new Vector3((float) num4, (float) num5));
                  zspellThornBall.isDead = true;
                  zspellThornBall.isNull = true;
                  ZComponent.Destroy<GameObject>(zspellThornBall.gameObject);
                  yield break;
                }
              }
            }
          }
          zspellThornBall.validX = zspellThornBall.pX;
          zspellThornBall.validY = zspellThornBall.pY;
          zspellThornBall.pX = zspellThornBall.pX + fixedInt3;
          zspellThornBall.pY = zspellThornBall.pY + fixedInt4;
        }
      }
      zspellThornBall.position = zspellThornBall.position + zspellThornBall.velocity;
      if (zspellThornBall.position.y < zspellThornBall.radius)
      {
        zspellThornBall.moving = (IEnumerator<float>) null;
        zspellThornBall.velocity = MyLocation.zero;
        zspellThornBall.isMoving = false;
        zspellThornBall.Splash();
        zspellThornBall.DestroyDelay();
        break;
      }
      if (zspellThornBall.addVelocity)
      {
        zspellThornBall.addVelocity = false;
        zspellThornBall.velocity = zspellThornBall.velocity + zspellThornBall.addedVelocity;
        zspellThornBall.velocity.x = Mathd.Clamp(zspellThornBall.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellThornBall.velocity.y = Mathd.Clamp(zspellThornBall.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellThornBall.ResetAddedVelocity();
      }
      else if (zspellThornBall.affectedByGravity && zspellThornBall.velocity.y > -ZMap.MaxSpeed)
        zspellThornBall.velocity.y += zspellThornBall.map.Gravity;
      else if (!zspellThornBall.affectedByGravity && zspellThornBall.velocity.y > -10 && zspellThornBall.maxDuration > 150)
        zspellThornBall.affectedByGravity = true;
      zspellThornBall.Wind();
      ++zspellThornBall.curDuration;
      if (zspellThornBall.curDuration >= zspellThornBall.maxDuration)
      {
        zspellThornBall.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
