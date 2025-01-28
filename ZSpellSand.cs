
using System.Collections.Generic;
using UnityEngine;

public class ZSpellSand : ZSpell
{
  public Color32 color = (Color32) new Color(0.7372549f, 0.6745098f, 0.4862745f);

  public void Blit()
  {
    if (!this.map.CheckPositionOnlyEntities((int) this.position.x, (int) this.position.y, (ZCreature) null, 8448))
      return;
    this.map.BitBlt(this.color, (int) this.position.x, (int) this.position.y);
  }

  public override void OnDeath(bool playDeathClip = true)
  {
    if (ZComponent.IsNull((ZComponent) this))
      return;
    this.isDead = true;
    this.isNull = true;
    AudioManager.Play(this.explosionClip);
    this.Blit();
    ZComponent.Destroy<GameObject>(this.gameObject);
  }

  public override IEnumerator<float> SpellMove(bool gotoStatic = false, bool checkEffectors = true)
  {
    ZSpellSand zspellSand = this;
    zspellSand.isMoving = true;
    zspellSand.zb = MapGenerator.getOutlineArray(zspellSand.radius);
    if (gotoStatic)
      yield return 0.0f;
label_2:
    int collisionFrame = 2;
    if (zspellSand.game.isClient)
    {
      zspellSand.color = Color32.Lerp(SpellSand.color1, SpellSand.color2, Random.Range(0.0f, 1f));
      zspellSand.clientObj.GetComponent<SpriteRenderer>().color = (Color) zspellSand.color;
    }
    while (!zspellSand.isDead)
    {
      zspellSand.pX = zspellSand.position.x;
      zspellSand.pY = zspellSand.position.y;
      FixedInt fixedInt1 = zspellSand.position.x + zspellSand.velocity.x;
      FixedInt fixedInt2 = zspellSand.position.y + zspellSand.velocity.y;
      zspellSand.validX = zspellSand.pX;
      zspellSand.validY = zspellSand.pY;
      zspellSand.steps = 1;
      FixedInt x1 = zspellSand.velocity.x;
      FixedInt y1 = zspellSand.velocity.y;
      FixedInt fixedInt3 = zspellSand.velocity.x;
      FixedInt fixedInt4 = zspellSand.velocity.y;
      if (x1 > 1 || x1 < -1 || (y1 > 1 || y1 < -1))
      {
        if (FixedInt.Abs(x1) > FixedInt.Abs(y1))
          zspellSand.steps = (int) FixedInt.Abs(x1) + 1;
        else
          zspellSand.steps = (int) FixedInt.Abs(y1) + 1;
        fixedInt3 = zspellSand.velocity.x / zspellSand.steps;
        fixedInt4 = zspellSand.velocity.y / zspellSand.steps;
      }
      while (zspellSand.steps > 0)
      {
        if (zspellSand.map.SpellCheckEffectors(zspellSand.toCollideCheck, (ZSpell) zspellSand, (int) zspellSand.validX, (int) zspellSand.validY))
        {
          zspellSand.position = new MyLocation(zspellSand.validX, zspellSand.validY);
          yield return 0.0f;
          goto label_2;
        }
        else
        {
          zspellSand.steps = 0;
          int x2 = (int) (zspellSand.velocity.x + zspellSand.pX);
          int y2 = (int) (zspellSand.velocity.y + zspellSand.pY);
          if ((zspellSand.curDuration > collisionFrame ? (!zspellSand.map.SpellCheckPosition(x2, y2, zspellSand.toCollideCheck, Inert.mask_spell_movement) ? 1 : 0) : (!zspellSand.map.CheckPositionOnlyMap(x2, y2) ? 1 : 0)) != 0)
          {
            ZCreature zcreature = zspellSand.map.PhysicsCollideCreature(zspellSand.toCollideCheck, x2, y2, 0);
            if ((ZComponent) zcreature != (object) null && typeof (ZCreatureThorn) != zcreature.GetType())
            {
              zspellSand.velocity.y = (FixedInt) 0;
              zspellSand.velocity.x = (FixedInt) 0;
              zspellSand.addedDeathVector = Inert.Velocity(Inert.AngleOfVelocity(zspellSand.velocity), zspellSand.radius);
              zspellSand.position = new MyLocation(zspellSand.validX, zspellSand.validY);
              zspellSand.moving = (IEnumerator<float>) null;
              zspellSand.isMoving = false;
              zcreature.ApplyDamage(zspellSand.spellEnum, zspellSand.damageType, zspellSand.damage, zspellSand.parent, zspellSand.game.turn, (ISpellBridge) zspellSand, false);
              if ((Object) zspellSand.explosion != (Object) null)
                zspellSand.OnExplosion();
              ZComponent.Destroy<GameObject>(zspellSand.gameObject);
              zspellSand.isDead = true;
              zspellSand.isNull = true;
              yield break;
            }
            else
            {
              int validX = (int) zspellSand.validX;
              int yInt = (int) zspellSand.validY + 1;
              int num1 = 1000;
              int num2 = 0;
              while (num1 > 0)
              {
                if (zspellSand.map.SpellCheckPosition(validX, yInt - 1, zspellSand.toCollideCheck, Inert.mask_spell_movement))
                {
                  --yInt;
                  ++num2;
                }
                else if (zspellSand.map.SpellCheckPosition(validX - 1, yInt - 1, zspellSand.toCollideCheck, Inert.mask_spell_movement))
                {
                  --yInt;
                  --validX;
                  num2 = 0;
                }
                else if (zspellSand.map.SpellCheckPosition(validX + 1, yInt - 1, zspellSand.toCollideCheck, Inert.mask_spell_movement))
                {
                  --yInt;
                  ++validX;
                  num2 = 0;
                }
                else
                  break;
                --num1;
                if (num1 < 995)
                {
                  zspellSand.position = new MyLocation(validX, yInt);
                  zspellSand.velocity.x = (FixedInt) 0;
                  zspellSand.velocity.y = (FixedInt) -5;
                  goto label_31;
                }
              }
              zspellSand.position = new MyLocation(validX, yInt);
              zspellSand.OnDeath(true);
              yield break;
            }
          }
          else
          {
            zspellSand.validX = zspellSand.pX;
            zspellSand.validY = zspellSand.pY;
            zspellSand.pX = zspellSand.pX + fixedInt3;
            zspellSand.pY = zspellSand.pY + fixedInt4;
          }
        }
      }
      zspellSand.position = zspellSand.position + zspellSand.velocity;
label_31:
      if (zspellSand.position.y < zspellSand.radius)
      {
        zspellSand.moving = (IEnumerator<float>) null;
        zspellSand.velocity = MyLocation.zero;
        zspellSand.isMoving = false;
        zspellSand.Splash();
        if (zspellSand.spellEnum != SpellEnum.Brine_Bolt)
          zspellSand.OnDeath(true);
        else
          ZComponent.Destroy<GameObject>(zspellSand.gameObject);
        zspellSand.isDead = true;
        zspellSand.isNull = true;
        break;
      }
      if (zspellSand.addVelocity)
      {
        zspellSand.addVelocity = false;
        zspellSand.velocity = zspellSand.velocity + zspellSand.addedVelocity;
        zspellSand.velocity.x = Mathd.Clamp(zspellSand.velocity.x, (FixedInt) -50, (FixedInt) 50);
        zspellSand.velocity.y = Mathd.Clamp(zspellSand.velocity.y, (FixedInt) -50, (FixedInt) 50);
        zspellSand.addedVelocity.x = (FixedInt) 0;
        zspellSand.addedVelocity.y = (FixedInt) 0;
      }
      else if (zspellSand.affectedByGravity && zspellSand.velocity.y > -ZMap.MaxSpeed)
        zspellSand.velocity.y += zspellSand.map.Gravity;
      else if (!zspellSand.affectedByGravity && zspellSand.velocity.y > -10 && (zspellSand.maxDuration > 150 && zspellSand.curDuration > 10))
        zspellSand.affectedByGravity = true;
      zspellSand.Wind();
      ++zspellSand.curDuration;
      if (zspellSand.curDuration >= zspellSand.maxDuration)
      {
        zspellSand.isDead = true;
        zspellSand.isNull = true;
        if ((Object) zspellSand.explosion != (Object) null)
          zspellSand.OnExplosion();
        ZComponent.Destroy<GameObject>(zspellSand.gameObject);
        break;
      }
      yield return 0.0f;
    }
  }

  public static void Blit(ZMap map, Color32 color, int x, int y)
  {
    map.BitBltDelay(color, x, y);
    map.BitBltDelay(color, x - 1, y);
    map.BitBltDelay(color, x + 1, y);
    map.BitBltDelay(color, x, y + 1);
  }

  public static void Blit(ZMap map, MyLocation position, Color32 color, ZCreature parent)
  {
    if (!map.CheckPositionOnlyEntities((int) position.x, (int) position.y - 1, (ZCreature) null, 256))
      return;
    int x = (int) position.x;
    int y = (int) position.y;
    ZSpellSand.Blit(map, color, x, y);
    map._pastBits.Add(new PastBlits()
    {
      index = -1,
      x = x,
      y = y
    });
  }

  public static IEnumerator<float> SandMove(
    Spell spell,
    ZGame game,
    ZCreature parent,
    MyLocation position,
    MyLocation velocity)
  {
    int collisionFrame = 0;
    bool isDead = false;
    int curDuration = 0;
    ZMap map = game.map;
    ZCreature toCollideCheck = parent;
    while (!isDead)
    {
      FixedInt x1 = position.x;
      FixedInt y1 = position.y;
      FixedInt fixedInt1 = position.x + velocity.x;
      FixedInt fixedInt2 = position.y + velocity.y;
      FixedInt x2 = x1;
      FixedInt y2 = y1;
      int num1 = 1;
      FixedInt x3 = velocity.x;
      FixedInt y3 = velocity.y;
      FixedInt fixedInt3 = velocity.x;
      FixedInt fixedInt4 = velocity.y;
      if (x3 > 1 || x3 < -1 || (y3 > 1 || y3 < -1))
      {
        num1 = !(FixedInt.Abs(x3) > FixedInt.Abs(y3)) ? (int) FixedInt.Abs(y3) + 1 : (int) FixedInt.Abs(x3) + 1;
        fixedInt3 = velocity.x / num1;
        fixedInt4 = velocity.y / num1;
      }
      while (num1 > 0)
      {
        if (curDuration == 2)
          toCollideCheck = (ZCreature) null;
        num1 = 0;
        int x4 = (int) (velocity.x + x1);
        int y4 = (int) (velocity.y + y1);
        if ((curDuration > collisionFrame ? (!map.SpellCheckPosition(x4, y4, toCollideCheck, Inert.mask_spell_movement) ? 1 : 0) : (!map.CheckPositionOnlyMap(x4, y4) ? 1 : 0)) != 0)
        {
          ZCreature zcreature = map.PhysicsCollideCreature(toCollideCheck, x4, y4, 0);
          if ((ZComponent) zcreature != (object) null && typeof (ZCreatureThorn) != zcreature.GetType())
          {
            velocity.y = (FixedInt) 0;
            velocity.x = (FixedInt) 0;
            position = new MyLocation(x2, y2);
            zcreature.ApplyDamage(spell.spellEnum, spell.damageType, 1, parent, game.turn, (ISpellBridge) spell, false);
            yield break;
          }
          else
          {
            int num2 = (int) x2;
            int yInt = (int) y2 + 1;
            int num3 = 1000;
            int num4 = 0;
            while (num3 > 0 && yInt > 0)
            {
              if (map.SpellCheckPosition(num2, yInt - 1, toCollideCheck, Inert.mask_spell_movement))
              {
                --yInt;
                ++num4;
              }
              else if (map.SpellCheckPosition(num2 - 1, yInt - 1, toCollideCheck, Inert.mask_spell_movement))
              {
                --yInt;
                --num2;
                num4 = 0;
              }
              else if (map.SpellCheckPosition(num2 + 1, yInt - 1, toCollideCheck, Inert.mask_spell_movement))
              {
                --yInt;
                ++num2;
                num4 = 0;
              }
              else
                break;
              --num3;
              if (num3 < 990)
              {
                position = new MyLocation(num2, yInt);
                velocity.x = (FixedInt) 0;
                velocity.y = (FixedInt) -10;
                goto label_23;
              }
            }
            position = new MyLocation(num2, yInt);
            ZSpellSand.Blit(map, position, Color32.Lerp(SpellSand.color1, SpellSand.color2, Random.Range(0.0f, 1f)), parent);
            yield break;
          }
        }
        else
        {
          x2 = x1;
          y2 = y1;
          x1 += fixedInt3;
          y1 += fixedInt4;
        }
      }
      position += velocity;
label_23:
      if (game.isClient)
        SandPool.Instance?.Add((Vector3) position.ToSinglePrecision());
      if (position.y < 1)
      {
        if (game.waterType == WaterStyle.No_Water)
          break;
        position.y = (FixedInt) 0;
        for (int index = 0; index < 10; ++index)
        {
          if (map.GetPixel((int) position.x, (int) position.y).a > (byte) 0 && map.GetPixel((int) position.x - 1, (int) position.y).a > (byte) 0 && map.GetPixel((int) position.x + 1, (int) position.y).a > (byte) 0)
            position.y += 1;
        }
        ZSpellSand.Blit(map, position, Color32.Lerp(SpellSand.color1, SpellSand.color2, Random.Range(0.0f, 1f)), parent);
        break;
      }
      velocity.y += map.Gravity;
      ++curDuration;
      if (curDuration >= 600)
        break;
      yield return 0.0f;
    }
  }
}
