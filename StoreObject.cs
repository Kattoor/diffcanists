
using System;
using System.Collections.Generic;
using UnityEngine;

public class StoreObject : MonoBehaviour
{
  public ExplosionCutout SnowTexture = ExplosionCutout.None;
  public bool recolor;
  public bool recolorUndead;
  [Header("Animated")]
  public Sprite[] animatedSprites;
  public Sprite[] undeadAnimatedSprites;
  public Sprite[] attackAnimatedSprites;
  public Sprite[] undeadAttackAnimatedSprites;
  [Header("Non-animated")]
  public Sprite Body;
  public Sprite Head;
  public Sprite LeftHand;
  public Sprite RightHand;
  public Sprite Hair;
  public Sprite Beard;
  public Sprite LeftFoot;
  public Sprite RightFoot;
  [Header("Undead")]
  public Sprite undeadBody;
  public Sprite undeadHead;
  public Sprite undeadLeftHand;
  public Sprite undeadRightHand;
  public Sprite undeadHair;
  public Sprite undeadBeard;
  public Sprite undeadLeftFoot;
  public Sprite undeadRightFoot;
  [Header("Spell Sprite")]
  public Sprite spellSprite;

  public static bool OnSummon(Creature c)
  {
    List<ArcanistsStore.Item> objList = Store.Instance.Get(ArcanistsStore.Which.SpellSkin);
    try
    {
      foreach (ActiveItem activeItem in c.parent.account.activeItems.items)
      {
        if (activeItem.which == ArcanistsStore.Which.SpellSkin && objList[activeItem.index].spellEnum == c.serverObj.spellEnum)
        {
          objList[activeItem.index].obj.Setup(c);
          return true;
        }
      }
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex.ToString());
    }
    return false;
  }

  public static void OnUndead(Creature c)
  {
    List<ArcanistsStore.Item> objList = Store.Instance.Get(ArcanistsStore.Which.SpellSkin);
    try
    {
      foreach (ActiveItem activeItem in c.parent.account.activeItems.items)
      {
        if (activeItem.which == ArcanistsStore.Which.SpellSkin && objList[activeItem.index].spellEnum == c.serverObj.spellEnum)
          objList[activeItem.index].obj.SetupUndead(c);
      }
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex.ToString());
    }
  }

  public static bool OnSpell(ZSpell c, ZCreature cre)
  {
    if ((ZComponent) cre == (object) null)
      return false;
    List<ArcanistsStore.Item> objList = Store.Instance.Get(ArcanistsStore.Which.SpellSkin);
    try
    {
      foreach (ActiveItem activeItem in cre.parent.account.activeItems.items)
      {
        if (activeItem.which == ArcanistsStore.Which.SpellSkin && objList[activeItem.index].spellEnum == c.spellEnum)
        {
          objList[activeItem.index].obj.Setup(c);
          return true;
        }
      }
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex.ToString());
    }
    return false;
  }

  public void Setup(Creature c)
  {
    if (this.animatedSprites.Length != 0)
    {
      AnimateDragon component1 = c.GetComponent<AnimateDragon>();
      if ((UnityEngine.Object) component1 != (UnityEngine.Object) null)
      {
        component1.sprites = this.animatedSprites;
        if (this.attackAnimatedSprites.Length != 0)
          component1.attackSprites = this.attackAnimatedSprites;
      }
      component1.choose = component1.sprites;
      SpriteRenderer component2 = c.GetComponent<SpriteRenderer>();
      if (!((UnityEngine.Object) component2 != (UnityEngine.Object) null))
        return;
      component2.sprite = component1.sprites[0];
    }
    else
    {
      if ((UnityEngine.Object) this.Body != (UnityEngine.Object) null)
      {
        c.body.sprite = this.Body;
        this.Recolor(c.body, c);
      }
      if ((UnityEngine.Object) this.Head != (UnityEngine.Object) null)
      {
        c.head.sprite = this.Head;
        this.Recolor(c.head, c);
      }
      if ((UnityEngine.Object) this.LeftHand != (UnityEngine.Object) null)
      {
        c.leftArm.sprite = this.LeftHand;
        this.Recolor(c.leftArm, c);
      }
      if ((UnityEngine.Object) this.RightHand != (UnityEngine.Object) null)
      {
        c.rightArm.sprite = this.RightHand;
        this.Recolor(c.rightArm, c);
      }
      if ((UnityEngine.Object) this.Hair != (UnityEngine.Object) null)
      {
        c.hat.sprite = this.Hair;
        this.Recolor(c.hat, c);
      }
      if ((UnityEngine.Object) this.Beard != (UnityEngine.Object) null)
      {
        c.beard.sprite = this.Beard;
        this.Recolor(c.beard, c);
      }
      if ((UnityEngine.Object) this.LeftFoot != (UnityEngine.Object) null)
      {
        c.leftFoot.sprite = this.LeftFoot;
        this.Recolor(c.leftFoot, c);
      }
      if (!((UnityEngine.Object) this.RightFoot != (UnityEngine.Object) null))
        return;
      c.rightFoot.sprite = this.RightFoot;
      this.Recolor(c.rightFoot, c);
    }
  }

  private void Recolor(SpriteRenderer x, Creature c)
  {
    if (!this.recolor || !((UnityEngine.Object) x.sprite != (UnityEngine.Object) null) || !x.sprite.texture.isReadable)
      return;
    ConfigurePlayer.ApplyOutfit(x, c.serverObj.daOriginalTrueParent != null ? c.serverObj.daOriginalTrueParent.settingsPlayer : c.parent.settingsPlayer);
  }

  private void UndeadRecolor(SpriteRenderer x, Creature c)
  {
    if (!this.recolorUndead || !((UnityEngine.Object) x.sprite != (UnityEngine.Object) null) || !x.sprite.texture.isReadable)
      return;
    ConfigurePlayer.ApplyOutfit(x, c.serverObj.daOriginalTrueParent != null ? c.serverObj.daOriginalTrueParent.settingsPlayer : c.parent.settingsPlayer);
  }

  public void SetupUndead(Creature c)
  {
    if (this.undeadAnimatedSprites.Length != 0)
    {
      AnimateDragon component1 = c.GetComponent<AnimateDragon>();
      if ((UnityEngine.Object) component1 != (UnityEngine.Object) null)
      {
        component1.sprites = this.undeadAnimatedSprites;
        if (this.undeadAttackAnimatedSprites.Length != 0)
          component1.attackSprites = this.undeadAttackAnimatedSprites;
      }
      component1.choose = component1.sprites;
      SpriteRenderer component2 = c.GetComponent<SpriteRenderer>();
      if (!((UnityEngine.Object) component2 != (UnityEngine.Object) null))
        return;
      component2.sprite = component1.sprites[0];
    }
    else
    {
      if ((UnityEngine.Object) this.undeadBody != (UnityEngine.Object) null)
      {
        c.body.sprite = this.undeadBody;
        this.UndeadRecolor(c.body, c);
      }
      if ((UnityEngine.Object) this.undeadHead != (UnityEngine.Object) null)
      {
        c.head.sprite = this.undeadHead;
        this.UndeadRecolor(c.head, c);
      }
      if ((UnityEngine.Object) this.undeadLeftHand != (UnityEngine.Object) null)
      {
        c.leftArm.sprite = this.undeadLeftHand;
        this.UndeadRecolor(c.leftArm, c);
      }
      if ((UnityEngine.Object) this.undeadRightHand != (UnityEngine.Object) null)
      {
        c.rightArm.sprite = this.undeadRightHand;
        this.UndeadRecolor(c.rightArm, c);
      }
      if ((UnityEngine.Object) this.undeadHair != (UnityEngine.Object) null)
      {
        c.hat.sprite = this.undeadHair;
        this.UndeadRecolor(c.hat, c);
      }
      if ((UnityEngine.Object) this.undeadBeard != (UnityEngine.Object) null)
      {
        c.beard.sprite = this.undeadBeard;
        this.UndeadRecolor(c.beard, c);
      }
      if ((UnityEngine.Object) this.undeadLeftFoot != (UnityEngine.Object) null)
      {
        c.leftFoot.sprite = this.undeadLeftFoot;
        this.UndeadRecolor(c.leftFoot, c);
      }
      if (!((UnityEngine.Object) this.undeadRightFoot != (UnityEngine.Object) null))
        return;
      c.rightFoot.sprite = this.undeadRightFoot;
      this.UndeadRecolor(c.rightFoot, c);
    }
  }

  public void Setup(ZSpell s)
  {
    if (!((UnityEngine.Object) this.spellSprite != (UnityEngine.Object) null))
      return;
    s.gameObject.GetComponent<SpriteRenderer>().sprite = this.spellSprite;
    if (this.SnowTexture == ExplosionCutout.None)
      return;
    s.snowCutout = this.SnowTexture;
  }
}
