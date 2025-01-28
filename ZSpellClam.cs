
using System.Collections.Generic;

public class ZSpellClam : ZSpell
{
  private FixedInt minY = (FixedInt) 100000;

  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellClam zspellClam = this;
    zspellClam.isMoving = true;
    zspellClam.zb = MapGenerator.getOutlineArray(zspellClam.radius);
    bool locked = false;
    int bounces = 0;
    if (gotoStatic)
      yield return 0.0f;
label_44:
    while (!zspellClam.isDead)
    {
      zspellClam.pX = zspellClam.position.x;
      zspellClam.pY = zspellClam.position.y;
      FixedInt fixedInt1 = zspellClam.position.x + zspellClam.velocity.x;
      FixedInt fixedInt2 = zspellClam.position.y + zspellClam.velocity.y;
      zspellClam.validX = zspellClam.pX;
      zspellClam.validY = zspellClam.pY;
      zspellClam.steps = 1;
      FixedInt x = zspellClam.velocity.x;
      FixedInt y = zspellClam.velocity.y;
      FixedInt fixedInt3 = zspellClam.velocity.x;
      FixedInt fixedInt4 = zspellClam.velocity.y;
      if (x > 1 || x < -1 || (y > 1 || y < -1))
      {
        if (FixedInt.Abs(x) > FixedInt.Abs(y))
          zspellClam.steps = (int) FixedInt.Abs(x) + 1;
        else
          zspellClam.steps = (int) FixedInt.Abs(y) + 1;
        fixedInt3 = zspellClam.velocity.x / zspellClam.steps;
        fixedInt4 = zspellClam.velocity.y / zspellClam.steps;
      }
      while (zspellClam.steps > 0)
      {
        if (zspellClam.map.SpellCheckEffectors(zspellClam.toCollideCheck, (ZSpell) zspellClam, (int) zspellClam.validX, (int) zspellClam.validY))
        {
          zspellClam.position = new MyLocation(zspellClam.validX, zspellClam.validY);
          yield return 0.0f;
          goto label_44;
        }
        else
        {
          --zspellClam.steps;
          int num1 = (int) (((FixedInt) 360 - (Inert.AngleOfVelocity(zspellClam.velocity) - 90)) * FixedInt.ThreeSixtyBy1 * zspellClam.zb.Count) - zspellClam.radius;
          if (num1 < 0)
            num1 += zspellClam.zb.Count;
          for (int index1 = 0; index1 < zspellClam.radius * 2; ++index1)
          {
            int index2 = (index1 + num1) % zspellClam.zb.Count;
            if (!zspellClam.map.SpellCheckPosition((int) (fixedInt3 + zspellClam.pX) + zspellClam.zb[index2].x, (int) (fixedInt4 + zspellClam.pY) + zspellClam.zb[index2].y, zspellClam.toCollideCheck, Inert.mask_spell_movement))
            {
              int num2 = (int) (fixedInt3 + zspellClam.pX);
              int num3 = (int) (fixedInt4 + zspellClam.pY);
              if (zspellClam.position.y < zspellClam.minY || bounces < 5 && zspellClam.map.SpellCheckPositionEntities(num2 + zspellClam.zb[index2].x, num3 + zspellClam.zb[index2].y, zspellClam.toCollideCheck, Inert.mask_spell_movement))
              {
                ++bounces;
                zspellClam.position = new MyLocation(zspellClam.validX, zspellClam.validY);
                MyLocation zero = MyLocation.zero;
                int num4 = num2 + zspellClam.zb[index2].x;
                int num5 = num3 + zspellClam.zb[index2].y;
                for (int index3 = -2; index3 <= 2; ++index3)
                {
                  for (int index4 = -2; index4 <= 2; ++index4)
                  {
                    if (zspellClam.map.SpellCheckPosition(num4 + index3, num5 + index4, zspellClam.toCollideCheck, Inert.mask_movement_NoEffector))
                    {
                      zero.x += index3;
                      zero.y += index4;
                    }
                  }
                }
                if (locked)
                {
                  zspellClam.velocity.y = (FixedInt) 6;
                  zspellClam.velocity.x = (FixedInt) 0;
                  zspellClam.minY = zspellClam.position.y - 15;
                }
                else
                {
                  zspellClam.affectedByGravity = true;
                  zero.Normalize();
                  MyLocation.Reflect(zspellClam.velocity, ref zero, out zspellClam.velocity);
                  zspellClam.velocity = zspellClam.velocity * zspellClam.elasticity;
                  locked = true;
                }
                zspellClam.map.ServerBitBlt(18, (int) zspellClam.validX, (int) zspellClam.validY, true, true);
                zspellClam.MoveSurroundings(25);
                if (zspellClam.game.isClient)
                {
                  zspellClam.gameObject.GetComponent<AnimateRepeat>().enabled = true;
                  goto label_41;
                }
                else
                  goto label_41;
              }
            }
          }
          zspellClam.validX = zspellClam.pX;
          zspellClam.validY = zspellClam.pY;
          zspellClam.pX = zspellClam.pX + fixedInt3;
          zspellClam.pY = zspellClam.pY + fixedInt4;
        }
      }
      zspellClam.position = zspellClam.position + zspellClam.velocity;
      if (zspellClam.position.y < zspellClam.radius)
      {
        zspellClam.moving = (IEnumerator<float>) null;
        zspellClam.velocity = MyLocation.zero;
        zspellClam.isMoving = false;
        zspellClam.Splash();
        zspellClam.OnDeath(true);
        break;
      }
      if (zspellClam.addVelocity)
      {
        zspellClam.addVelocity = false;
        zspellClam.velocity = zspellClam.velocity + zspellClam.addedVelocity;
        zspellClam.velocity.x = Mathd.Clamp(zspellClam.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellClam.velocity.y = Mathd.Clamp(zspellClam.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellClam.addedVelocity.x = (FixedInt) 0;
        zspellClam.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellClam.affectedByGravity && zspellClam.velocity.y > -ZMap.MaxSpeed)
        zspellClam.velocity.y += zspellClam.map.Gravity;
      else if (!zspellClam.affectedByGravity && zspellClam.velocity.y > -10 && zspellClam.maxDuration > 150)
        zspellClam.affectedByGravity = true;
      zspellClam.Wind();
label_41:
      ++zspellClam.curDuration;
      if (zspellClam.curDuration >= zspellClam.maxDuration)
      {
        zspellClam.OnDeath(true);
        break;
      }
      yield return 0.0f;
    }
  }
}
