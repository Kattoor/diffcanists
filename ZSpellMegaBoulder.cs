
using System.Collections.Generic;
using UnityEngine;

public class ZSpellMegaBoulder : ZSpell
{
  private const int lifetime = 30;

  public void Expand()
  {
    AudioManager.Play(this.explosionClip);
    if (this.game.isClient && (Object) this.gameObject != (Object) null && !StoreObject.OnSpell((ZSpell) this, this.parent, true))
      this.gameObject.GetComponent<SpriteRenderer>().sprite = Inert.Instance.megaBoulderSprite;
    this.radius = 28;
    this.velocity.x *= 786432L;
    this.zb = MapGenerator.getOutlineArray(this.radius);
    this.lastHit = this.curDuration;
    this.OnExplosion();
  }

  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellMegaBoulder zspellMegaBoulder = this;
    zspellMegaBoulder.isMoving = true;
    zspellMegaBoulder.zb = MapGenerator.getOutlineArray(zspellMegaBoulder.radius);
    if (gotoStatic)
      yield return 0.0f;
label_59:
    while (!zspellMegaBoulder.isDead)
    {
      if (zspellMegaBoulder.curDuration == 30 && zspellMegaBoulder.radius != 28)
        zspellMegaBoulder.Expand();
      zspellMegaBoulder.pX = zspellMegaBoulder.position.x;
      zspellMegaBoulder.pY = zspellMegaBoulder.position.y;
      FixedInt fixedInt1 = zspellMegaBoulder.position.x + zspellMegaBoulder.velocity.x;
      FixedInt fixedInt2 = zspellMegaBoulder.position.y + zspellMegaBoulder.velocity.y;
      zspellMegaBoulder.validX = zspellMegaBoulder.pX;
      zspellMegaBoulder.validY = zspellMegaBoulder.pY;
      zspellMegaBoulder.steps = 1;
      FixedInt x1 = zspellMegaBoulder.velocity.x;
      FixedInt y1 = zspellMegaBoulder.velocity.y;
      FixedInt fixedInt3 = zspellMegaBoulder.velocity.x;
      FixedInt fixedInt4 = zspellMegaBoulder.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellMegaBoulder.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellMegaBoulder.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellMegaBoulder.velocity.x / zspellMegaBoulder.steps;
        fixedInt4 = zspellMegaBoulder.velocity.y / zspellMegaBoulder.steps;
      }
      while (zspellMegaBoulder.steps > 0)
      {
        if (zspellMegaBoulder.map.SpellCheckEffectors(zspellMegaBoulder.toCollideCheck, (ZSpell) zspellMegaBoulder, (int) zspellMegaBoulder.validX, (int) zspellMegaBoulder.validY))
        {
          zspellMegaBoulder.position = new MyLocation(zspellMegaBoulder.validX, zspellMegaBoulder.validY);
          yield return 0.0f;
          goto label_59;
        }
        else
        {
          --zspellMegaBoulder.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellMegaBoulder.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellMegaBoulder.zb.Count) - zspellMegaBoulder.radius;
          if (num1 < 0)
            num1 += zspellMegaBoulder.zb.Count;
          for (int index1 = 0; index1 < zspellMegaBoulder.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellMegaBoulder.zb.Count;
            if (!zspellMegaBoulder.map.SpellCheckPosition((int) (fixedInt3 + zspellMegaBoulder.pX) + zspellMegaBoulder.zb[index2].x, (int) (fixedInt4 + zspellMegaBoulder.pY) + zspellMegaBoulder.zb[index2].y, zspellMegaBoulder.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellMegaBoulder.pX);
              int num3 = (int) (fixedInt4 + zspellMegaBoulder.pY);
              if (zspellMegaBoulder.game.isClient)
              {
                if (zspellMegaBoulder.curDuration >= 30)
                  AudioManager.Play(zspellMegaBoulder.explosionClip);
                else
                  AudioManager.Play(AudioManager.instance.spellBounce);
              }
              int x2 = num2 + zspellMegaBoulder.zb[index2].x;
              int y2 = num3 + zspellMegaBoulder.zb[index2].y;
              if (zspellMegaBoulder.curDuration < 30)
              {
                zspellMegaBoulder.position = new MyLocation(zspellMegaBoulder.validX, zspellMegaBoulder.validY);
                MyLocation zero = MyLocation.zero;
                int num4 = num2 + zspellMegaBoulder.zb[index2].x;
                int num5 = num3 + zspellMegaBoulder.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellMegaBoulder.map.SpellCheckPosition(num4 + index3, num5 + index4, zspellMegaBoulder.toCollideCheck, Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                zero.Normalize();
                MyLocation.Reflect(zspellMegaBoulder.velocity, ref zero, out zspellMegaBoulder.velocity);
                zspellMegaBoulder.velocity = zspellMegaBoulder.velocity * zspellMegaBoulder.elasticity;
                goto label_56;
              }
              else
              {
                ++zspellMegaBoulder.timesBounced;
                zspellMegaBoulder.position = new MyLocation(zspellMegaBoulder.validX, zspellMegaBoulder.validY);
                ZCreature zcreature = zspellMegaBoulder.map.PhysicsCollideCreature((ZCreature) null, x2, y2, 0);
                zspellMegaBoulder.damage = 25 + Mathf.Clamp(zspellMegaBoulder.curDuration - zspellMegaBoulder.lastHit, 0, 7);
                if ((ZComponent) zcreature == (object) null)
                {
                  zspellMegaBoulder.velocity.x = -zspellMegaBoulder.velocity.x;
                  zspellMegaBoulder.velocity.x *= zspellMegaBoulder.elasticity;
                  zspellMegaBoulder.velocity.y = (FixedInt) (zspellMegaBoulder.zb[index2].y > 5 ? 2 : 7);
                }
                else
                {
                  MyLocation zero = MyLocation.zero;
                  for (int index3 = -2; index3 <= 2; ++index3)
                  {
                    for (int index4 = -2; index4 <= 2; ++index4)
                    {
                      if (zspellMegaBoulder.map.SpellCheckPosition(x2 + index3, y2 + index4, zspellMegaBoulder.toCollideCheck, Inert.mask_movement_NoEffector))
                      {
                        zero.x += index3;
                        zero.y += index4;
                      }
                    }
                  }
                  zero.Normalize();
                  MyLocation.Reflect(zspellMegaBoulder.velocity, ref zero, out zspellMegaBoulder.velocity);
                  zspellMegaBoulder.velocity.x *= zspellMegaBoulder.timesBounced % 2 == 1 ? -2 : 2;
                  zspellMegaBoulder.velocity.x = Mathd.Clamp(zspellMegaBoulder.velocity.x, (FixedInt) -9, (FixedInt) 9);
                  zspellMegaBoulder.velocity.y = (FixedInt) (zspellMegaBoulder.curDuration - zspellMegaBoulder.lastHit > 2 ? -5 : 5);
                }
                zspellMegaBoulder.lastHit = zspellMegaBoulder.curDuration;
                zspellMegaBoulder.map.ServerBitBlt((int) zspellMegaBoulder.explosionCutout, (int) zspellMegaBoulder.validX, zspellMegaBoulder.map.CheckPositionOnlyMap(x2, y2) ? y2 : (int) zspellMegaBoulder.validY, true, true);
                zspellMegaBoulder.OnExplosion();
                zspellMegaBoulder.ApplyExplosionForce(zspellMegaBoulder.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                if ((ZComponent) zcreature != (object) null && zspellMegaBoulder.timesBounced < 4 && zspellMegaBoulder.velocity.magnitude < 7)
                {
                  zspellMegaBoulder.Undie();
                  goto label_59;
                }
                else
                  goto label_56;
              }
            }
          }
          zspellMegaBoulder.validX = zspellMegaBoulder.pX;
          zspellMegaBoulder.validY = zspellMegaBoulder.pY;
          zspellMegaBoulder.pX = zspellMegaBoulder.pX + fixedInt3;
          zspellMegaBoulder.pY = zspellMegaBoulder.pY + fixedInt4;
        }
      }
      zspellMegaBoulder.position = zspellMegaBoulder.position + zspellMegaBoulder.velocity;
      if (zspellMegaBoulder.position.y < zspellMegaBoulder.radius)
      {
        zspellMegaBoulder.moving = (IEnumerator<float>) null;
        zspellMegaBoulder.velocity = MyLocation.zero;
        zspellMegaBoulder.isMoving = false;
        zspellMegaBoulder.Splash();
        zspellMegaBoulder.DestroyDelay();
        break;
      }
      if (zspellMegaBoulder.addVelocity)
      {
        zspellMegaBoulder.addVelocity = false;
        zspellMegaBoulder.velocity = zspellMegaBoulder.velocity + zspellMegaBoulder.addedVelocity;
        zspellMegaBoulder.velocity.x = Mathd.Clamp(zspellMegaBoulder.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellMegaBoulder.velocity.y = Mathd.Clamp(zspellMegaBoulder.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellMegaBoulder.addedVelocity.x = (FixedInt) 0;
        zspellMegaBoulder.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellMegaBoulder.affectedByGravity && zspellMegaBoulder.velocity.y > -ZMap.MaxSpeed)
        zspellMegaBoulder.velocity.y += zspellMegaBoulder.map.Gravity;
      else if (!zspellMegaBoulder.affectedByGravity && zspellMegaBoulder.velocity.y > -10 && zspellMegaBoulder.maxDuration > 150)
        zspellMegaBoulder.affectedByGravity = true;
      zspellMegaBoulder.Wind();
label_56:
      ++zspellMegaBoulder.curDuration;
      zspellMegaBoulder.Undie();
      if (zspellMegaBoulder.curDuration >= zspellMegaBoulder.maxDuration || zspellMegaBoulder.timesBounced >= 4)
      {
        zspellMegaBoulder.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
