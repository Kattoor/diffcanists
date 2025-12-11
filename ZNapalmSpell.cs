
using System.Collections.Generic;
using UnityEngine;

public class ZNapalmSpell : ZSpell
{
  public override void OnDeath(bool playDeathClip = true)
  {
    this.game.forceRysncPause = true;
    if (ZComponent.IsNull((ZComponent) this))
      return;
    this.isDead = true;
    this.isNull = true;
    AudioManager.PlayNapalm(this.explosionClip);
    ZMyCollider collider = this.collider;
    if ((ZComponent) collider != (object) null && collider.enabled)
      collider.Disable(true);
    this.DestroyDelay();
  }

  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZNapalmSpell znapalmSpell = this;
    znapalmSpell.isMoving = true;
    znapalmSpell.zb = MapGenerator.getOutlineArray(znapalmSpell.radius);
    ZMyCollider col = znapalmSpell.collider;
    col.Disable(false);
    col.world = znapalmSpell.world;
    col.spell = (ZSpell) znapalmSpell;
    ZEffector effector = znapalmSpell.effector;
    effector.position = znapalmSpell.position;
    effector.collider = col;
    col.effector = effector;
    if (gotoStatic)
      yield return 0.0f;
label_49:
    while (!znapalmSpell.isDead)
    {
      znapalmSpell.pX = znapalmSpell.position.x;
      znapalmSpell.pY = znapalmSpell.position.y;
      FixedInt fixedInt1 = znapalmSpell.position.x + znapalmSpell.velocity.x;
      FixedInt fixedInt2 = znapalmSpell.position.y + znapalmSpell.velocity.y;
      znapalmSpell.validX = znapalmSpell.pX;
      znapalmSpell.validY = znapalmSpell.pY;
      znapalmSpell.steps = 1;
      FixedInt x1 = znapalmSpell.velocity.x;
      FixedInt y1 = znapalmSpell.velocity.y;
      FixedInt fixedInt3 = znapalmSpell.velocity.x;
      FixedInt fixedInt4 = znapalmSpell.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          znapalmSpell.steps = (int) FixedInt.Abs(x1) + 1;
        else
          znapalmSpell.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = znapalmSpell.velocity.x / znapalmSpell.steps;
        fixedInt4 = znapalmSpell.velocity.y / znapalmSpell.steps;
      }
      while (znapalmSpell.steps > 0)
      {
        if (znapalmSpell.map.SpellCheckEffectors(znapalmSpell.toCollideCheck, (ZSpell) znapalmSpell, (int) znapalmSpell.validX, (int) znapalmSpell.validY))
        {
          znapalmSpell.position = new MyLocation(znapalmSpell.validX, znapalmSpell.validY);
          yield return 0.0f;
          goto label_49;
        }
        else
        {
          --znapalmSpell.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(znapalmSpell.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * znapalmSpell.zb.Count) - znapalmSpell.radius;
          if (num1 < 0)
            num1 += znapalmSpell.zb.Count;
          for (int index1 = 0; index1 < znapalmSpell.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % znapalmSpell.zb.Count;
            int num2 = (int) (fixedInt3 + znapalmSpell.pX);
            int num3 = (int) (fixedInt4 + znapalmSpell.pY);
            if (!znapalmSpell.map.SpellCheckPosition(num2 + znapalmSpell.zb[index2].x, num3 + znapalmSpell.zb[index2].y, znapalmSpell.toCollideCheck, Inert.mask_spell_movement))
            {
              int x2 = num2 + znapalmSpell.zb[index2].x;
              int y2 = num3 + znapalmSpell.zb[index2].y;
              if (!znapalmSpell.map.CheckPositionOnlyMap(x2, y2))
              {
                if (!znapalmSpell.explodeOnImpact)
                {
                  AudioManager.PlayNapalm(znapalmSpell.explosionClip);
                  znapalmSpell.explodeOnImpact = true;
                  znapalmSpell.position = new MyLocation(znapalmSpell.validX, znapalmSpell.validY);
                  MyLocation zero = MyLocation.zero;
                  int num4 = num2 + znapalmSpell.zb[index2].x;
                  int num5 = num3 + znapalmSpell.zb[index2].y;
                  for (int index3 = -2; index3 <= 2; ++index3)
                  {
                    for (int index4 = -2; index4 <= 2; ++index4)
                    {
                      if (znapalmSpell.map.SpellCheckPosition(num4 + index3, num5 + index4, znapalmSpell.toCollideCheck, Inert.mask_movement_NoEffector))
                      {
                        zero.x += index3;
                        zero.y += index4;
                      }
                    }
                  }
                  zero.Normalize();
                  MyLocation.Reflect(znapalmSpell.velocity, ref zero, out znapalmSpell.velocity);
                  znapalmSpell.velocity = znapalmSpell.velocity * znapalmSpell.elasticity;
                  znapalmSpell.map.ServerBitBlt((int) znapalmSpell.explosionCutout, x2, y2, true, true);
                  znapalmSpell.MoveSurroundings(znapalmSpell.EXORADIUS + 5);
                  if (znapalmSpell.game.isClient && (Object) znapalmSpell.transform != (Object) null)
                  {
                    znapalmSpell.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                    znapalmSpell.gameObject.GetComponent<ParticleSystem>().Play();
                  }
                  znapalmSpell.EXORADIUS += 12;
                  if (znapalmSpell.ApplyExplosionForce(znapalmSpell.position, 0, true, (ISpellBridge) null, (ZCreature) null))
                  {
                    znapalmSpell.velocity.y = (FixedInt) 0;
                    znapalmSpell.velocity.x = (FixedInt) 0;
                    znapalmSpell.position = new MyLocation(znapalmSpell.validX, znapalmSpell.validY);
                    znapalmSpell.moving = (IEnumerator<float>) null;
                    znapalmSpell.isMoving = false;
                    znapalmSpell.OnDeath(true);
                    yield break;
                  }
                  else
                  {
                    znapalmSpell.EXORADIUS -= 12;
                    znapalmSpell.Undie();
                    goto label_46;
                  }
                }
                else if (znapalmSpell.ShouldSpellFall(false))
                {
                  znapalmSpell.velocity.y = (FixedInt) -1;
                  znapalmSpell.velocity.x = (FixedInt) 0;
                }
                else
                {
                  znapalmSpell.velocity.y = (FixedInt) 0;
                  znapalmSpell.velocity.x = (FixedInt) 0;
                  znapalmSpell.position = new MyLocation(znapalmSpell.validX, znapalmSpell.validY);
                  znapalmSpell.moving = (IEnumerator<float>) null;
                  znapalmSpell.isMoving = false;
                  col.Enable(znapalmSpell.position);
                  znapalmSpell.explisiveForce = (FixedInt) 5;
                  znapalmSpell.game.forceRysncPause = true;
                  yield break;
                }
              }
              else
              {
                znapalmSpell.velocity.y = (FixedInt) 0;
                znapalmSpell.velocity.x = (FixedInt) 0;
                znapalmSpell.position = new MyLocation(znapalmSpell.validX, znapalmSpell.validY);
                znapalmSpell.moving = (IEnumerator<float>) null;
                znapalmSpell.isMoving = false;
                znapalmSpell.map.ServerBitBlt(0, x2, y2, true, true);
                znapalmSpell.ApplyExplosionForce(znapalmSpell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
                znapalmSpell.OnDeath(true);
                yield break;
              }
            }
          }
          znapalmSpell.validX = znapalmSpell.pX;
          znapalmSpell.validY = znapalmSpell.pY;
          znapalmSpell.pX = znapalmSpell.pX + fixedInt3;
          znapalmSpell.pY = znapalmSpell.pY + fixedInt4;
        }
      }
      znapalmSpell.position = znapalmSpell.position + znapalmSpell.velocity;
      if (znapalmSpell.position.y < znapalmSpell.radius)
      {
        znapalmSpell.moving = (IEnumerator<float>) null;
        znapalmSpell.velocity = MyLocation.zero;
        znapalmSpell.isMoving = false;
        znapalmSpell.DestroyDelay();
        break;
      }
      if (znapalmSpell.addVelocity)
      {
        znapalmSpell.addVelocity = false;
        znapalmSpell.velocity = znapalmSpell.velocity + znapalmSpell.addedVelocity;
        znapalmSpell.velocity.x = Mathd.Clamp(znapalmSpell.velocity.x, (FixedInt) -50, (FixedInt) 50);
        znapalmSpell.velocity.y = Mathd.Clamp(znapalmSpell.velocity.y, (FixedInt) -50, (FixedInt) 50);
        znapalmSpell.ResetAddedVelocity();
      }
      else if (znapalmSpell.affectedByGravity && znapalmSpell.velocity.y > -ZMap.MaxSpeed)
        znapalmSpell.velocity.y += znapalmSpell.map.Gravity;
      else if (!znapalmSpell.affectedByGravity && znapalmSpell.velocity.y > -10 && znapalmSpell.maxDuration > 150)
        znapalmSpell.affectedByGravity = true;
      znapalmSpell.Wind();
label_46:
      ++znapalmSpell.curDuration;
      if (znapalmSpell.curDuration >= znapalmSpell.maxDuration)
      {
        znapalmSpell.DestroyDelay();
        break;
      }
      yield return 0.0f;
    }
  }
}
