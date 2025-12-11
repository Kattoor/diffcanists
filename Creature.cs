
using Educative;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Creature : Entity
{
  [NonSerialized]
  public List<Creature.NotScaled> notScaled = new List<Creature.NotScaled>();
  public bool isPawn = true;
  public CreatureStats stats;
  [NonSerialized]
  internal CreatureStats runTimeStats;
  internal ZCreature serverObj;
  [Header("Effector")]
  public Effector auraOfDecay;
  public MyCollider collider;
  [Header("Audio")]
  public AudioClip clipDeath;
  public AudioClip clipHit;
  public AudioClip clipSelect;
  [Header("Effects")]
  public bool recolor;
  public GameObject deathExplosion;
  public Sprite undeadHead;
  public Sprite undeadBody;
  public Sprite undeadLeftArm;
  public Sprite undeadRightArm;
  public Sprite undeadLeftFoot;
  public Sprite undeadRightFoot;
  public SpriteRenderer miniMapBg;
  public SpriteRenderer bg;
  public SpriteRenderer head;
  public SpriteRenderer body;
  public SpriteRenderer leftArm;
  public SpriteRenderer rightArm;
  public SpriteRenderer leftFoot;
  public SpriteRenderer rightFoot;
  public SpriteRenderer hat;
  public SpriteRenderer beard;
  public SpriteRenderer beard2;
  public SpriteRenderer beard3;
  public SpriteRenderer mouth;
  public GameObject christmasHat;
  internal TMP_Text txtHealth;
  internal TMP_Text txtShield;
  internal Image imgPrestige;
  internal GameObject selectedSpellPanel;
  internal Image selectedSpellIcon;
  [NonSerialized]
  public StoreObject activeStoreObject;
  [NonSerialized]
  public Canvas overheadCanvas;
  [NonSerialized]
  public OverheadEmoji overheadEmoji;
  [NonSerialized]
  public IAnimator animator;
  [NonSerialized]
  public PanelPlayer panelPlayer;
  internal ParticleDucks myducks;
  internal GameObject gravityObj;

  public MyLocation position
  {
    get
    {
      return this.serverObj.position;
    }
  }

  public SpriteRenderer GetSprite(Outfit f)
  {
    switch (f)
    {
      case Outfit.None:
        return this.body;
      case Outfit.Body:
        return this.body;
      case Outfit.Head:
        return this.head;
      case Outfit.LeftHand:
        return this.leftArm;
      case Outfit.RightHand:
        return this.rightArm;
      case Outfit.Hair:
        return this.hat;
      case Outfit.Beard:
        return this.beard;
      case Outfit.LeftFoot:
        return this.leftFoot;
      case Outfit.RightFoot:
        return this.rightFoot;
      case Outfit.Mouth:
        return this.mouth;
      case Outfit.Beard2:
        return this.beard2;
      case Outfit.Beard3:
        return this.beard3;
      default:
        return this.body;
    }
  }

  [ContextMenu("Save creatureToPNG to zSaveCharacter.png")]
  public void SavePNG2()
  {
    Texture2D t = new Texture2D(1000, 1000);
    int num1 = t.width / 2;
    int num2 = t.height / 2;
    Color32[] pixels32_1 = t.GetPixels32();
    for (int index = 0; index < pixels32_1.Length; ++index)
      pixels32_1[index] = (Color32) Color.clear;
    t.SetPixels32(pixels32_1);
    List<SpriteRenderer> list = ((IEnumerable<SpriteRenderer>) this.GetComponentsInChildren<SpriteRenderer>()).ToList<SpriteRenderer>();
    list.Sort((Comparison<SpriteRenderer>) ((a, b) => a.sortingOrder - b.sortingOrder));
    for (int index = list.Count - 1; index >= 0; --index)
    {
      if (!list[index].enabled || !list[index].gameObject.activeSelf || (UnityEngine.Object) list[index].sprite == (UnityEngine.Object) null)
        list.RemoveAt(index);
    }
    foreach (SpriteRenderer s in list)
      this.paint(t, s, num1 + (int) ((double) s.sprite.rect.width / 2.0 - (double) s.sprite.pivot.x), num2 + (int) ((double) s.sprite.rect.height / 2.0 - (double) s.sprite.pivot.y) + (64 - (int) s.sprite.rect.height) / 2, this.transform.position, s.transform.position, s.transform);
    Rect rect = new Rect();
    Color32[] pixels32_2 = t.GetPixels32();
    bool flag1 = false;
    for (int index1 = 0; index1 < t.width; ++index1)
    {
      for (int index2 = 0; index2 < t.height; ++index2)
      {
        if (pixels32_2[index1 + index2 * t.width].a != (byte) 0)
        {
          rect.x = (float) index1;
          flag1 = true;
          break;
        }
      }
      if (flag1)
        break;
    }
    bool flag2 = false;
    for (int index1 = t.width - 1; index1 >= 0; --index1)
    {
      for (int index2 = 0; index2 < t.height; ++index2)
      {
        if (pixels32_2[index1 + index2 * t.width].a != (byte) 0)
        {
          rect.width = (float) index1 - rect.x;
          flag2 = true;
          break;
        }
      }
      if (flag2)
        break;
    }
    bool flag3 = false;
    for (int index1 = 0; index1 < t.height; ++index1)
    {
      for (int index2 = t.width - 1; index2 >= 0; --index2)
      {
        if (pixels32_2[index2 + index1 * t.width].a != (byte) 0)
        {
          rect.y = (float) index1;
          flag3 = true;
          break;
        }
      }
      if (flag3)
        break;
    }
    bool flag4 = false;
    for (int index1 = t.height - 1; index1 >= 0; --index1)
    {
      for (int index2 = t.width - 1; index2 >= 0; --index2)
      {
        if (pixels32_2[index2 + index1 * t.width].a != (byte) 0)
        {
          rect.height = (float) index1 - rect.y;
          flag4 = true;
          break;
        }
      }
      if (flag4)
        break;
    }
    ++rect.width;
    ++rect.height;
    Color32[] colors = new Color32[(int) ((double) rect.width * (double) rect.height)];
    int index3 = 0;
    for (int y = (int) rect.y; y < (int) ((double) rect.y + (double) rect.height); ++y)
    {
      for (int x = (int) rect.x; x < (int) ((double) rect.x + (double) rect.width); ++x)
      {
        colors[index3] = pixels32_2[x + y * t.width];
        ++index3;
      }
    }
    Texture2D tex = new Texture2D((int) rect.width, (int) rect.height);
    tex.SetPixels32(colors);
    File.WriteAllBytes("zSaveCharacter.png", tex.EncodeToPNG());
  }

  private void paint(
    Texture2D t,
    SpriteRenderer s,
    int centerX,
    int centerY,
    Vector3 parent,
    Vector3 me,
    Transform child)
  {
    if (!s.gameObject.activeSelf || !s.enabled || !s.sprite.texture.isReadable)
      return;
    float pixelsPerUnit = s.sprite.pixelsPerUnit;
    Texture2D texture = s.sprite.texture;
    int width1 = (int) s.sprite.rect.width;
    Rect rect = s.sprite.rect;
    int height1 = (int) rect.height;
    Color[] pixels = texture.GetPixels(0, 0, width1, height1);
    Color32[] color32Array = new Color32[pixels.Length];
    for (int index = 0; index < color32Array.Length; ++index)
      color32Array[index] = (Color32) pixels[index];
    if (!s.gameObject.CompareTag("RawImage"))
    {
      Sprite sprite = Recolor.Copy(s.sprite);
      Surface dst = new Surface(t);
      Color32[] pixels32 = sprite.texture.GetPixels32();
      rect = sprite.rect;
      int width2 = (int) rect.width;
      rect = sprite.rect;
      int height2 = (int) rect.height;
      Surface src = new Surface(pixels32, width2, height2);
      int x = centerX + (int) (((double) me.x - (double) parent.x + 0.5) * (double) pixelsPerUnit);
      int y = centerY + (int) (((double) me.y - (double) parent.y + 0.5) * (double) pixelsPerUnit);
      RotateImage.RenderOverlay(dst, src, x, y, 0.0f, 0, true, false, 1f);
    }
    else
    {
      Surface dst = new Surface(t);
      Color32[] c = color32Array;
      rect = s.sprite.rect;
      int width2 = (int) rect.width;
      rect = s.sprite.rect;
      int height2 = (int) rect.height;
      Surface src = new Surface(c, width2, height2);
      int x = centerX + (int) (((double) me.x - (double) parent.x + 0.5) * (double) pixelsPerUnit);
      int y = centerY + (int) (((double) me.y - (double) parent.y + 0.5) * (double) pixelsPerUnit);
      RotateImage.RenderOverlay(dst, src, x, y, 0.0f, 0, true, false, 1f);
    }
  }

  public virtual ZCreature Get()
  {
    return new ZCreature();
  }

  public ZPerson parent
  {
    get
    {
      return this.serverObj.parent;
    }
  }

  public ZPerson originalParent
  {
    get
    {
      return this.serverObj.parent;
    }
  }

  public int radius
  {
    get
    {
      return this.runTimeStats.radius;
    }
  }

  public bool affectedByGravity
  {
    get
    {
      return this.runTimeStats.affectedByGravity;
    }
  }

  public int health
  {
    get
    {
      return this.runTimeStats.health;
    }
  }

  public int maxHealth
  {
    get
    {
      return this.runTimeStats.maxHealth;
    }
  }

  public FixedInt speed
  {
    get
    {
      return this.runTimeStats.speed;
    }
  }

  public EditorFixedInt massMulti
  {
    get
    {
      return this.runTimeStats.massMulti;
    }
  }

  public EditorFixedInt minAngle
  {
    get
    {
      return this.runTimeStats.minAngle;
    }
  }

  public EditorFixedInt maxAngle
  {
    get
    {
      return this.runTimeStats.maxAngle;
    }
  }

  public bool flying
  {
    get
    {
      return this.runTimeStats.flying;
    }
  }

  public bool mountable
  {
    get
    {
      return this.runTimeStats.mountable;
    }
  }

  public bool canMount
  {
    get
    {
      return this.runTimeStats.canMount;
    }
  }

  public bool phantom
  {
    get
    {
      return this.runTimeStats.phantom;
    }
  }

  public bool gliding
  {
    get
    {
      return this.runTimeStats.gliding;
    }
  }

  public bool canMove
  {
    get
    {
      return this.runTimeStats.canMove;
    }
  }

  public bool usingGlide
  {
    get
    {
      return this.runTimeStats.usingGlide;
    }
  }

  public EditorVector2 LongJumpData
  {
    get
    {
      return this.runTimeStats.LongJumpData;
    }
  }

  public EditorVector2 HighJumpData
  {
    get
    {
      return this.runTimeStats.HighJumpData;
    }
  }

  public CreatureType type
  {
    get
    {
      return this.runTimeStats.type;
    }
  }

  public CreatureRace race
  {
    get
    {
      return this.runTimeStats.race;
    }
  }

  public bool waterWalking
  {
    get
    {
      return this.runTimeStats.waterWalking;
    }
  }

  public bool frostWalking
  {
    get
    {
      return this.runTimeStats.frostWalking;
    }
  }

  public List<SpellSlot> spells
  {
    get
    {
      return this.runTimeStats.spells;
    }
  }

  internal int shield
  {
    get
    {
      return this.serverObj.shield;
    }
  }

  public void OnEmoji(int index, bool spectator = false)
  {
    if (!Client.renderEmoji || !Client.renderEmojiSpectator & spectator || (!((UnityEngine.Object) this.overheadCanvas != (UnityEngine.Object) null) || !((UnityEngine.Object) this.overheadEmoji == (UnityEngine.Object) null)))
      return;
    this.overheadEmoji = UnityEngine.Object.Instantiate<OverheadEmoji>(ClientResources.Instance.overheadEmoji, this.overheadCanvas.transform.position + new Vector3(0.0f, spectator ? 20f : 40f), Quaternion.identity, this.transform);
    this.overheadEmoji.OnEmoji(index);
    if (!Client.emojiSound || spectator && !Spectator.isConnected)
      return;
    AudioManager.Play(AudioManager.instance.emojiShow);
  }

  private void OnDestroy()
  {
    this.Cleanup();
  }

  public void Cleanup()
  {
    try
    {
      Global.DestroySprite((UnityEngine.Object) this.head != (UnityEngine.Object) null ? this.head.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.body != (UnityEngine.Object) null ? this.body.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.hat != (UnityEngine.Object) null ? this.hat.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.leftArm != (UnityEngine.Object) null ? this.leftArm.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.rightArm != (UnityEngine.Object) null ? this.rightArm.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.beard != (UnityEngine.Object) null ? this.beard.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.beard2 != (UnityEngine.Object) null ? this.beard2.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.beard3 != (UnityEngine.Object) null ? this.beard3.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.leftFoot != (UnityEngine.Object) null ? this.leftFoot.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.rightFoot != (UnityEngine.Object) null ? this.rightFoot.sprite : (Sprite) null);
      Global.DestroySprite((UnityEngine.Object) this.imgPrestige != (UnityEngine.Object) null ? this.imgPrestige.sprite : (Sprite) null);
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex);
    }
  }

  public IEnumerator BurningSandsCheck(ZCreature creature, ZEffector eff)
  {
    ZMyCollider colTower = (ZComponent) creature.tower != (object) null ? creature.tower.collider : (ZMyCollider) null;
    ZMyCollider col = creature.collider;
    int counter = 0;
    while (counter < 15)
    {
      if ((ZComponent) creature != (object) null && creature.game != null && creature.game.world != null)
      {
        if ((ZComponent) eff != (object) null && (ZComponent) eff.collider != (object) null && (colTower ?? col).OverlapRectangle(eff.collider.GetBounds()))
        {
          yield return (object) null;
          continue;
        }
        int num = !((ZComponent) colTower != (object) null) ? creature.game.world.OverlapColliderAll(col, IndicatorOfDecay.MyColliders, 512) : creature.game.world.OverlapColliderAll(colTower, IndicatorOfDecay.MyColliders, 512);
        for (int index = 0; index < num; ++index)
        {
          ZEffector effector = IndicatorOfDecay.MyColliders[index].effector;
          if ((ZComponent) effector != (object) null && effector.type == EffectorType.Burning_Sands)
            counter = 0;
        }
        if (counter < 15)
          ++counter;
      }
      yield return (object) null;
    }
    if ((ZComponent) creature != (object) null)
    {
      creature.indicatorOfBurningSands = false;
      creature.UpdateHealthTxt();
    }
  }

  public class NotScaled
  {
    public Outfit outfit = Outfit.None;
    public Transform transform;
    public Vector3 normalPositoin;
    public Vector3 leftPosition;
    public IAnimator animator;

    public NotScaled(IAnimator c, SpriteRenderer s, float offset, Outfit o)
    {
      this.transform = s.transform;
      this.normalPositoin = this.transform.localPosition;
      this.leftPosition = this.transform.localPosition + new Vector3(offset, 0.0f);
      this.animator = c;
      this.outfit = o;
    }

    public void Scale(Vector3 scale)
    {
      this.transform.localScale = scale;
      this.transform.localPosition = (double) scale.x < 0.0 ? this.leftPosition : this.normalPositoin;
      if (this.outfit == Outfit.LeftHand)
      {
        this.animator.ResetLeftHand();
      }
      else
      {
        if (this.outfit != Outfit.RightHand)
          return;
        this.animator.ResetRightHand();
      }
    }
  }
}
