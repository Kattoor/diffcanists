
using System.Collections.Generic;
using UnityEngine;

public class ZSpellEnduringSpirits : ZSpell
{
  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellEnduringSpirits zspellEnduringSpirits = this;
    zspellEnduringSpirits.isMoving = true;
    zspellEnduringSpirits.zb = MapGenerator.getOutlineArray(zspellEnduringSpirits.radius);
    if (gotoStatic)
      yield return 0.0f;
label_44:
    while (!zspellEnduringSpirits.isDead)
    {
      zspellEnduringSpirits.pX = zspellEnduringSpirits.position.x;
      zspellEnduringSpirits.pY = zspellEnduringSpirits.position.y;
      FixedInt fixedInt1 = zspellEnduringSpirits.position.x + zspellEnduringSpirits.velocity.x;
      FixedInt fixedInt2 = zspellEnduringSpirits.position.y + zspellEnduringSpirits.velocity.y;
      zspellEnduringSpirits.validX = zspellEnduringSpirits.pX;
      zspellEnduringSpirits.validY = zspellEnduringSpirits.pY;
      zspellEnduringSpirits.steps = 1;
      FixedInt x1 = zspellEnduringSpirits.velocity.x;
      FixedInt y1 = zspellEnduringSpirits.velocity.y;
      FixedInt fixedInt3 = zspellEnduringSpirits.velocity.x;
      FixedInt fixedInt4 = zspellEnduringSpirits.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellEnduringSpirits.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellEnduringSpirits.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellEnduringSpirits.velocity.x / zspellEnduringSpirits.steps;
        fixedInt4 = zspellEnduringSpirits.velocity.y / zspellEnduringSpirits.steps;
      }
      while (zspellEnduringSpirits.steps > 0)
      {
        if (zspellEnduringSpirits.map.SpellCheckEffectors(zspellEnduringSpirits.toCollideCheck, (ZSpell) zspellEnduringSpirits, (int) zspellEnduringSpirits.validX, (int) zspellEnduringSpirits.validY))
        {
          zspellEnduringSpirits.position = new MyLocation(zspellEnduringSpirits.validX, zspellEnduringSpirits.validY);
          yield return 0.0f;
          goto label_44;
        }
        else
        {
          --zspellEnduringSpirits.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellEnduringSpirits.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellEnduringSpirits.zb.Count) - zspellEnduringSpirits.radius;
          if (num1 < 0)
            num1 += zspellEnduringSpirits.zb.Count;
          for (int index1 = 0; index1 < zspellEnduringSpirits.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellEnduringSpirits.zb.Count;
            if (!zspellEnduringSpirits.map.SpellCheckPosition((int) (fixedInt3 + zspellEnduringSpirits.pX) + zspellEnduringSpirits.zb[index2].x, (int) (fixedInt4 + zspellEnduringSpirits.pY) + zspellEnduringSpirits.zb[index2].y, zspellEnduringSpirits.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellEnduringSpirits.pX);
              int num3 = (int) (fixedInt4 + zspellEnduringSpirits.pY);
              int x2 = num2 + zspellEnduringSpirits.zb[index2].x;
              int y2 = num3 + zspellEnduringSpirits.zb[index2].y;
              if ((ZComponent) zspellEnduringSpirits.map.PhysicsCollideCreature((ZCreature) null, x2, y2, 0) == (object) null)
              {
                ++zspellEnduringSpirits.timesBounced;
                zspellEnduringSpirits.position = new MyLocation(zspellEnduringSpirits.validX, zspellEnduringSpirits.validY);
                MyLocation zero = MyLocation.zero;
                int num4 = num2 + zspellEnduringSpirits.zb[index2].x;
                int num5 = num3 + zspellEnduringSpirits.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellEnduringSpirits.map.SpellCheckPosition(num4 + index3, num5 + index4, zspellEnduringSpirits.toCollideCheck, Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                zero.Normalize();
                MyLocation.Reflect(zspellEnduringSpirits.velocity, ref zero, out zspellEnduringSpirits.velocity);
                zspellEnduringSpirits.velocity = zspellEnduringSpirits.velocity * 838860L;
                if (zspellEnduringSpirits.timesBounced == 1)
                  zspellEnduringSpirits.velocity = zspellEnduringSpirits.velocity * 524288L;
                if (zspellEnduringSpirits.game.isClient && (Object) zspellEnduringSpirits.gameObject != (Object) null)
                {
                  zspellEnduringSpirits.gameObject.GetComponent<SpriteRenderer>().color = ColorHSV.ToColor(new ColorHSV(Random.Range(0.0f, 1f), 1f, 1f));
                  goto label_41;
                }
                else
                  goto label_41;
              }
              else
              {
                zspellEnduringSpirits.position = new MyLocation(zspellEnduringSpirits.validX + fixedInt3 * zspellEnduringSpirits.steps / (FixedInt) 2621440L, zspellEnduringSpirits.validY + fixedInt4 * zspellEnduringSpirits.steps / (FixedInt) 2621440L);
                zspellEnduringSpirits.OnColoredExplosion();
                zspellEnduringSpirits.damage += 2 * (zspellEnduringSpirits.timesBounced > 3 ? 3 : zspellEnduringSpirits.timesBounced);
                zspellEnduringSpirits.MoveSurroundings(zspellEnduringSpirits.EXORADIUS + 5);
                zspellEnduringSpirits.ApplyExplosionForce(zspellEnduringSpirits.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                zspellEnduringSpirits.isDead = true;
                zspellEnduringSpirits.isNull = true;
                AudioManager.Play(zspellEnduringSpirits.explosionClip);
                ZComponent.Destroy<GameObject>(zspellEnduringSpirits.gameObject);
                yield break;
              }
            }
          }
          zspellEnduringSpirits.validX = zspellEnduringSpirits.pX;
          zspellEnduringSpirits.validY = zspellEnduringSpirits.pY;
          zspellEnduringSpirits.pX = zspellEnduringSpirits.pX + fixedInt3;
          zspellEnduringSpirits.pY = zspellEnduringSpirits.pY + fixedInt4;
        }
      }
      zspellEnduringSpirits.position = zspellEnduringSpirits.position + zspellEnduringSpirits.velocity;
      if (zspellEnduringSpirits.position.y < zspellEnduringSpirits.radius)
      {
        zspellEnduringSpirits.moving = (IEnumerator<float>) null;
        zspellEnduringSpirits.velocity = MyLocation.zero;
        zspellEnduringSpirits.isMoving = false;
        zspellEnduringSpirits.isDead = true;
        zspellEnduringSpirits.isNull = true;
        zspellEnduringSpirits.Splash();
        ZComponent.Destroy<GameObject>(zspellEnduringSpirits.gameObject);
        break;
      }
      if (zspellEnduringSpirits.addVelocity)
      {
        zspellEnduringSpirits.addVelocity = false;
        zspellEnduringSpirits.velocity = zspellEnduringSpirits.velocity + zspellEnduringSpirits.addedVelocity;
        zspellEnduringSpirits.velocity.x = Mathd.Clamp(zspellEnduringSpirits.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellEnduringSpirits.velocity.y = Mathd.Clamp(zspellEnduringSpirits.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellEnduringSpirits.ResetAddedVelocity();
      }
      else if (zspellEnduringSpirits.affectedByGravity && zspellEnduringSpirits.velocity.y > -ZMap.MaxSpeed)
        zspellEnduringSpirits.velocity.y += zspellEnduringSpirits.map.Gravity;
      else if (!zspellEnduringSpirits.affectedByGravity && zspellEnduringSpirits.velocity.y > -10 && zspellEnduringSpirits.maxDuration > 150)
        zspellEnduringSpirits.affectedByGravity = true;
      zspellEnduringSpirits.Wind();
label_41:
      ++zspellEnduringSpirits.curDuration;
      zspellEnduringSpirits.Undie();
      if (zspellEnduringSpirits.curDuration >= zspellEnduringSpirits.maxDuration || zspellEnduringSpirits.timesBounced >= zspellEnduringSpirits.Bounces)
      {
        zspellEnduringSpirits.OnColoredExplosion();
        zspellEnduringSpirits.ApplyExplosionForce(zspellEnduringSpirits.position, 0, true, (ISpellBridge) null, (ZCreature) null);
        zspellEnduringSpirits.isDead = true;
        zspellEnduringSpirits.isNull = true;
        AudioManager.Play(zspellEnduringSpirits.explosionClip);
        ZComponent.Destroy<GameObject>(zspellEnduringSpirits.gameObject);
        break;
      }
      yield return 0.0f;
    }
  }

  public void OnColoredExplosion()
  {
    this.map.ServerBitBlt((int) this.explosionCutout, (int) this.position.x, (int) this.position.y, true, true);
    if (!this.game.isClient || this.game.resyncing || (!((Object) this.explosion != (Object) null) || !((Object) this.gameObject != (Object) null)))
      return;
    ZComponent.Instantiate<GameObject>(this.explosion, this.position.ToSinglePrecision(), Quaternion.identity).GetComponent<SpriteRenderer>().color = this.gameObject.GetComponent<SpriteRenderer>().color;
  }
}
