
using System.Collections.Generic;

public class ZSpellClockworkBomb : ZSpell
{
  public void Activate()
  {
    this.game.forceRysncPause = true;
    ZEffector effector = this.effector;
    effector.game = this.game;
    effector.position = this.position;
    effector.collider = this.collider;
    effector.collider.effector = effector;
    effector.collider.spell = (ZSpell) this;
    this.collider.world = this.game.world;
    this.collider.Enable(this.position);
    if (!((ZComponent) effector.whoSummoned == (object) null) || !((ZComponent) this.parent != (object) null) || this.Bounces > 0)
      return;
    this.Bounces = 1;
    effector.active = false;
    effector.whoSummoned = this.parent;
    this.game.globalEffectors.Add(effector);
  }

  public MyLocation SetPosition
  {
    set
    {
      this.position = value;
      this.collider?.Move(value);
    }
  }

  public ZMyCollider toCollideCheck2()
  {
    if (this.curDuration > 3)
      return this.collider;
    return this.parent?.colliderGameObject;
  }

  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellClockworkBomb zspellClockworkBomb = this;
    zspellClockworkBomb.isMoving = true;
    zspellClockworkBomb.zb = MapGenerator.getOutlineArray(zspellClockworkBomb.radius);
    zspellClockworkBomb.effector.game = zspellClockworkBomb.game;
    zspellClockworkBomb.collider.world = zspellClockworkBomb.game.world;
    if (zspellClockworkBomb.curDuration <= 3)
      zspellClockworkBomb.collider.Disable(false);
    if (gotoStatic)
      yield return 0.0f;
label_50:
    while (!zspellClockworkBomb.isDead)
    {
      zspellClockworkBomb.pX = zspellClockworkBomb.position.x;
      zspellClockworkBomb.pY = zspellClockworkBomb.position.y;
      FixedInt fixedInt1 = zspellClockworkBomb.position.x + zspellClockworkBomb.velocity.x;
      FixedInt fixedInt2 = zspellClockworkBomb.position.y + zspellClockworkBomb.velocity.y;
      zspellClockworkBomb.validX = zspellClockworkBomb.pX;
      zspellClockworkBomb.validY = zspellClockworkBomb.pY;
      zspellClockworkBomb.steps = 1;
      FixedInt x = zspellClockworkBomb.velocity.x;
      FixedInt y = zspellClockworkBomb.velocity.y;
      FixedInt fixedInt3 = zspellClockworkBomb.velocity.x;
      FixedInt fixedInt4 = zspellClockworkBomb.velocity.y;
      if (x > 1 || x < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x) > FixedInt.Abs(y))
          zspellClockworkBomb.steps = (int) FixedInt.Abs(x) + 1;
        else
          zspellClockworkBomb.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellClockworkBomb.velocity.x / zspellClockworkBomb.steps;
        fixedInt4 = zspellClockworkBomb.velocity.y / zspellClockworkBomb.steps;
      }
      while (zspellClockworkBomb.steps > 0)
      {
        if (zspellClockworkBomb.map.SpellCheckEffectors(zspellClockworkBomb.toCollideCheck, (ZSpell) zspellClockworkBomb, (int) zspellClockworkBomb.validX, (int) zspellClockworkBomb.validY))
        {
          zspellClockworkBomb.SetPosition = new MyLocation(zspellClockworkBomb.validX, zspellClockworkBomb.validY);
          yield return 0.0f;
          goto label_50;
        }
        else
        {
          --zspellClockworkBomb.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellClockworkBomb.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellClockworkBomb.zb.Count) - zspellClockworkBomb.radius;
          if (num1 < 0)
            num1 += zspellClockworkBomb.zb.Count;
          for (int index1 = 0; index1 < zspellClockworkBomb.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellClockworkBomb.zb.Count;
            if (!zspellClockworkBomb.map.SpellCheckPositionIgnoreSelf((int) (fixedInt3 + zspellClockworkBomb.pX) + zspellClockworkBomb.zb[index2].x, (int) (fixedInt4 + zspellClockworkBomb.pY) + zspellClockworkBomb.zb[index2].y, zspellClockworkBomb.toCollideCheck2(), Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellClockworkBomb.pX);
              int num3 = (int) (fixedInt4 + zspellClockworkBomb.pY);
              if (!zspellClockworkBomb.explodeOnImpact || zspellClockworkBomb.velocity.y > 0)
              {
                zspellClockworkBomb.SetPosition = new MyLocation(zspellClockworkBomb.validX, zspellClockworkBomb.validY);
                MyLocation zero = MyLocation.zero;
                int num4 = num2 + zspellClockworkBomb.zb[index2].x;
                int num5 = num3 + zspellClockworkBomb.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellClockworkBomb.map.SpellCheckPositionIgnoreSelf(num4 + index3, num5 + index4, zspellClockworkBomb.toCollideCheck2(), Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                zero.Normalize();
                MyLocation.Reflect(zspellClockworkBomb.velocity, ref zero, out zspellClockworkBomb.velocity);
                zspellClockworkBomb.velocity = zspellClockworkBomb.velocity * zspellClockworkBomb.elasticity;
                if (MyLocation.Distance(MyLocation.zero, zspellClockworkBomb.velocity) <= 1 && !zspellClockworkBomb.ShouldSpellFall(false))
                {
                  zspellClockworkBomb.isMoving = false;
                  zspellClockworkBomb.moving = (IEnumerator<float>) null;
                  zspellClockworkBomb.velocity.y = (FixedInt) 0;
                  zspellClockworkBomb.velocity.x = (FixedInt) 0;
                  zspellClockworkBomb.Activate();
                  yield break;
                }
                else if (zspellClockworkBomb.game.isClient)
                {
                  AudioManager.Play(AudioManager.instance.spellBounce);
                  goto label_43;
                }
                else
                  goto label_43;
              }
              else
              {
                zspellClockworkBomb.SetPosition = new MyLocation(zspellClockworkBomb.validX, zspellClockworkBomb.validY);
                zspellClockworkBomb.moving = (IEnumerator<float>) null;
                zspellClockworkBomb.isMoving = false;
                zspellClockworkBomb.velocity.y = (FixedInt) 0;
                zspellClockworkBomb.velocity.x = (FixedInt) 0;
                zspellClockworkBomb.Activate();
                yield break;
              }
            }
          }
          zspellClockworkBomb.validX = zspellClockworkBomb.pX;
          zspellClockworkBomb.validY = zspellClockworkBomb.pY;
          zspellClockworkBomb.pX = zspellClockworkBomb.pX + fixedInt3;
          zspellClockworkBomb.pY = zspellClockworkBomb.pY + fixedInt4;
        }
      }
      MyLocation position = zspellClockworkBomb.position;
      zspellClockworkBomb.SetPosition = zspellClockworkBomb.position + zspellClockworkBomb.velocity;
      zspellClockworkBomb.game.CreatureMoveSurroundings(position, zspellClockworkBomb.radius, (ZMyCollider) null, false);
      if (zspellClockworkBomb.position.y < zspellClockworkBomb.radius)
      {
        zspellClockworkBomb.moving = (IEnumerator<float>) null;
        zspellClockworkBomb.isMoving = false;
        zspellClockworkBomb.velocity = MyLocation.zero;
        zspellClockworkBomb.Splash();
        zspellClockworkBomb.effector?.SetNull();
        zspellClockworkBomb.DestroyDelay();
        break;
      }
      if (zspellClockworkBomb.addVelocity)
      {
        zspellClockworkBomb.addVelocity = false;
        zspellClockworkBomb.velocity = zspellClockworkBomb.velocity + zspellClockworkBomb.addedVelocity;
        zspellClockworkBomb.velocity.x = Mathd.Clamp(zspellClockworkBomb.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellClockworkBomb.velocity.y = Mathd.Clamp(zspellClockworkBomb.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellClockworkBomb.addedVelocity.x = (FixedInt) 0;
        zspellClockworkBomb.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellClockworkBomb.velocity.y > -ZMap.MaxSpeed)
        zspellClockworkBomb.velocity.y += zspellClockworkBomb.map.Gravity;
      zspellClockworkBomb.Wind();
label_43:
      ++zspellClockworkBomb.curDuration;
      if (zspellClockworkBomb.curDuration >= zspellClockworkBomb.maxDuration)
      {
        zspellClockworkBomb.Explode();
        zspellClockworkBomb.ApplyExplosionForce(zspellClockworkBomb.position + zspellClockworkBomb.addedDeathVector, 0, true, (ISpellBridge) null, (ZCreature) null);
        zspellClockworkBomb.effector?.SetNull();
        zspellClockworkBomb.DestroyDelay();
        break;
      }
      if (zspellClockworkBomb.curDuration > 150)
        zspellClockworkBomb.explodeOnImpact = true;
      yield return 0.0f;
    }
  }
}
