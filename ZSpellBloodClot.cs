
using System.Collections.Generic;
using UnityEngine;

public class ZSpellBloodClot : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellBloodClot zspellBloodClot = this;
    zspellBloodClot.isMoving = true;
    zspellBloodClot.zb = MapGenerator.getOutlineArray(zspellBloodClot.radius);
    if (gotoStatic)
      yield return 0.0f;
label_47:
    while (!zspellBloodClot.isDead)
    {
      zspellBloodClot.pX = zspellBloodClot.position.x;
      zspellBloodClot.pY = zspellBloodClot.position.y;
      FixedInt fixedInt1 = zspellBloodClot.position.x + zspellBloodClot.velocity.x;
      FixedInt fixedInt2 = zspellBloodClot.position.y + zspellBloodClot.velocity.y;
      zspellBloodClot.validX = zspellBloodClot.pX;
      zspellBloodClot.validY = zspellBloodClot.pY;
      zspellBloodClot.steps = 1;
      FixedInt x1 = zspellBloodClot.velocity.x;
      FixedInt y1 = zspellBloodClot.velocity.y;
      FixedInt fixedInt3 = zspellBloodClot.velocity.x;
      FixedInt fixedInt4 = zspellBloodClot.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellBloodClot.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellBloodClot.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellBloodClot.velocity.x / zspellBloodClot.steps;
        fixedInt4 = zspellBloodClot.velocity.y / zspellBloodClot.steps;
      }
      while (zspellBloodClot.steps > 0)
      {
        if (zspellBloodClot.map.SpellCheckEffectors(zspellBloodClot.toCollideCheck, (ZSpell) zspellBloodClot, (int) zspellBloodClot.validX, (int) zspellBloodClot.validY))
        {
          zspellBloodClot.position = new MyLocation(zspellBloodClot.validX, zspellBloodClot.validY);
          yield return 0.0f;
          goto label_47;
        }
        else
        {
          --zspellBloodClot.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellBloodClot.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellBloodClot.zb.Count) - zspellBloodClot.radius;
          if (num1 < 0)
            num1 += zspellBloodClot.zb.Count;
          for (int index1 = 0; index1 < zspellBloodClot.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellBloodClot.zb.Count;
            if (!zspellBloodClot.map.SpellCheckPosition((int) (fixedInt3 + zspellBloodClot.pX) + zspellBloodClot.zb[index2].x, (int) (fixedInt4 + zspellBloodClot.pY) + zspellBloodClot.zb[index2].y, zspellBloodClot.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellBloodClot.pX);
              int num3 = (int) (fixedInt4 + zspellBloodClot.pY);
              AudioManager.Play(zspellBloodClot.explosionClip);
              int x2 = num2 + zspellBloodClot.zb[index2].x;
              int y2 = num3 + zspellBloodClot.zb[index2].y;
              ++zspellBloodClot.timesBounced;
              zspellBloodClot.target = new MyLocation((FixedInt) x2 + zspellBloodClot.velocity.x, (FixedInt) y2 + zspellBloodClot.velocity.y);
              ZCreature zcreature = zspellBloodClot.map.PhysicsCollideCreature((ZCreature) null, x2, y2, 0);
              if (((ZComponent) zcreature == (object) null || (ZComponent) zspellBloodClot.parent != (object) null && zcreature.parent.team == zspellBloodClot.parent.parent.team) && zspellBloodClot.timesBounced < zspellBloodClot.Bounces)
              {
                zspellBloodClot.position = new MyLocation(zspellBloodClot.validX, zspellBloodClot.validY);
                MyLocation zero = MyLocation.zero;
                int num4 = num2 + zspellBloodClot.zb[index2].x;
                int num5 = num3 + zspellBloodClot.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellBloodClot.map.SpellCheckPosition(num4 + index3, num5 + index4, zspellBloodClot.toCollideCheck, Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                zero.Normalize();
                MyLocation.Reflect(zspellBloodClot.velocity, ref zero, out zspellBloodClot.velocity);
                if ((ZComponent) zcreature != (object) null)
                {
                  zspellBloodClot.velocity.Normalize();
                  zspellBloodClot.velocity = zspellBloodClot.velocity * 20;
                  goto label_44;
                }
                else
                {
                  zspellBloodClot.velocity = zspellBloodClot.velocity * zspellBloodClot.elasticity;
                  goto label_44;
                }
              }
              else
              {
                if ((ZComponent) zcreature == (object) null || (ZComponent) zspellBloodClot.parent != (object) null && zcreature.parent.team != zspellBloodClot.parent.parent.team)
                {
                  zspellBloodClot.position = new MyLocation(zspellBloodClot.validX + fixedInt3 * zspellBloodClot.steps / (FixedInt) 2621440L, zspellBloodClot.validY + fixedInt4 * zspellBloodClot.steps / (FixedInt) 2621440L);
                  zspellBloodClot.map.ServerBitBltBrightness(46, (int) zspellBloodClot.position.x, (int) zspellBloodClot.position.y, (FixedInt) (zspellBloodClot.game.RandomFixedInt(50, 150) / 100).ToFloat(), false);
                  zspellBloodClot.OnExplosion();
                  zspellBloodClot.ApplyExplosionForce(zspellBloodClot.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                }
                zspellBloodClot.DestroyDelay();
                yield break;
              }
            }
          }
          zspellBloodClot.validX = zspellBloodClot.pX;
          zspellBloodClot.validY = zspellBloodClot.pY;
          zspellBloodClot.pX = zspellBloodClot.pX + fixedInt3;
          zspellBloodClot.pY = zspellBloodClot.pY + fixedInt4;
        }
      }
      zspellBloodClot.position = zspellBloodClot.position + zspellBloodClot.velocity;
      if (zspellBloodClot.timesBounced > 0)
        zspellBloodClot.RotateToward();
      if (zspellBloodClot.position.y < zspellBloodClot.radius)
      {
        zspellBloodClot.moving = (IEnumerator<float>) null;
        zspellBloodClot.velocity = MyLocation.zero;
        zspellBloodClot.isMoving = false;
        zspellBloodClot.Splash();
        zspellBloodClot.DestroyDelay();
        break;
      }
      if (zspellBloodClot.addVelocity)
      {
        zspellBloodClot.addVelocity = false;
        zspellBloodClot.velocity = zspellBloodClot.velocity + zspellBloodClot.addedVelocity;
        zspellBloodClot.velocity.x = Mathd.Clamp(zspellBloodClot.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellBloodClot.velocity.y = Mathd.Clamp(zspellBloodClot.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellBloodClot.ResetAddedVelocity();
      }
      else if (zspellBloodClot.affectedByGravity && zspellBloodClot.velocity.y > -ZMap.MaxSpeed)
        zspellBloodClot.velocity.y += zspellBloodClot.map.Gravity;
      else if (!zspellBloodClot.affectedByGravity && zspellBloodClot.velocity.y > -10 && zspellBloodClot.maxDuration > 150)
        zspellBloodClot.affectedByGravity = true;
      zspellBloodClot.Wind();
label_44:
      ++zspellBloodClot.curDuration;
      zspellBloodClot.Undie();
      if (zspellBloodClot.curDuration >= zspellBloodClot.maxDuration)
      {
        zspellBloodClot.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }

  public void ElectrostaticInterference()
  {
    List<ZMyCollider> list = this.game.world.OverlapCircleAll((Point) this.position, 512, (ZMyCollider) null, 512);
    ZSpell kablam = (ZSpell) null;
    for (int index = 0; index < list.Count; ++index)
    {
      if ((ZComponent) list[index] != (object) null && (ZComponent) list[index].effector != (object) null && list[index].effector.type == EffectorType.Electrostatic_Charge)
      {
        if ((ZComponent) kablam == (object) null)
          kablam = ZSpell.BaseFireKablam(Inert.Instance.spells["Thunder Shock"], this.parent, this.position, Quaternion.identity);
        Coords start = new Coords((int) this.position.x, (int) this.position.y);
        Coords end = new Coords((int) list[index].position.x, (int) list[index].position.y);
        Coords coords = this.parent.map.bresenhamsLineCast(start, end, this.parent, (ZSpell) null, Inert.mask_spell_movement);
        if (coords != null)
        {
          this.parent.map.ServerBitBlt((int) this.explosionCutout, coords.x, coords.y, true, true);
          kablam.ApplyExplosionForce(coords.ToMyLocation(), 0, true, (ISpellBridge) null, (ZCreature) null);
          if (this.parent.game.isClient && !this.parent.game.resyncing)
            this.parent.game.electricityPool.Spawn(start.ToVector(), coords.ToVector());
        }
        else
        {
          this.ChainLink(list[index].position, kablam);
          if (this.parent.game.isClient && !this.parent.game.resyncing)
            this.parent.game.electricityPool.Spawn(start.ToVector(), (Vector3) list[index].position.ToSinglePrecision());
        }
        kablam.Undie();
      }
    }
    this.game.world.listPool.ReturnList(list);
    if (!((Object) kablam?.gameObject != (Object) null))
      return;
    ZComponent.Destroy<GameObject>(kablam.gameObject);
  }

  public void ChainLink(MyLocation position, ZSpell kablam)
  {
    List<ZMyCollider> list = this.game.world.OverlapCircleAll((Point) position, 256, (ZMyCollider) null, 256);
    for (int index = 0; index < list.Count; ++index)
    {
      if (!ZComponent.IsNull((ZComponent) list[index]) && !ZComponent.IsNull((ZComponent) list[index].creature) && list[index].creature.race != CreatureRace.Effector)
      {
        Coords start = new Coords((int) position.x, (int) position.y);
        Coords end = new Coords((int) list[index].position.x, (int) list[index].position.y);
        Coords coords = this.parent.map.bresenhamsLineCast(start, end, this.parent, (ZSpell) null, Inert.mask_spell_movement);
        if (coords != null)
        {
          this.parent.map.ServerBitBlt((int) this.explosionCutout, coords.x, coords.y, true, true);
          kablam.ApplyExplosionForce(coords.ToMyLocation(), 0, true, (ISpellBridge) null, (ZCreature) null);
          if (this.parent.game.isClient && !this.parent.game.resyncing)
            this.parent.game.electricityPool.Spawn(start.ToVector(), coords.ToVector());
        }
        else if (this.parent.game.isClient && !this.parent.game.resyncing)
          this.parent.game.electricityPool.Spawn(start.ToVector(), (Vector3) list[index].position.ToSinglePrecision());
        kablam.Undie();
      }
    }
    this.game.world.listPool.ReturnList(list);
  }
}
