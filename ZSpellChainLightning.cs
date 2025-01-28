
using System.Collections.Generic;
using UnityEngine;

public class ZSpellChainLightning : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellChainLightning zspellChainLightning = this;
    zspellChainLightning.isMoving = true;
    zspellChainLightning.zb = MapGenerator.getOutlineArray(zspellChainLightning.radius);
    if (gotoStatic)
      yield return 0.0f;
label_48:
    while (!zspellChainLightning.isDead)
    {
      zspellChainLightning.pX = zspellChainLightning.position.x;
      zspellChainLightning.pY = zspellChainLightning.position.y;
      FixedInt fixedInt1 = zspellChainLightning.position.x + zspellChainLightning.velocity.x;
      FixedInt fixedInt2 = zspellChainLightning.position.y + zspellChainLightning.velocity.y;
      zspellChainLightning.validX = zspellChainLightning.pX;
      zspellChainLightning.validY = zspellChainLightning.pY;
      zspellChainLightning.steps = 1;
      FixedInt x1 = zspellChainLightning.velocity.x;
      FixedInt y1 = zspellChainLightning.velocity.y;
      FixedInt fixedInt3 = zspellChainLightning.velocity.x;
      FixedInt fixedInt4 = zspellChainLightning.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellChainLightning.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellChainLightning.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellChainLightning.velocity.x / zspellChainLightning.steps;
        fixedInt4 = zspellChainLightning.velocity.y / zspellChainLightning.steps;
      }
      while (zspellChainLightning.steps > 0)
      {
        if (zspellChainLightning.map.SpellCheckEffectors(zspellChainLightning.toCollideCheck, (ZSpell) zspellChainLightning, (int) zspellChainLightning.validX, (int) zspellChainLightning.validY))
        {
          zspellChainLightning.position = new MyLocation(zspellChainLightning.validX, zspellChainLightning.validY);
          yield return 0.0f;
          goto label_48;
        }
        else
        {
          --zspellChainLightning.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellChainLightning.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellChainLightning.zb.Count) - zspellChainLightning.radius;
          if (num1 < 0)
            num1 += zspellChainLightning.zb.Count;
          for (int index1 = 0; index1 < zspellChainLightning.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellChainLightning.zb.Count;
            bool flag1;
            bool flag2;
            if (zspellChainLightning.curDuration > zspellChainLightning.lastLivingHit)
            {
              flag1 = zspellChainLightning.map.SpellCheckPosition((int) (fixedInt3 + zspellChainLightning.pX) + zspellChainLightning.zb[index2].x, (int) (fixedInt4 + zspellChainLightning.pY) + zspellChainLightning.zb[index2].y, zspellChainLightning.toCollideCheck, Inert.mask_spell_movement);
              flag2 = !flag1;
            }
            else
            {
              flag1 = zspellChainLightning.map.SpellCheckPositionUndeadOnly((int) (fixedInt3 + zspellChainLightning.pX) + zspellChainLightning.zb[index2].x, (int) (fixedInt4 + zspellChainLightning.pY) + zspellChainLightning.zb[index2].y, zspellChainLightning.toCollideCheck, (ZSpell) zspellChainLightning, Inert.mask_spell_movement);
              flag2 = false;
            }
            if (!flag1)
            {
              int num2 = (int) (fixedInt3 + zspellChainLightning.pX);
              int num3 = (int) (fixedInt4 + zspellChainLightning.pY);
              AudioManager.Play(zspellChainLightning.explosionClip);
              int x2 = num2 + zspellChainLightning.zb[index2].x;
              int y2 = num3 + zspellChainLightning.zb[index2].y;
              ++zspellChainLightning.timesBounced;
              ZCreature zcreature = zspellChainLightning.map.PhysicsCollideCreature((ZCreature) null, x2, y2, 0);
              if ((ZComponent) zcreature != (object) null & flag2 && (ZComponent) zcreature.tower == (object) null)
                zspellChainLightning.lastLivingHit = zspellChainLightning.curDuration + 5;
              if ((ZComponent) zcreature == (object) null || (ZComponent) zcreature.tower == (object) null && !flag2)
              {
                zspellChainLightning.position = new MyLocation(zspellChainLightning.validX, zspellChainLightning.validY);
                MyLocation zero = MyLocation.zero;
                int num4 = num2 + zspellChainLightning.zb[index2].x;
                int num5 = num3 + zspellChainLightning.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellChainLightning.map.SpellCheckPosition(num4 + index3, num5 + index4, zspellChainLightning.toCollideCheck, Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                zero.Normalize();
                MyLocation.Reflect(zspellChainLightning.velocity, ref zero, out zspellChainLightning.velocity);
                zspellChainLightning.velocity = zspellChainLightning.velocity * 838860L;
                if (zspellChainLightning.timesBounced == 1)
                  zspellChainLightning.velocity = zspellChainLightning.velocity * 524288L;
                zspellChainLightning.map.ServerBitBlt((int) zspellChainLightning.explosionCutout, (int) zspellChainLightning.validX, (int) zspellChainLightning.validY, true, true);
                zspellChainLightning.OnExplosion();
                zspellChainLightning.MoveSurroundings(zspellChainLightning.EXORADIUS + 5);
                zspellChainLightning.ApplyExplosionForce(zspellChainLightning.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellChainLightning.ElectrostaticInterference();
                goto label_45;
              }
              else
              {
                zspellChainLightning.position = new MyLocation(zspellChainLightning.validX + fixedInt3 * zspellChainLightning.steps / (FixedInt) 2621440L, zspellChainLightning.validY + fixedInt4 * zspellChainLightning.steps / (FixedInt) 2621440L);
                zspellChainLightning.map.ServerBitBlt((int) zspellChainLightning.explosionCutout, (int) zspellChainLightning.validX, (int) zspellChainLightning.validY, true, true);
                zspellChainLightning.OnExplosion();
                zspellChainLightning.MoveSurroundings(zspellChainLightning.EXORADIUS + 5);
                zspellChainLightning.ApplyExplosionForce(zspellChainLightning.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellChainLightning.ElectrostaticInterference();
                goto label_45;
              }
            }
          }
          zspellChainLightning.validX = zspellChainLightning.pX;
          zspellChainLightning.validY = zspellChainLightning.pY;
          zspellChainLightning.pX = zspellChainLightning.pX + fixedInt3;
          zspellChainLightning.pY = zspellChainLightning.pY + fixedInt4;
        }
      }
      zspellChainLightning.position = zspellChainLightning.position + zspellChainLightning.velocity;
      if (zspellChainLightning.position.y < zspellChainLightning.radius)
      {
        zspellChainLightning.moving = (IEnumerator<float>) null;
        zspellChainLightning.velocity = MyLocation.zero;
        zspellChainLightning.isMoving = false;
        zspellChainLightning.Splash();
        zspellChainLightning.DestroyDelay();
        break;
      }
      if (zspellChainLightning.addVelocity)
      {
        zspellChainLightning.addVelocity = false;
        zspellChainLightning.velocity = zspellChainLightning.velocity + zspellChainLightning.addedVelocity;
        zspellChainLightning.velocity.x = Mathd.Clamp(zspellChainLightning.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellChainLightning.velocity.y = Mathd.Clamp(zspellChainLightning.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellChainLightning.addedVelocity.x = (FixedInt) 0;
        zspellChainLightning.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellChainLightning.affectedByGravity && zspellChainLightning.velocity.y > -ZMap.MaxSpeed)
        zspellChainLightning.velocity.y += zspellChainLightning.map.Gravity;
      else if (!zspellChainLightning.affectedByGravity && zspellChainLightning.velocity.y > -10 && zspellChainLightning.maxDuration > 150)
        zspellChainLightning.affectedByGravity = true;
      zspellChainLightning.Wind();
label_45:
      ++zspellChainLightning.curDuration;
      zspellChainLightning.Undie();
      if (zspellChainLightning.curDuration >= zspellChainLightning.maxDuration || zspellChainLightning.timesBounced >= zspellChainLightning.Bounces)
      {
        zspellChainLightning.DestroyDelay();
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
