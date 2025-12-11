
using Educative;
using Junk;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ZMap
{
  public static FixedInt MaxWindSpeed = (FixedInt) 52428L;
  public static FixedInt MaxSpeed = FixedInt.Create(100);
  public static FixedInt SnowSpeed = FixedInt.Create(11);
  public static Dictionary<Texture2D, Color32[]> cachedPixels = new Dictionary<Texture2D, Color32[]>();
  public static Dictionary<int, BufferedImage> cachedCutouts = new Dictionary<int, BufferedImage>();
  public FixedInt Gravity = (FixedInt) -838860L;
  public MyLocation wind = new MyLocation(0, 0);
  public FixedInt windSpeed = (FixedInt) 0;
  public FixedInt windDir = (FixedInt) -90;
  internal List<PastBlits> _pastBits = new List<PastBlits>();
  public Action doneCallback;
  private int _height;
  private int _width;
  private int _numBlocksHorizontal;
  private const int BlockSize = 16384;
  private const int _blockHeight = 128;
  public ZMyWorld world;
  public ZGame game;
  private bool purple;
  private Sprite sprite;
  private List<ZMap.RawSprite> rawspriteColors;
  public Color32[] deserializedPixels;
  public byte[] serializedMap;

  public int Height
  {
    get
    {
      return this._height;
    }
  }

  public int Width
  {
    get
    {
      return this._width;
    }
  }

  public string name
  {
    get
    {
      return this.rawspriteColors[0].sr.name;
    }
    set
    {
      this.rawspriteColors[0].sr.name = value;
    }
  }

  public void OnGhosted(int x, int y, int r, ZMyCollider colliderIgnore = null)
  {
    foreach (ZMyCollider c in this.world.OverlapCircleAll(new Point(x, y), r, colliderIgnore, Inert.mask_movement_NoEffector))
    {
      if (!ZComponent.IsNull((ZComponent) c) && ((ZComponent) c.creature != (object) null || (ZComponent) c.tower != (object) null))
      {
        ZMap.GhostTerrain ghostTerrain = c.ghosting;
        if (ghostTerrain == null)
        {
          c.ghosting = new ZMap.GhostTerrain()
          {
            x = x,
            y = y,
            radius2 = r * r
          };
          UnityEngine.Object.Instantiate<Phasing>(ClientResources.Instance.Phased, (Vector3) c.position.ToSinglePrecision(), Quaternion.identity, this.game.GetMapTransform()).Init(c, x, y, r * 2);
        }
        else
        {
          int num = 0;
          while (ghostTerrain.next != null)
          {
            ghostTerrain = ghostTerrain.next;
            ++num;
            if (num >= 10)
              return;
          }
          ghostTerrain.next = new ZMap.GhostTerrain()
          {
            x = x,
            y = y,
            radius2 = r * r
          };
          UnityEngine.Object.Instantiate<Phasing>(ClientResources.Instance.Phased, (Vector3) c.position.ToSinglePrecision(), Quaternion.identity, this.game.GetMapTransform()).Init(c, x, y, r * 2);
        }
        c.ghosted = true;
      }
    }
  }

  public void UpdateWind()
  {
    this.wind = Global.Velocity(this.windDir, this.windSpeed);
  }

  public void RandomizeWind()
  {
    this.windDir = this.game.RandomFixedInt(0, 360);
    this.windSpeed = this.game.RandomFixedInt(0, 1) * ZMap.MaxWindSpeed;
    this.wind = Global.Velocity(this.windDir, this.windSpeed);
    if (!this.game.isClient)
      return;
    WindIndicatorUI.Instance?.Refresh();
  }

  public void ToggleWind(bool v)
  {
    this.game.isWindy = v;
    WindIndicatorUI.Instance?.gameObject.SetActive(v);
    if (!v)
      return;
    WindIndicatorUI.Instance?.Refresh();
  }

  public void SetMapSprite(ZGame game, Sprite s)
  {
    this.sprite = s;
    if ((UnityEngine.Object) s != (UnityEngine.Object) null)
      this.SetMapSprite(game, s.texture.GetPixels32(), s.texture.height, s.texture.width);
    else
      this.rawspriteColors = (List<ZMap.RawSprite>) null;
  }

  public void SetMapSprite(ZGame game, Texture2D s)
  {
    if ((UnityEngine.Object) s != (UnityEngine.Object) null)
      this.SetMapSprite(game, s.GetPixels32(), s.height, s.width);
    else
      this.rawspriteColors = (List<ZMap.RawSprite>) null;
  }

  public void SetMapSprite(ZGame game, Color32[] pixels, int height, int width)
  {
    this._height = height;
    this._width = width;
    this._numBlocksHorizontal = this.Width / 128;
    if (this.Width % 128 != 0)
      ++this._numBlocksHorizontal;
    this.SetSprites(game, pixels);
    if (!game.isClient)
      return;
    CameraMovement objectOfType = UnityEngine.Object.FindObjectOfType<CameraMovement>();
    if ((UnityEngine.Object) objectOfType != (UnityEngine.Object) null)
      objectOfType.Start();
    if (!(bool) (UnityEngine.Object) MapObjects.Instance)
      return;
    MapObjects.Instance.SetDashes();
    MapObjects.Instance.SetWaves();
    MapObjects.Instance.ColorWaves();
  }

  public void CleanUp()
  {
    this.game = (ZGame) null;
    if (this.rawspriteColors == null)
      return;
    foreach (ZMap.RawSprite rawspriteColor in this.rawspriteColors)
    {
      if (rawspriteColor != null && (UnityEngine.Object) rawspriteColor.sprite != (UnityEngine.Object) null)
      {
        UnityEngine.Object.DestroyImmediate((UnityEngine.Object) rawspriteColor.sprite.texture);
        UnityEngine.Object.Destroy((UnityEngine.Object) rawspriteColor.sprite);
      }
    }
    this.rawspriteColors.Clear();
    ContainerGame.Dispose();
    UnityEngine.Resources.UnloadUnusedAssets();
  }

  public void Purpalize()
  {
    if (this.purple)
      return;
    this.purple = true;
    foreach (ZMap.RawSprite rawspriteColor in this.rawspriteColors)
      rawspriteColor.Purpalize();
  }

  public Sprite GetMapSprite
  {
    get
    {
      return this.sprite;
    }
  }

  public List<ZMap.RawSprite> GetRawSprites()
  {
    return this.rawspriteColors;
  }

  public void SetSprites(ZGame game, Color32[] x)
  {
    this.game = game;
    game.totalTurnsCombined = -1;
    this.rawspriteColors = new List<ZMap.RawSprite>();
    int x1 = this.Width / 128;
    int y = this.Height / 128;
    if (this.Width % 128 != 0)
      ++x1;
    if (this.Height % 128 != 0)
      ++y;
    Color white = Color.white;
    if (game.isClient)
    {
      float num = Mathf.Lerp(0.4f, 1f, Mathf.Clamp01(PlayerPrefs.GetFloat("prefblackFg", PlayerPrefs.GetFloat("prefblackBg", 1f))));
      white.r = num;
      white.g = num;
      white.b = num;
    }
    for (int index1 = 0; index1 < y; ++index1)
    {
      for (int index2 = 0; index2 < x1; ++index2)
      {
        Color32[] color32Array = new Color32[16384];
        for (int index3 = 0; index3 < 128; ++index3)
        {
          for (int index4 = 0; index4 < 128; ++index4)
          {
            int num1 = index2 * 128 + index4;
            int num2 = index1 * this.Width * 128 + index3 * this.Width;
            if (num1 < this.Width && num2 < x.Length)
              color32Array[index3 * 128 + index4] = x[num1 + num2];
            else
              break;
          }
        }
        if (!game.isClient)
        {
          this.rawspriteColors.Add(new ZMap.RawSprite((Sprite) null, (SpriteRenderer) null, color32Array));
        }
        else
        {
          GameObject gameObject1 = GameObject.FindGameObjectWithTag("map");
          if ((UnityEngine.Object) gameObject1 == (UnityEngine.Object) null)
            gameObject1 = game.GetMapTransform().gameObject;
          GameObject gameObject2 = new GameObject("map" + index1.ToString());
          gameObject2.layer = 12;
          gameObject2.transform.SetParent(gameObject1.transform);
          gameObject2.transform.position = new Vector3((float) (index2 * 128 + 64), (float) (index1 * 128) + 64f, 0.0f);
          Texture2D texture = new Texture2D(128, 128);
          texture.wrapMode = TextureWrapMode.Clamp;
          texture.SetPixels32(color32Array);
          texture.Apply(true);
          SpriteRenderer sr = gameObject2.AddComponent<SpriteRenderer>();
          Sprite s = sr.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, 128f, 128f), new Vector2(0.5f, 0.5f), 1f, 1U, SpriteMeshType.FullRect);
          sr.sortingOrder = -20;
          sr.color = white;
          this.rawspriteColors.Add(new ZMap.RawSprite(s, sr, color32Array));
        }
      }
    }
    this.Apply();
    game.world.Init(x1, y, this.rawspriteColors.Count);
    if (!game.isClient)
    {
      if (this.serializedMap == null)
        this.serializedMap = this.CompressMap(x);
      game.OnMapGeneratedCompleted();
    }
    game.MAPCREATED = true;
    game.random = new IsaacCipher(new int[1]
    {
      game.gameFacts.seed
    });
    if (this.doneCallback == null)
      return;
    if (game.First_Turn_Teleport)
    {
      for (int index = 0; index < game.players.Count; ++index)
      {
        game.players[index].controlled[0].inWater = true;
        game.players[index].controlled[0].SetPosition(new MyLocation(this.Width / 2, -1000));
      }
    }
    else if (game.players.Count == 2)
    {
      int num1 = 256;
      int num2 = 0;
      if (game.gameFacts.realMap == MapEnum.Wasteland)
      {
        num2 = 256;
        num1 = 512;
      }
      int num3 = game.gameFacts.GetTimeInSeconds() <= 10 ? 256 : 448;
      int num4 = game.gameFacts.realMap == MapEnum.Jungle ? 300 : 0;
      for (int index1 = 0; index1 < game.players.Count; ++index1)
      {
        List<MyLocation> myLocationList = new List<MyLocation>();
        FixedInt fixedInt = (FixedInt) (this.Height - game.players[index1].controlled[0].radius);
        MyLocation startPosition1 = game.players[index1].controlled[0].GetStartPosition(new MyLocation((FixedInt) (index1 == 0 ? num1 + num2 : this.Width - num1), fixedInt - num4));
        myLocationList.Add(startPosition1);
        for (int index2 = 16; index2 <= num3; index2 += 16)
        {
          MyLocation startPosition2 = game.players[index1].controlled[0].GetStartPosition(new MyLocation((FixedInt) (index1 == 0 ? num1 + index2 + num2 : this.Width - num1 - index2), fixedInt - num4));
          myLocationList.Add(startPosition2);
        }
        myLocationList.Sort((Comparison<MyLocation>) ((aa, bb) => (int) aa.y - (int) bb.y));
        game.players[index1].controlled[0].SetPosition(myLocationList[1]);
      }
    }
    else
    {
      int num1 = (this.Width - 800 - (game.gameFacts.realMap == MapEnum.Wasteland ? 300 : 0)) / (game.players.Count == 1 ? 1 : game.players.Count - 1);
      int num2 = game.players.Count == 1 ? this.Width / 2 : 400;
      int num3 = game.gameFacts.realMap == MapEnum.Jungle ? 300 : 0;
      if (game.gameFacts.realMap == MapEnum.Wasteland)
        num2 += 300;
      for (int index = 0; index < game.players.Count; ++index)
      {
        FixedInt x2 = (FixedInt) (num1 * index + num2);
        FixedInt fixedInt = (FixedInt) (this.Height - game.players[index].controlled[0].radius);
        game.players[index].controlled[0].position = new MyLocation(x2, fixedInt - num3);
        game.players[index].controlled[0].SetStartPosition();
      }
    }
    if (game.isClient && game.isSpectator && (UnityEngine.Object) CameraMovement.Instance != (UnityEngine.Object) null)
      CameraMovement.Instance.GotoPosition(new Vector3((float) (this.Width / 2), (float) (this.Height / 2), 0.0f));
    game.OnSetup();
    this.doneCallback();
    this.doneCallback = (Action) null;
  }

  internal byte[] CompressMap(Color32[] x)
  {
    using (MemoryStream memoryStream1 = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter1 = new myBinaryWriter((Stream) memoryStream1))
      {
        myBinaryWriter1.Write((byte) 16);
        myBinaryWriter1.Write(this.Width);
        myBinaryWriter1.Write(this.Height);
        myBinaryWriter1.Write(Server.CompressMap);
        if (Server.CompressMap)
        {
          using (MemoryStream memoryStream2 = new MemoryStream())
          {
            using (myBinaryWriter myBinaryWriter2 = new myBinaryWriter((Stream) memoryStream2))
            {
              myBinaryWriter2.Write(x.Length);
              for (int index = 0; index < x.Length; ++index)
                myBinaryWriter2.Write(x[index]);
            }
            byte[] buffer = CLZF2.Compress(memoryStream2.ToArray());
            myBinaryWriter1.Write(buffer);
          }
        }
        else
        {
          myBinaryWriter1.Write(x.Length);
          for (int index = 0; index < x.Length; ++index)
            myBinaryWriter1.Write(x[index]);
        }
      }
      return memoryStream1.ToArray();
    }
  }

  private void PixelCount(Color32[] g)
  {
    HashSet<int> intSet = new HashSet<int>();
    foreach (Color32 color32 in g)
      intSet.Add(((int) color32.r << 24) + ((int) color32.g << 16) + ((int) color32.b << 8));
    Debug.Log((object) ("Pixel Count: " + intSet.Count.ToString()));
  }

  public bool IsGround(int x, int y)
  {
    return this.InBounds(x, y) && this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a > (byte) 0;
  }

  public bool IsSand(int x, int y)
  {
    return this.InBounds(x, y) && this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a == (byte) 254;
  }

  public bool IsEmpty(int x, int y)
  {
    return !this.InBounds(x, y) || this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a > (byte) 0;
  }

  public void UpdatePixel(int x, int y, Color32 c)
  {
    if (x < 0 || y < 0 || (x >= this.Width || y >= this.Height))
      return;
    this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].SetPixel((x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7), c);
  }

  public void UpdatePixelNoBounds(int x, int y, Color32 c)
  {
    this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].SetPixel((x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7), c);
  }

  public Color32 GetPixel(int x, int y)
  {
    return x < 0 || y < 0 || (x >= this.Width || y >= this.Height) ? (Color32) Color.white : this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)];
  }

  public Color32 GetPixelNoBoundsCheck(int x, int y)
  {
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)];
  }

  private bool PixelNotTransparent(int x, int y)
  {
    return x >= 0 && y >= 0 && (x < this.Width && y < this.Height) && this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a > (byte) 0;
  }

  public bool PixelNotAlpha(int x, int y, ZCreature creature, int mask, bool collideWithThorns = true)
  {
    if (x < 0 || y < 0 || (x >= this.Width || y >= this.Height))
      return false;
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a != (byte) 0 || this.PhysicsCollidePoint(creature, x, y, mask, collideWithThorns);
  }

  public bool SpellPixelNotAlpha(int x, int y, ZCreature creature, int mask)
  {
    if (x < 0 || y < 0 || (x >= this.Width || y >= this.Height))
      return false;
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a != (byte) 0 || this.SpellPhysicsCollidePoint(creature, x, y, mask);
  }

  public bool LeafPixelNotAlpha(int x, int y, ZCreature creature, int mask)
  {
    if (x < 0 || y < 0 || (x >= this.Width || y >= this.Height))
      return false;
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a != (byte) 0 || this.LeafPhysicsCollidePoint(creature, x, y, mask);
  }

  public bool SpellPixelNotAlphaIgnoreSelf(int x, int y, ZMyCollider ignore, int mask)
  {
    if (x < 0 || y < 0 || (x >= this.Width || y >= this.Height))
      return false;
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a != (byte) 0 || this.SpellPhysicsCollidePointIgnoreSelf(ignore, x, y, mask);
  }

  public bool PixelNotAlphaUndeadOnly(int x, int y, ZCreature creature, ZSpell spell, int mask)
  {
    if (x < 0 || y < 0 || (x >= this.Width || y >= this.Height))
      return false;
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a != (byte) 0 || this.SpellPhysicsCollidePointUndeadOnly(creature, spell, x, y, mask);
  }

  public bool BitBltPixelNotAlpha(int x, int y)
  {
    return x >= 0 && y >= 0 && (x < this.Width && y < this.Height) && this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a > (byte) 0;
  }

  public Color32 BitBltPixelColor(int x, int y)
  {
    return x < 0 || y < 0 || (x >= this.Width || y >= this.Height) ? (Color32) Color.white : this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)];
  }

  public void SetPixelColor(int x, int y, Color32 p)
  {
    if (!this.InBounds(x, y))
      return;
    this.UpdatePixel(x, y, p);
  }

  public void DrawRectangle(int xx, int yy, int width, int height, Color32 p)
  {
    for (int index1 = 0; index1 < width; ++index1)
    {
      for (int index2 = 0; index2 < height; ++index2)
        this.UpdatePixel(xx + index1, yy + index2, p);
    }
  }

  public void DrawEllipse(int x, int y, int width, int height, Color32 color)
  {
    int num1 = width;
    int num2 = height;
    for (int x1 = x - Mathf.RoundToInt((float) num1); x1 <= x + Mathf.RoundToInt((float) num1); ++x1)
    {
      for (int y1 = y - Mathf.RoundToInt((float) num2); y1 <= y + Mathf.RoundToInt((float) num2); ++y1)
      {
        double num3 = (double) (x1 - x);
        float num4 = (float) (y1 - y);
        if (num3 * num3 / (double) (num1 * num1) + (double) num4 * (double) num4 / (double) (num2 * num2) < 1.0 && this.InBounds(x1, y1))
          this.UpdatePixel(x1, y1, color);
      }
    }
  }

  public void DrawEllipseOutline(
    int x,
    int y,
    int width,
    int height,
    int outlineRadius,
    Color32 color)
  {
    int num1 = width / 2;
    int num2 = height / 2;
    for (int x1 = x - Mathf.RoundToInt((float) num1); x1 <= x + Mathf.RoundToInt((float) num1); ++x1)
    {
      for (int y1 = y - Mathf.RoundToInt((float) num2); y1 <= y + Mathf.RoundToInt((float) num2); ++y1)
      {
        float num3 = (float) (x1 - x);
        float num4 = (float) (y1 - y);
        if ((double) num3 * (double) num3 / (double) (num1 * num1) + (double) num4 * (double) num4 / (double) (num2 * num2) < 1.0 && (double) num3 * (double) num3 / (double) ((num1 - outlineRadius) * (num1 - outlineRadius)) + (double) num4 * (double) num4 / (double) ((num2 - outlineRadius) * (num2 - outlineRadius)) >= 1.0 && this.InBounds(x1, y1))
          this.UpdatePixel(x1, y1, color);
      }
    }
  }

  public bool InBounds(int x, int y, int radius)
  {
    return x + radius < this.Width && x - radius >= 0 && (y - radius >= 0 && y + radius < this.Height);
  }

  public bool InBounds(int x, int y)
  {
    return x < this.Width && x >= 0 && (y >= 0 && y < this.Height);
  }

  public bool CheckPosition(int x, int y, ZCreature creature, int mask)
  {
    if (x < this.Width && x >= 0 && (y >= 0 && y < this.Height))
      return !this.PixelNotAlpha(x, y, creature, mask, true);
    if (mask == Inert.mask_entity_movement)
      this.PhysicsCollidePoint(creature, x, y, 2560, false);
    return !((ZComponent) creature != (object) null) || !creature.flying || (creature.entangledOrGravity || x < 0) || (x >= this.Width || creature.race == CreatureRace.Effector) || (x < this.Width && x >= 0 || !(creature.velocity.y == 0)) && (y >= 0 && y < this.Height || !(creature.velocity.x == 0));
  }

  public bool SpellCheckPosition(int x, int y, ZCreature creature, int mask)
  {
    return x >= this.Width || x < 0 || (y < 0 || y >= this.Height) ? !this.SpellPhysicsCollidePoint(creature, x, y, mask) : !this.SpellPixelNotAlpha(x, y, creature, mask);
  }

  public bool LeafCheckPosition(int x, int y, ZCreature creature, int mask)
  {
    return x >= this.Width || x < 0 || (y < 0 || y >= this.Height) ? !this.LeafPhysicsCollidePoint(creature, x, y, mask) : !this.LeafPixelNotAlpha(x, y, creature, mask);
  }

  public bool SpellCheckPositionIgnoreSelf(int x, int y, ZMyCollider ignore, int mask)
  {
    return x >= this.Width || x < 0 || (y < 0 || y >= this.Height) ? !this.SpellPhysicsCollidePointIgnoreSelf(ignore, x, y, mask) : !this.SpellPixelNotAlphaIgnoreSelf(x, y, ignore, mask);
  }

  public bool SpellCheckPositionEntities(int x, int y, ZCreature creature, int mask)
  {
    return !this.SpellPhysicsCollidePoint(creature, x, y, mask);
  }

  public bool SpellCheckPositionUndeadOnly(
    int x,
    int y,
    ZCreature creature,
    ZSpell spell,
    int mask)
  {
    return x >= this.Width || x < 0 || (y < 0 || y >= this.Height) ? !this.SpellPhysicsCollidePointUndeadOnly(creature, spell, x, y, mask) : !this.PixelNotAlphaUndeadOnly(x, y, creature, spell, mask);
  }

  public bool CheckPositionPhantom(int x, int y, ZCreature creature, int mask)
  {
    if (x < this.Width && x >= 0 && (y >= 0 && y < this.Height))
      return !this.PhysicsCollidePoint(creature, x, y, mask, true);
    return !((ZComponent) creature != (object) null) || !creature.flying || (creature.entangledOrGravity || x < 0) || (x >= this.Width || creature.race == CreatureRace.Effector) || (x < this.Width && x >= 0 || !(creature.velocity.y == 0)) && (y >= 0 && y < this.Height || !(creature.velocity.x == 0));
  }

  public bool CheckPositionOnlyEntities(int x, int y, ZCreature creature, int mask)
  {
    return x >= this.Width || x < 0 || (y < 0 || y >= this.Height) || !this.PhysicsCollidePoint(creature, x, y, mask, true);
  }

  public bool CheckPositionOnlyMap(int x, int y)
  {
    return x >= this.Width || x < 0 || (y < 0 || y >= this.Height) || this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a == (byte) 0;
  }

  public bool CheckClampedPixel(int x, int y)
  {
    return this.rawspriteColors[(x >> 7) + (y >> 7) * this._numBlocksHorizontal].colors[(x & (int) sbyte.MaxValue) + ((y & (int) sbyte.MaxValue) << 7)].a == (byte) 0;
  }

  public void DoPastBlit(PastBlits p)
  {
    if (p.index == -2)
      ZSpell.ColorBurningSands(this.game, new MyLocation(p.x, p.y), false);
    if (p.index == -1)
      ZSpellSand.Blit(this, Color32.Lerp(SpellSand.color1, SpellSand.color2, UnityEngine.Random.Range(0.0f, 1f)), p.x, p.y);
    else if (p.hue)
    {
      Color32[] pixels32;
      if (!ZMap.cachedPixels.TryGetValue(Inert.Instance.cutouts[p.index], out pixels32))
      {
        pixels32 = Inert.Instance.cutouts[p.index].GetPixels32();
        ZMap.cachedPixels.Add(Inert.Instance.cutouts[p.index], pixels32);
      }
      RotateImage.RenderHUE(this, new Surface(pixels32, Inert.Instance.cutouts[p.index].width, Inert.Instance.cutouts[p.index].height), p.x, p.y, 0.0f, false, p.brightness.ToFloat(), 1f);
    }
    else if (p.rotate)
    {
      Color32[] pixels32;
      if (!ZMap.cachedPixels.TryGetValue(Inert.Instance.cutouts[p.index], out pixels32))
      {
        pixels32 = Inert.Instance.cutouts[p.index].GetPixels32();
        ZMap.cachedPixels.Add(Inert.Instance.cutouts[p.index], pixels32);
      }
      RotateImage.Render(this, new Surface(pixels32, Inert.Instance.cutouts[p.index].width, Inert.Instance.cutouts[p.index].height), p.x, p.y, p.brightness, 1, p.ignoreAlpha, true, (FixedInt) 1, true);
    }
    else if (p.brightness > 0)
      this.BitBltBrightness(Inert.Instance.cutouts[p.index], p.x, p.y, p.brightness.ToFloat(), p.ignoreAlpha);
    else
      this.BitBlt(Inert.Instance.cutouts[p.index], p.x, p.y, p.ignoreAlpha, true);
  }

  public void TutorialBitBlt(Texture2D index, int x, int y, bool ignoreAlpha = true, bool apply = true)
  {
    this.BitBlt(index, x, y, ignoreAlpha, apply);
  }

  public void ServerBitBltRotate(
    int index,
    int x,
    int y,
    FixedInt Angle,
    bool infront,
    bool apply = true)
  {
    if (!this.game.AllowTerrainDestruction || index == 38)
      return;
    this._pastBits.Add(new PastBlits(x, y, index, infront, Angle, true));
    RotateImage.Render(this, new Surface(Inert.Instance.cutouts[index]), x, y, Angle, 1, infront, true, (FixedInt) 1, apply);
  }

  public void ServerBitBlt(int index, int x, int y, bool ignoreAlpha = true, bool apply = true)
  {
    if (!this.game.AllowTerrainDestruction || index == 38)
      return;
    this._pastBits.Add(new PastBlits(x, y, index, ignoreAlpha, (FixedInt) 0, false));
    this.BitBlt(Inert.Instance.cutouts[index], x, y, ignoreAlpha, true);
  }

  public void ServerBitBltHue(int index, int x, int y, float hue, bool ignoreAlpha = true, bool apply = true)
  {
    if (!this.game.AllowTerrainDestruction || index == 38)
      return;
    this._pastBits.Add(new PastBlits(x, y, index, ignoreAlpha, (FixedInt) hue, false, true));
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(Inert.Instance.cutouts[index], out pixels32))
    {
      pixels32 = Inert.Instance.cutouts[index].GetPixels32();
      ZMap.cachedPixels.Add(Inert.Instance.cutouts[index], pixels32);
    }
    RotateImage.RenderHUE(this, new Surface(pixels32, Inert.Instance.cutouts[index].width, Inert.Instance.cutouts[index].height), x, y, 0.0f, false, hue, 1f);
  }

  public void ServerBitBltBrightness(
    int index,
    int x,
    int y,
    FixedInt brightness,
    bool ignoreAlpha = true)
  {
    if (!this.game.AllowTerrainDestruction || index == 38)
      return;
    this._pastBits.Add(new PastBlits(x, y, index, ignoreAlpha, brightness, false));
    this.BitBlt(Inert.Instance.cutouts[index], x, y, ignoreAlpha, true);
  }

  public int ServerBitBltAndReturnIfChanged(int index, int x, int y, bool ignoreAlpha = true)
  {
    if (!this.game.AllowTerrainDestruction || index == 38)
      return 0;
    this._pastBits.Add(new PastBlits(x, y, index, ignoreAlpha, (FixedInt) -1, false));
    return this.BitBltAndReturnIfChanged(Inert.Instance.cutouts[index], x, y, ignoreAlpha);
  }

  public static Color32[] GetPixels32(Texture2D mask)
  {
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    return pixels32;
  }

  public void BitBlt(Color32 color, int x, int y)
  {
    if (this.BitBltPixelNotAlpha(x, y))
      return;
    this.UpdatePixel(x, y, color);
    this.Apply();
  }

  public void BitBltDelay(Color32 color, int x, int y)
  {
    if (this.BitBltPixelNotAlpha(x, y))
      return;
    this.UpdatePixel(x, y, color);
    SandPool.NeedApply = true;
  }

  public Color32[] GetPixels(Texture2D mask)
  {
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    return pixels32;
  }

  public void BitBlt(Texture2D mask, int x, int y, bool ignoreAlpha = true, bool apply = true)
  {
    int num1 = 0;
    int num2 = 0;
    int height = mask.height;
    int width = mask.width;
    x -= width / 2;
    y -= height / 2;
    if (x < 0)
    {
      num1 -= x;
      x = 0;
    }
    if (y < 0)
    {
      num2 -= y;
      y = 0;
    }
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num3 = num1;
    int num4 = x;
    if (ignoreAlpha)
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num5 = num3;
        for (x = num4; num5 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num5;
          if ((Color) pixels32[index] != Color.black && this.BitBltPixelNotAlpha(x, y))
            this.UpdatePixel(x, y, pixels32[index]);
          ++num5;
        }
        ++num2;
      }
    }
    else
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num5 = num3;
        for (x = num4; num5 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num5;
          if (pixels32[index].a != (byte) 0)
            this.UpdatePixel(x, y, pixels32[index]);
          ++num5;
        }
        ++num2;
      }
    }
    if (!apply)
      return;
    this.Apply();
  }

  public void EditorUnderbelly()
  {
    int width1 = this.Width;
    int height1 = this.Height;
    Texture2D underbelly = MapEditor.Instance._underbelly;
    if ((UnityEngine.Object) underbelly == (UnityEngine.Object) null)
      underbelly = Inert.Instance.classMaps.mapGroups[0].underbelly;
    Color32[] pixels32 = underbelly.GetPixels32();
    int height2 = underbelly.height;
    int width2 = underbelly.width;
    for (int x = 0; x < width1; ++x)
    {
      for (int y = height1 - 1; y >= 0; --y)
      {
        if (this.GetPixelNoBoundsCheck(x, y).a > (byte) 0 && y - 1 >= 0 && this.GetPixelNoBoundsCheck(x, y - 1).a == (byte) 0)
        {
          int num = x % width2;
          for (int index = 0; index < height2 && (y + index < height1 && this.GetPixelNoBoundsCheck(x, y + index).a > (byte) 0); ++index)
          {
            if (MapEditor.Instance.isSelected(new Point(x, y)) && !Global.CompareColorsAlpha(pixels32[num + index * width2], this.GetPixel(x, y + index)))
              this.UpdatePixel(x, y + index, pixels32[num + index * width2]);
          }
        }
      }
    }
  }

  public void EditorPaintGrass()
  {
    int width1 = this.Width;
    int height1 = this.Height;
    Texture2D grass = MapEditor.Instance._grass;
    if ((UnityEngine.Object) grass == (UnityEngine.Object) null)
      grass = Inert.Instance.classMaps.mapGroups[0].grass;
    Color32[] pixels32 = grass.GetPixels32();
    int height2 = grass.height;
    int width2 = grass.width;
    List<(int, int, Color32)> valueTupleList = new List<(int, int, Color32)>();
    for (int x = 0; x < width1; ++x)
    {
      for (int y = 0; y < height1; ++y)
      {
        if (this.GetPixelNoBoundsCheck(x, y).a > (byte) 0 && y + 1 < height1 && this.GetPixelNoBoundsCheck(x, y + 1).a == (byte) 0)
        {
          int num1 = x % width2;
          int num2 = y > height2 ? 0 : height2 - y;
          int num3 = 0;
          for (int index = height2 - 1; index >= num2 && (y - num3 >= 0 && this.GetPixelNoBoundsCheck(x, y - num3).a > (byte) 0); --index)
          {
            if (MapEditor.Instance.isSelected(new Point(x, y)) && !Global.CompareColorsAlpha(pixels32[num1 + index * width2], this.GetPixel(x, y - num3)))
              valueTupleList.Add((x, y - num3 + MapEditor.Instance.grass_offset, pixels32[num1 + index * width2]));
            ++num3;
          }
        }
      }
    }
    foreach ((int, int, Color32) valueTuple in valueTupleList)
      this.UpdatePixel(valueTuple.Item1, valueTuple.Item2, valueTuple.Item3);
  }

  public void Editor_Texture_Restrained_Cirle(
    Texture2D mask,
    int radius,
    int x,
    int y,
    bool ignoreExisting = true,
    bool apply = true,
    float hue = 1f,
    Color32? overrideColor = null)
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = radius * 2;
    int num4 = radius * 2;
    int num5 = x;
    int num6 = y;
    x -= num4 / 2;
    y -= num3 / 2;
    Vector2 a = new Vector2((float) num5, (float) num6);
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num7 = num1;
    int num8 = x;
    int num9 = num6 % mask.height;
    while (num2 < num3 && y < this.Height)
    {
      int num10 = num5 % mask.width;
      int num11 = num7;
      x = num8;
      while (num11 < num4 && x < this.Width)
      {
        if (num9 >= 0 && num10 >= 0)
        {
          int index = num9 % mask.height * mask.width + num10 % mask.width;
          Color32 color32 = ColorHSV.AdjustColor(pixels32[index], hue);
          if (pixels32[index].a != (byte) 0 && MapEditor.Instance.isSelected(new Point(x, y)) && (!Global.CompareColorsAlpha(overrideColor.HasValue ? overrideColor.Value : color32, this.GetPixel(x, y)) && (double) Vector2.Distance(a, new Vector2((float) x, (float) y)) <= (double) radius && (!ignoreExisting || this.GetPixel(x, y).a == (byte) 0)))
            this.UpdatePixel(x, y, overrideColor.HasValue ? overrideColor.Value : color32);
        }
        ++num11;
        ++x;
        ++num10;
      }
      ++num2;
      ++y;
      ++num9;
    }
    if (!apply)
      return;
    this.Apply();
  }

  public void Editor_Texture_Restrained_Square(
    Texture2D mask,
    int radius,
    int x,
    int y,
    bool ignoreExisting = true,
    bool apply = true,
    float hue = 1f,
    Color32? overrideColor = null)
  {
    int num1 = 0;
    int num2 = 0;
    int num3 = radius * 2;
    int num4 = radius * 2;
    int num5 = x;
    int num6 = y;
    x -= num4 / 2;
    y -= num3 / 2;
    Vector2 vector2 = new Vector2((float) num5, (float) num6);
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num7 = num1;
    int num8 = x;
    int num9 = num6 % mask.height;
    while (num2 < num3 && y < this.Height)
    {
      int num10 = num5 % mask.width;
      int num11 = num7;
      x = num8;
      while (num11 < num4 && x < this.Width)
      {
        if (num9 >= 0 && num10 >= 0)
        {
          int index = num9 % mask.height * mask.width + num10 % mask.width;
          Color32 color32 = ColorHSV.AdjustColor(pixels32[index], hue);
          if (pixels32[index].a != (byte) 0 && MapEditor.Instance.isSelected(new Point(x, y)) && (!Global.CompareColorsAlpha(overrideColor.HasValue ? overrideColor.Value : color32, this.GetPixel(x, y)) && (!ignoreExisting || this.GetPixel(x, y).a == (byte) 0)))
            this.UpdatePixel(x, y, overrideColor.HasValue ? overrideColor.Value : color32);
        }
        ++num11;
        ++x;
        ++num10;
      }
      ++num2;
      ++y;
      ++num9;
    }
    if (!apply)
      return;
    this.Apply();
  }

  public void Editor_Object(
    Texture2D mask,
    int x,
    int y,
    bool ignoreExisting = true,
    bool apply = true,
    Color32? overrideColor = null)
  {
    int num1 = 0;
    int num2 = 0;
    int height = mask.height;
    int width = mask.width;
    int num3 = x;
    int num4 = y;
    x -= width / 2;
    y -= height / 2;
    Vector2 vector2 = new Vector2((float) num3, (float) num4);
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num5 = num1;
    int num6 = x;
    int num7 = num4 % mask.height;
    while (num2 < height && y < this.Height)
    {
      int num8 = num3 % mask.width;
      int num9 = num5;
      x = num6;
      while (num9 < width && x < this.Width)
      {
        int index = num2 * width + num9;
        if (pixels32[index].a != (byte) 0 && MapEditor.Instance.isSelected(new Point(x, y)) && (!Global.CompareColorsAlpha(overrideColor.HasValue ? overrideColor.Value : pixels32[index], this.GetPixel(x, y)) && (!ignoreExisting || this.GetPixel(x, y).a == (byte) 0)))
          this.UpdatePixel(x, y, overrideColor.HasValue ? overrideColor.Value : pixels32[index]);
        ++num9;
        ++x;
        ++num8;
      }
      ++num2;
      ++y;
      ++num7;
    }
    if (!apply)
      return;
    this.Apply();
  }

  public void BitBlt(int radius, int x, int y, bool ignoreAlpha = true, bool apply = true)
  {
    BufferedImage bufferedImage = (BufferedImage) null;
    if (!ZMap.cachedCutouts.TryGetValue(radius, out bufferedImage))
    {
      int num = radius * 2 + 1;
      bufferedImage = new BufferedImage(num, num);
      bufferedImage.circle(num / 2, num / 2, 3, radius);
      ZMap.cachedCutouts.Add(radius, bufferedImage);
    }
    int num1 = 0;
    int num2 = 0;
    int height = bufferedImage.height;
    int width = bufferedImage.width;
    x -= width / 2;
    y -= height / 2;
    if (x < 0)
    {
      num1 -= x;
      x = 0;
    }
    if (y < 0)
    {
      num2 -= y;
      y = 0;
    }
    int num3 = num1;
    int num4 = x;
    if (ignoreAlpha)
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num5 = num3;
        for (x = num4; num5 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num5;
          if ((Color) bufferedImage.pixels[index] != Color.black && this.BitBltPixelNotAlpha(x, y))
            this.UpdatePixel(x, y, bufferedImage.pixels[index]);
          ++num5;
        }
        ++num2;
      }
    }
    else
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num5 = num3;
        for (x = num4; num5 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num5;
          if (bufferedImage.pixels[index].a != (byte) 0)
            this.UpdatePixel(x, y, bufferedImage.pixels[index]);
          ++num5;
        }
        ++num2;
      }
    }
    if (!apply)
      return;
    this.Apply();
  }

  public void BitBltBrightness(Texture2D mask, int x, int y, float multiplier, bool ignoreAlpha = true)
  {
    int num1 = 0;
    int num2 = 0;
    int height = mask.height;
    int width = mask.width;
    x -= width / 2;
    y -= height / 2;
    if (x < 0)
    {
      num1 -= x;
      x = 0;
    }
    if (y < 0)
    {
      num2 -= y;
      y = 0;
    }
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num3 = num1;
    int num4 = x;
    if (ignoreAlpha)
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num5 = num3;
        for (x = num4; num5 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num5;
          if ((Color) pixels32[index] != Color.black && this.BitBltPixelNotAlpha(x, y))
            this.UpdatePixel(x, y, new Color32((byte) ((double) pixels32[index].r * (double) multiplier), (byte) ((double) pixels32[index].g * (double) multiplier), (byte) ((double) pixels32[index].b * (double) multiplier), pixels32[index].a));
          ++num5;
        }
        ++num2;
      }
    }
    else
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num5 = num3;
        for (x = num4; num5 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num5;
          if (pixels32[index].a != (byte) 0)
            this.UpdatePixel(x, y, new Color32((byte) ((double) pixels32[index].r * (double) multiplier), (byte) ((double) pixels32[index].g * (double) multiplier), (byte) ((double) pixels32[index].b * (double) multiplier), pixels32[index].a));
          ++num5;
        }
        ++num2;
      }
    }
    this.Apply();
  }

  public int BitBltAndReturnIfChanged(Texture2D mask, int x, int y, bool ignoreAlpha = true)
  {
    int num1 = 0;
    int num2 = 0;
    int height = mask.height;
    int width = mask.width;
    int num3 = 0;
    x -= width / 2;
    y -= height / 2;
    if (x < 0)
    {
      num1 -= x;
      x = 0;
    }
    if (y < 0)
    {
      num2 -= y;
      y = 0;
    }
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num4 = num1;
    int num5 = x;
    if (ignoreAlpha)
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num6 = num4;
        for (x = num5; num6 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num6;
          if ((Color) pixels32[index] != Color.black && this.BitBltPixelNotAlpha(x, y))
          {
            this.UpdatePixel(x, y, pixels32[index]);
            ++num3;
          }
          ++num6;
        }
        ++num2;
      }
    }
    else
    {
      for (; num2 < height && y < this.Height; ++y)
      {
        int num6 = num4;
        for (x = num5; num6 < width && x < this.Width; ++x)
        {
          int index = num2 * width + num6;
          if (pixels32[index].a != (byte) 0)
          {
            this.UpdatePixel(x, y, pixels32[index]);
            ++num3;
          }
          ++num6;
        }
        ++num2;
      }
    }
    this.Apply();
    return num3;
  }

  public void BitBltBlood(Texture2D mask, int x, int y)
  {
    int num1 = 0;
    int num2 = 0;
    int height = mask.height;
    int width = mask.width;
    x -= width / 2;
    y -= height / 2;
    if (x < 0)
    {
      num1 -= x;
      x = 0;
    }
    if (y < 0)
    {
      num2 -= y;
      y = 0;
    }
    Color32[] pixels32;
    if (!ZMap.cachedPixels.TryGetValue(mask, out pixels32))
    {
      pixels32 = mask.GetPixels32();
      ZMap.cachedPixels.Add(mask, pixels32);
    }
    int num3 = num1;
    int num4 = x;
    for (; num2 < height && y < this.Height; ++y)
    {
      int num5 = num3;
      for (x = num4; num5 < width && x < this.Width; ++x)
      {
        int index = num2 * width + num5;
        if (pixels32[index].a != (byte) 0)
        {
          Color32 color32 = this.BitBltPixelColor(x, y);
          if (color32.a > (byte) 0 && ((int) color32.r < (int) pixels32[index].r || color32.b > (byte) 0 || color32.g > (byte) 0))
          {
            Color32 c = pixels32[index];
            c.a = color32.a;
            this.UpdatePixel(x, y, c);
          }
        }
        ++num5;
      }
      ++num2;
    }
    this.Apply();
  }

  public void Apply()
  {
    if (!this.game.isClient || this.game._resyncing)
      return;
    for (int index = 0; index < this.rawspriteColors.Count; ++index)
      this.rawspriteColors[index].Apply();
  }

  private ZCreature FindCreatureAtPoint(ZCreature creature, int x, int y, int mask)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, mask);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((ZComponent) creature == (object) null || (ZComponent) list[index] != (object) creature.colliderGameObject)
          return list[index].gameObjectLayer == 13 ? list[index].tower.creature : list[index].creature;
      }
    }
    this.world.listPool.ReturnList(list);
    return (ZCreature) null;
  }

  private bool PhysicsCollidePoint(
    ZCreature creature,
    int x,
    int y,
    int mask,
    bool collideWithThorns = true)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, mask);
    MyLocation myLocation = (ZComponent) creature != (object) null ? creature.position : MyLocation.zero;
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((ZComponent) creature == (object) null)
        {
          if (list[index].gameObjectLayer != 11 && list[index].gameObjectLayer != 9)
          {
            this.world.listPool.ReturnList(list);
            return true;
          }
        }
        else if (!((ZComponent) list[index] == (object) creature.colliderGameObject) && (!list[index].ghosted || !list[index].OverlapGhosting(x, y)) && (ZComponent.IsNull((ZComponent) creature.rider) || !((ZComponent) creature.rider.collider == (object) list[index])))
        {
          if ((ZComponent) creature.mount != (object) null && (ZComponent) creature.mount.collider == (object) list[index])
          {
            if (creature.velocity.y > 0)
              creature.Demount(false);
            this.world.listPool.ReturnList(list);
            return false;
          }
          if (list[index].gameObjectLayer == 11)
            list[index].effector?.EffectCreature(creature, false);
          else if (list[index].gameObjectLayer == 9)
          {
            list[index].effector?.EffectCreature(creature, false);
          }
          else
          {
            if (list[index].gameObjectLayer == 13)
            {
              int num = (ZComponent) list[index] != (object) creature.colliderGameObject ? 1 : 0;
              this.world.listPool.ReturnList(list);
              return num != 0;
            }
            if (list[index].gameObjectLayer == 15)
            {
              list[index].effector?.EffectCreature(creature, false);
              if (!ZComponent.IsNull((ZComponent) creature.rider))
                list[index].effector?.EffectCreature(creature.rider, false);
            }
          }
          ZCreature creature1 = list[index].creature;
          if (!ZComponent.IsNull((ZComponent) creature1))
          {
            if (creature1.spellEnum == SpellEnum.Sacrificial_Altar && (ZComponent) creature != (object) null && (creature.isPawn && creature.type != CreatureType.Tree) && creature.race != CreatureRace.Effector)
            {
              creature1.health += creature.health;
              if (creature1.health > creature1.maxHealth)
                creature1.health = creature1.maxHealth;
              creature1.parent.first()?.ReplenishUsedSpell(BookOf.Nothing);
              creature.health = 0;
              creature.DieWhenStopped(true);
              this.world.listPool.ReturnList(list);
              return true;
            }
            if (!((ZComponent) creature1.mount != (object) null) || !((ZComponent) creature != (object) null))
            {
              if (creature.team == creature1.team && myLocation == creature.position && (creature.mountable || creature1.mountable) && (creature.controllable && creature1.controllable && (creature.canMount || creature1.canMount)) && ((ZComponent) creature.tower == (object) null && (ZComponent) creature1.tower == (object) null))
              {
                if (!ZComponent.IsNull((ZComponent) creature.rider) || (ZComponent) creature.mount != (object) null || ((ZComponent) creature1.rider != (object) null || (ZComponent) creature1.mount != (object) null))
                {
                  this.world.listPool.ReturnList(list);
                  return true;
                }
                if (creature.mountable)
                {
                  if (creature1.isPawn && creature1.radius + 10 >= creature.radius)
                  {
                    this.world.listPool.ReturnList(list);
                    return true;
                  }
                  MyLocation position = creature1.position;
                  creature1.OnMount(creature);
                  creature1.mount = creature;
                  creature.rider = creature1;
                  creature1.RiderMoveToPosition = creature.position + Global.GetMountOffset(creature.transformscale, creature.type);
                  creature1.SetScale(creature.transformscale);
                  creature1.game.CreatureMoveSurroundings(position, creature1.radius, (ZMyCollider) null, false);
                }
                else
                {
                  if (creature.isPawn && creature.radius + 10 >= creature1.radius)
                  {
                    this.world.listPool.ReturnList(list);
                    return true;
                  }
                  if (creature.velocity.y > 0 || creature.position.y + creature.radius >= this.Height - 20)
                  {
                    this.world.listPool.ReturnList(list);
                    return false;
                  }
                  if (creature.velocity.y == 0 && !creature.flying)
                  {
                    this.world.listPool.ReturnList(list);
                    return true;
                  }
                  MyLocation position = creature.position;
                  creature.OnMount(creature1);
                  creature.RiderMoveToPosition = creature1.position + Global.GetMountOffset(creature1.transformscale, creature1.type);
                  creature.SetScale(creature1.transformscale);
                  creature.game.CreatureMoveSurroundings(position, creature.radius, (ZMyCollider) null, false);
                }
              }
              if ((ZComponent) creature != (object) null && creature1.race != CreatureRace.Effector && (creature.race != CreatureRace.Effector && !creature1.collider.ghosted) && MyLocation.Distance(creature1.position, creature.position) < (creature1.radius > creature.radius ? creature.radius - 3 : creature1.radius - 3))
              {
                if ((ZComponent) creature1 == (object) creature.mount)
                {
                  this.world.listPool.ReturnList(list);
                  return true;
                }
              }
              else
              {
                if (!collideWithThorns && (creature1.GetType() == typeof (ZCreatureThorn) || creature1.type == CreatureType.Map_Bottom))
                {
                  this.world.listPool.ReturnList(list);
                  return false;
                }
                if (list[index].gameObjectLayer != 9)
                {
                  this.world.listPool.ReturnList(list);
                  return true;
                }
              }
            }
          }
          else if (list[index].gameObjectLayer == 8)
          {
            this.world.listPool.ReturnList(list);
            return true;
          }
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  public bool TryMount(Creature creature, ZCreature c, int team)
  {
    return !((ZComponent) c.mount != (object) null) && team == c.team && (creature.mountable || c.mountable) && ((creature.canMount || c.canMount) && ((ZComponent) c.tower == (object) null && !((ZComponent) c.rider != (object) null))) && (!((ZComponent) c.mount != (object) null) && creature.mountable && (!c.isPawn || c.radius + 10 < creature.radius));
  }

  public bool TryMount(ZCreature creature, ZCreature c, bool justReturn = false)
  {
    if ((ZComponent) c.mount != (object) null || (ZComponent) creature == (object) null || creature.team != c.team || (!creature.mountable && !c.mountable || (!creature.controllable || !c.controllable)) || (!creature.canMount && !c.canMount || (!((ZComponent) creature.tower == (object) null) || !((ZComponent) c.tower == (object) null)) || (!ZComponent.IsNull((ZComponent) creature.rider) || (ZComponent) creature.mount != (object) null || ((ZComponent) c.rider != (object) null || (ZComponent) c.mount != (object) null))))
      return false;
    if (creature.mountable)
    {
      if (c.isPawn && c.radius + 10 >= creature.radius)
        return false;
      if (justReturn)
        return true;
      MyLocation position = c.position;
      c.OnMount(creature);
      c.mount = creature;
      creature.rider = c;
      c.RiderMoveToPosition = creature.position + Global.GetMountOffset(creature.transformscale, creature.type);
      c.SetScale(creature.transformscale);
      c.game.CreatureMoveSurroundings(position, c.radius, (ZMyCollider) null, false);
    }
    else
    {
      if (creature.isPawn && creature.radius + 10 >= c.radius || (creature.velocity.y > 0 || creature.position.y + creature.radius >= this.Height - 20) || creature.velocity.y == 0 && !creature.flying)
        return false;
      if (justReturn)
        return true;
      MyLocation position = creature.position;
      creature.OnMount(c);
      creature.RiderMoveToPosition = c.position + Global.GetMountOffset(c.transformscale, c.type);
      creature.SetScale(c.transformscale);
      creature.game.CreatureMoveSurroundings(position, creature.radius, (ZMyCollider) null, false);
    }
    return false;
  }

  public bool SpellCheckEffectors(ZCreature creature, ZSpell spell, int x, int y)
  {
    if ((ZComponent) spell == (object) null)
      return false;
    List<ZMyCollider> list = this.world.OverlapCircleAll(new Point(x, y), spell.radius, spell.collider, 3072);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if (list[index].gameObjectLayer == 10)
        {
          if (spell.spellEnum != SpellEnum.Flame_Wall)
          {
            ZEffector effector = list[index].effector;
            if (effector.type != EffectorType.Fire_Shield || !((ZComponent) creature == (object) effector.whoSummoned))
            {
              effector.EffectSpell(spell);
              if (effector.type == EffectorType.Static_Ball)
              {
                this.world.listPool.ReturnList(list);
                return true;
              }
            }
          }
        }
        else if (list[index].gameObjectLayer == 11 && spell.spellEnum != SpellEnum.Flame_Wall)
        {
          ZEffector effector = list[index].effector;
          if (effector.type != EffectorType.Fire_Shield || !((ZComponent) creature == (object) effector.whoSummoned))
            effector.EffectSpell(spell);
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  public bool CreatureCheckEffectors(ZCreature creature, int x, int y)
  {
    if ((ZComponent) creature == (object) null)
      return false;
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, 2560);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if (list[index].gameObjectLayer == 9)
          list[index].effector.EffectCreature(creature, false);
        else if (list[index].gameObjectLayer == 11)
          list[index].effector.EffectEntity((ZEntity) creature);
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  private bool SpellPhysicsCollidePoint(ZCreature creature, int x, int y, int mask)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, mask);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((!list[index].ghosted || !list[index].OverlapGhosting(x, y)) && ((ZComponent) creature == (object) null || (ZComponent) list[index] != (object) creature.colliderGameObject))
        {
          this.world.listPool.ReturnList(list);
          return true;
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  private bool LeafPhysicsCollidePoint(ZCreature creature, int x, int y, int mask)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, mask);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((!list[index].ghosted || !list[index].OverlapGhosting(x, y)) && (list[index].layer != 512 || !((ZComponent) list[index].effector == (object) null) && list[index].effector.type == EffectorType.AutumnLeaves) && ((ZComponent) creature == (object) null || (ZComponent) list[index] != (object) creature.colliderGameObject))
        {
          this.world.listPool.ReturnList(list);
          return true;
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  private bool SpellPhysicsCollidePointIgnoreSelf(ZMyCollider ignore, int x, int y, int mask)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, mask);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((!list[index].ghosted || !list[index].OverlapGhosting(x, y)) && (ZComponent) list[index] != (object) ignore)
        {
          this.world.listPool.ReturnList(list);
          return true;
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  private bool SpellPhysicsCollidePointUndeadOnly(
    ZCreature creature,
    ZSpell spell,
    int x,
    int y,
    int mask)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, mask);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((!list[index].ghosted || !list[index].OverlapGhosting(x, y)) && ((ZComponent) creature == (object) null || (ZComponent) list[index] != (object) creature.colliderGameObject))
        {
          ZCreature creature1 = list[index].creature;
          if ((ZComponent) creature1 == (object) null || (ZComponent) creature1.tower != (object) null)
          {
            this.world.listPool.ReturnList(list);
            return true;
          }
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return false;
  }

  public ZCreature PhysicsCollideCreatureCircle(
    ZCreature creature,
    int x,
    int y,
    int radius,
    int maskExtra = 0)
  {
    List<ZMyCollider> list = this.world.OverlapCircleAll(new Point(x, y), radius, creature?.collider, Inert.mask_movement_NoEffector | maskExtra);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((ZComponent) creature == (object) null || (ZComponent) list[index] != (object) creature.colliderGameObject)
        {
          if (list[index].gameObjectLayer == 8 || list[index].gameObjectLayer == 16)
          {
            ZCreature creature1 = list[index].creature;
            if (!ZComponent.IsNull((ZComponent) creature1))
            {
              this.world.listPool.ReturnList(list);
              return creature1;
            }
          }
          else if (list[index].gameObjectLayer == 13)
          {
            ZTower tower = list[index].tower;
            if (!ZComponent.IsNull((ZComponent) tower))
            {
              this.world.listPool.ReturnList(list);
              return tower.creature;
            }
          }
          this.world.listPool.ReturnList(list);
          return (ZCreature) null;
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return (ZCreature) null;
  }

  public ZCreature PhysicsCollideCreature(
    ZCreature creature,
    int x,
    int y,
    int maskExtra = 0)
  {
    List<ZMyCollider> list = this.world.OverlapPointAll(x, y, Inert.mask_movement_NoEffector | maskExtra);
    if (list.Count > 0)
    {
      for (int index = list.Count - 1; index >= 0; --index)
      {
        if ((ZComponent) creature == (object) null || (ZComponent) list[index] != (object) creature.colliderGameObject)
        {
          if (list[index].gameObjectLayer == 8 || list[index].gameObjectLayer == 16)
          {
            ZCreature creature1 = list[index].creature;
            if (!ZComponent.IsNull((ZComponent) creature1))
            {
              this.world.listPool.ReturnList(list);
              return creature1;
            }
          }
          else if (list[index].gameObjectLayer == 13)
          {
            ZTower tower = list[index].tower;
            if (!ZComponent.IsNull((ZComponent) tower))
            {
              this.world.listPool.ReturnList(list);
              return tower.creature;
            }
          }
          this.world.listPool.ReturnList(list);
          return (ZCreature) null;
        }
      }
    }
    this.world.listPool.ReturnList(list);
    return (ZCreature) null;
  }

  public bool CheckTexutureOnlyMap(int x0, int y0, Texture2D tex)
  {
    Color32[] pixels32 = ZMap.GetPixels32(tex);
    int index = 0;
    int num1 = x0 - tex.width / 2;
    int num2 = y0 - tex.height / 2;
    int num3 = num1 + tex.width;
    int num4 = num2 + tex.height;
    if (num1 < 0 || num2 < 0 || (num3 > this.Width || num4 > this.Height))
      return false;
    for (int y = num2; y < num4; ++y)
    {
      for (int x = num1; x < num3; ++x)
      {
        if (pixels32[index].a != (byte) 0 && !this.CheckPositionOnlyMap(x, y))
          return false;
        ++index;
      }
    }
    return true;
  }

  public bool CheckTexuture(
    int x0,
    int y0,
    Texture2D tex,
    bool includeTerrain,
    ZCreature ceature,
    bool collideWithThorn = true,
    bool allowOutOfBounds = false)
  {
    Color32[] pixels32 = ZMap.GetPixels32(tex);
    int index = 0;
    int num1 = x0 - tex.width / 2;
    int num2 = y0 - tex.height / 2;
    int num3 = num1 + tex.width;
    int num4 = num2 + tex.height;
    if (!allowOutOfBounds)
    {
      if (num1 < 0 || num2 < 0 || (num3 > this.Width || num4 > this.Height))
        return false;
    }
    else if (num2 < 0 || num4 > this.Height)
      return false;
    if (includeTerrain)
    {
      for (int y = num2; y < num4; ++y)
      {
        for (int x = num1; x < num3; ++x)
        {
          if (pixels32[index].a != (byte) 0 && this.PixelNotAlpha(x, y, ceature, Inert.mask_movement_NoEffector, collideWithThorn))
            return false;
          ++index;
        }
      }
    }
    else
    {
      for (int y = num2; y < num4; ++y)
      {
        for (int x = num1; x < num3; ++x)
        {
          if (pixels32[index].a != (byte) 0 && this.PhysicsCollidePoint(ceature, x, y, Inert.mask_movement_NoEffector, collideWithThorn))
            return false;
          ++index;
        }
      }
    }
    return true;
  }

  public bool CheckTexutureButterflyJar(
    int x0,
    int y0,
    Texture2D tex,
    bool includeTerrain,
    ZCreature ceature,
    bool collideWithThorn = true,
    bool allowOutOfBounds = false)
  {
    Color32[] pixels32 = ZMap.GetPixels32(tex);
    int index = 0;
    int num1 = 0;
    int num2 = 0;
    int num3 = x0 - tex.width / 2;
    int num4 = y0 - tex.height / 2;
    int num5 = num3 + tex.width;
    int num6 = num4 + tex.height;
    if (!allowOutOfBounds)
    {
      if (num3 < 0 || num4 < 0 || (num5 > this.Width || num6 > this.Height))
        return false;
    }
    else if (num4 < 0 || num6 > this.Height)
      return false;
    if (includeTerrain)
    {
      int y = num4;
      while (y < num6)
      {
        int x = num3;
        while (x < num5)
        {
          if (pixels32[index].a != (byte) 0 && (num2 < 4 || num2 > 25 || (num1 < 5 || num1 > 25)) && this.PixelNotAlpha(x, y, ceature, Inert.mask_movement_NoEffector, collideWithThorn))
            return false;
          ++index;
          ++x;
          ++num1;
        }
        ++y;
        ++num2;
      }
    }
    else
    {
      int y = num4;
      while (y < num6)
      {
        int x = num3;
        while (x < num5)
        {
          if (pixels32[index].a != (byte) 0 && (num2 < 4 || num2 > 25 || (num1 < 5 || num1 > 25)) && this.PhysicsCollidePoint(ceature, x, y, Inert.mask_movement_NoEffector, collideWithThorn))
            return false;
          ++index;
          ++x;
          ++num1;
        }
        ++y;
        ++num2;
      }
    }
    return true;
  }

  public bool CheckCircleAllowOutOfBounds(
    int x0,
    int y0,
    int radius,
    ZCreature creature,
    int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x1 = x0 - num1;
      int y1 = y0 + num2;
      int num6 = x0 + num1;
      if (y1 >= 0 && y1 < this.Height)
      {
        for (; x1 <= num6; ++x1)
        {
          if (x1 >= 0 && x1 < this.Width && this.PixelNotAlpha(x1, y1, creature, mask, true))
            return false;
        }
      }
      int x2 = x0 - num2;
      int y2 = y0 + num1;
      int num7 = x0 + num2;
      if (y2 >= 0 && y2 < this.Height)
      {
        for (; x2 <= num7; ++x2)
        {
          if (x2 >= 0 && x2 < this.Width && this.PixelNotAlpha(x2, y2, creature, mask, true))
            return false;
        }
      }
      int x3 = x0 - num1;
      int y3 = y0 - num2;
      int num8 = x0 + num1;
      if (y3 >= 0 && y3 < this.Height)
      {
        for (; x3 <= num8; ++x3)
        {
          if (x3 >= 0 && x3 < this.Width && this.PixelNotAlpha(x3, y3, creature, mask, true))
            return false;
        }
      }
      int x4 = x0 - num2;
      int y4 = y0 - num1;
      int num9 = x0 + num2;
      if (y4 >= 0 && y4 < this.Height)
      {
        for (; x4 <= num9; ++x4)
        {
          if (x4 >= 0 && x4 < this.Width && this.PixelNotAlpha(x4, y4, creature, mask, true))
            return false;
        }
      }
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return true;
  }

  public bool CheckCircle(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x1 = x0 - num1;
      int y1 = y0 + num2;
      int num6 = x0 + num1;
      if (y1 < 0 || y1 >= this.Height)
        return false;
      for (; x1 <= num6; ++x1)
      {
        if (x1 < 0 || x1 >= this.Width || this.PixelNotAlpha(x1, y1, creature, mask, true))
          return false;
      }
      int x2 = x0 - num2;
      int y2 = y0 + num1;
      int num7 = x0 + num2;
      if (y2 < 0 || y2 >= this.Height)
        return false;
      for (; x2 <= num7; ++x2)
      {
        if (x2 < 0 || x2 >= this.Width || this.PixelNotAlpha(x2, y2, creature, mask, true))
          return false;
      }
      int x3 = x0 - num1;
      int y3 = y0 - num2;
      int num8 = x0 + num1;
      if (y3 < 0 || y3 >= this.Height)
        return false;
      for (; x3 <= num8; ++x3)
      {
        if (x3 < 0 || x3 >= this.Width || this.PixelNotAlpha(x3, y3, creature, mask, true))
          return false;
      }
      int x4 = x0 - num2;
      int y4 = y0 - num1;
      int num9 = x0 + num2;
      if (y4 < 0 || y4 >= this.Height)
        return false;
      for (; x4 <= num9; ++x4)
      {
        if (x4 < 0 || x4 >= this.Width || this.PixelNotAlpha(x4, y4, creature, mask, true))
          return false;
      }
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return true;
  }

  public bool CheckCircleOnlyEntities(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x1 = x0 - num1;
      int y1 = y0 + num2;
      int num6 = x0 + num1;
      if (y1 < 0 || y1 >= this.Height)
        return false;
      for (; x1 <= num6; ++x1)
      {
        if (x1 < 0 || x1 >= this.Width || this.PhysicsCollidePoint(creature, x1, y1, mask, true))
          return false;
      }
      int x2 = x0 - num2;
      int y2 = y0 + num1;
      int num7 = x0 + num2;
      if (y2 < 0 || y2 >= this.Height)
        return false;
      for (; x2 <= num7; ++x2)
      {
        if (x2 < 0 || x2 >= this.Width || this.PhysicsCollidePoint(creature, x2, y2, mask, true))
          return false;
      }
      int x3 = x0 - num1;
      int y3 = y0 - num2;
      int num8 = x0 + num1;
      if (y3 < 0 || y3 >= this.Height)
        return false;
      for (; x3 <= num8; ++x3)
      {
        if (x3 < 0 || x3 >= this.Width || this.PhysicsCollidePoint(creature, x3, y3, mask, true))
          return false;
      }
      int x4 = x0 - num2;
      int y4 = y0 - num1;
      int num9 = x0 + num2;
      if (y4 < 0 || y4 >= this.Height)
        return false;
      for (; x4 <= num9; ++x4)
      {
        if (x4 < 0 || x4 >= this.Width || this.PhysicsCollidePoint(creature, x4, y4, mask, true))
          return false;
      }
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return true;
  }

  public bool CheckCircleOnlyMap(int x0, int y0, int radius)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x1 = x0 - num1;
      int y1 = y0 + num2;
      int num6 = x0 + num1;
      if (y1 < 0 || y1 >= this.Height)
        return false;
      for (; x1 <= num6; ++x1)
      {
        if (x1 < 0 || x1 >= this.Width || !this.CheckPositionOnlyMap(x1, y1))
          return false;
      }
      int x2 = x0 - num2;
      int y2 = y0 + num1;
      int num7 = x0 + num2;
      if (y2 < 0 || y2 >= this.Height)
        return false;
      for (; x2 <= num7; ++x2)
      {
        if (x2 < 0 || x2 >= this.Width || !this.CheckPositionOnlyMap(x2, y2))
          return false;
      }
      int x3 = x0 - num1;
      int y3 = y0 - num2;
      int num8 = x0 + num1;
      if (y3 < 0 || y3 >= this.Height)
        return false;
      for (; x3 <= num8; ++x3)
      {
        if (x3 < 0 || x3 >= this.Width || !this.CheckPositionOnlyMap(x3, y3))
          return false;
      }
      int x4 = x0 - num2;
      int y4 = y0 - num1;
      int num9 = x0 + num2;
      if (y4 < 0 || y4 >= this.Height)
        return false;
      for (; x4 <= num9; ++x4)
      {
        if (x4 < 0 || x4 >= this.Width || !this.CheckPositionOnlyMap(x4, y4))
          return false;
      }
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return true;
  }

  public void CallOfTheVoid(int x0, int y0, int radius)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x1 = x0 - num1;
      int y1 = y0 + num2;
      int num6 = x0 + num1;
      if (y1 >= 0 && y1 < this.Height)
      {
        for (; x1 <= num6; ++x1)
        {
          if (x1 >= 0 && x1 < this.Width && this.PixelNotTransparent(x1, y1))
            this.UpdatePixel(x1, y1, RotateImage.CallOfTheVoid(this.GetPixel(x1, y1)));
        }
      }
      int x2 = x0 - num2;
      int y2 = y0 + num1;
      int num7 = x0 + num2;
      if (y2 >= 0 && y2 < this.Height)
      {
        for (; x2 <= num7; ++x2)
        {
          if (x2 >= 0 && x2 < this.Width && this.PixelNotTransparent(x2, y2))
            this.UpdatePixel(x2, y2, RotateImage.CallOfTheVoid(this.GetPixel(x2, y2)));
        }
      }
      int x3 = x0 - num1;
      int y3 = y0 - num2;
      int num8 = x0 + num1;
      if (y3 >= 0 && y3 < this.Height)
      {
        for (; x3 <= num8; ++x3)
        {
          if (x3 >= 0 && x3 < this.Width && this.PixelNotTransparent(x3, y3))
            this.UpdatePixel(x3, y3, RotateImage.CallOfTheVoid(this.GetPixel(x3, y3)));
        }
      }
      int x4 = x0 - num2;
      int y4 = y0 - num1;
      int num9 = x0 + num2;
      if (y4 >= 0 && y4 < this.Height)
      {
        for (; x4 <= num9; ++x4)
        {
          if (x4 >= 0 && x4 < this.Width && this.PixelNotTransparent(x4, y4))
            this.UpdatePixel(x4, y4, RotateImage.CallOfTheVoid(this.GetPixel(x4, y4)));
        }
      }
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    this.Apply();
  }

  public Coords CheckTopRight(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 + num2;
      int y = y0 + num1;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckRightTop(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 + num1;
      int y = y0 + num2;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckRightBottom(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 + num1;
      int y = y0 - num2;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckBottomRight(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 + num2;
      int y = y0 - num1;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckRightBottom_FromTop(
    int x0,
    int y0,
    int radius,
    ZCreature creature,
    int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 + num1;
      int y = y0 - num2;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        --num1;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        ++num2;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckBottomLeft(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 - num2;
      int y = y0 - num1;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckBottomLeft_FromTop(
    int x0,
    int y0,
    int radius,
    ZCreature creature,
    int mask)
  {
    int num1 = 0;
    int num2 = radius - 1;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num2 >= num1)
    {
      int x = x0 - num2;
      int y = y0 - num1;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num1;
        num5 += num3;
        num3 += 2;
      }
      if (num5 > 0)
      {
        --num2;
        num4 += 2;
        num5 += (-radius << 1) + num4;
      }
    }
    return (Coords) null;
  }

  public Coords CheckLeftBottom(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 - num1;
      int y = y0 - num2;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckLeftTop(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 - num1;
      int y = y0 + num2;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords CheckTopLeft(int x0, int y0, int radius, ZCreature creature, int mask)
  {
    int num1 = radius - 1;
    int num2 = 0;
    int num3 = 1;
    int num4 = 1;
    int num5 = num3 - (radius << 1);
    while (num1 >= num2)
    {
      int x = x0 - num2;
      int y = y0 + num1;
      if (x >= this.Width || x < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      if (this.PixelNotAlpha(x, y, creature, mask, true))
        return new Coords(x, y);
      if (num5 <= 0)
      {
        ++num2;
        num5 += num4;
        num4 += 2;
      }
      if (num5 > 0)
      {
        --num1;
        num3 += 2;
        num5 += (-radius << 1) + num3;
      }
    }
    return (Coords) null;
  }

  public Coords downCastLightning(int x, int y, ZCreature c, ZSpell spell, int mask)
  {
    for (; y >= 0; --y)
    {
      if (x >= 0 && x < this.Width && (y >= 0 && y < this.Height))
      {
        if (!this.CheckClampedPixel(x, y))
          return new Coords(x, y);
        ZCreature creatureAtPoint = this.FindCreatureAtPoint((ZCreature) null, x, y, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
        {
          spell.position = new MyLocation(x, y);
          spell.Damage(creatureAtPoint);
          spell.isDead = true;
          if ((ZComponent) creatureAtPoint.tower == (object) null)
          {
            creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(x, y), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
            creatureAtPoint.StartMoving(false);
          }
          return new Coords(x, y, creatureAtPoint);
        }
      }
    }
    return (Coords) null;
  }

  public ZCreature bresenhamsLineCastOnlyCreatures(
    Coords start,
    Coords end,
    ZCreature c,
    int mask)
  {
    int num1 = Mathf.Abs(end.y - start.y) > Mathf.Abs(end.x - start.x) ? 1 : 0;
    int num2 = num1 != 0 ? start.y : start.x;
    int num3 = num1 != 0 ? start.x : start.y;
    int num4 = num1 != 0 ? end.y : end.x;
    int num5 = num1 != 0 ? end.x : end.y;
    int num6 = num2 > num4 ? 1 : 0;
    int num7 = num6 != 0 ? num4 : num2;
    int num8 = num6 != 0 ? num2 : num4;
    int num9 = num6 != 0 ? num5 : num3;
    int num10 = num6 != 0 ? num3 : num5;
    int num11 = num8 - num7;
    int num12 = Mathf.Abs(num10 - num9);
    int num13 = num9 < num10 ? 1 : -1;
    int num14 = num11 / 2;
    int num15 = num9;
    if (num1 != 0)
    {
      if (num7 == end.y)
      {
        int num16 = num8;
        int y1 = end.y;
        int x = num10;
        if (num16 >= this.Height || num16 < 0 || (x < 0 || x >= this.Width))
          return (ZCreature) null;
        for (int y2 = num16; y2 > y1 && y2 >= 0; --y2)
        {
          ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, x, y2, mask);
          if ((ZComponent) creatureAtPoint != (object) null)
            return creatureAtPoint;
          num14 -= num12;
          if (num14 < 0)
          {
            x -= num13;
            if (x >= 0 && x < this.Width)
              num14 += num11;
            else
              break;
          }
        }
      }
      else
      {
        if (num7 >= this.Height || num7 < 0 || (num15 < 0 || num15 >= this.Width))
          return (ZCreature) null;
        for (int y = num7; y <= num8 && y < this.Height; ++y)
        {
          ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, num15, y, mask);
          if ((ZComponent) creatureAtPoint != (object) null)
            return creatureAtPoint;
          num14 -= num12;
          if (num14 < 0)
          {
            num15 += num13;
            if (num15 >= 0 && num15 < this.Width)
              num14 += num11;
            else
              break;
          }
        }
      }
    }
    else if (num7 == end.x)
    {
      int num16 = num8;
      int x1 = end.x;
      int y = num10;
      if (num16 >= this.Width || num16 < 0 || (y < 0 || y >= this.Height))
        return (ZCreature) null;
      for (int x2 = num16; x2 > x1 && x2 >= 0; --x2)
      {
        ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, x2, y, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
          return creatureAtPoint;
        num14 -= num12;
        if (num14 < 0)
        {
          y -= num13;
          if (y >= 0 && y < this.Height)
            num14 += num11;
          else
            break;
        }
      }
    }
    else
    {
      if (num7 >= this.Width || num7 < 0 || (num15 < 0 || num15 >= this.Height))
        return (ZCreature) null;
      for (int x = num7; x <= num8 && x < this.Width; ++x)
      {
        ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, x, num15, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
          return creatureAtPoint;
        num14 -= num12;
        if (num14 < 0)
        {
          num15 += num13;
          if (num15 >= 0 && num15 < this.Height)
            num14 += num11;
          else
            break;
        }
      }
    }
    return (ZCreature) null;
  }

  public Coords bresenhamsLineCast(
    Coords start,
    Coords end,
    ZCreature c,
    ZSpell spell,
    int mask)
  {
    int num1 = Mathf.Abs(end.y - start.y) > Mathf.Abs(end.x - start.x) ? 1 : 0;
    int num2 = num1 != 0 ? start.y : start.x;
    int num3 = num1 != 0 ? start.x : start.y;
    int num4 = num1 != 0 ? end.y : end.x;
    int num5 = num1 != 0 ? end.x : end.y;
    int num6 = num2 > num4 ? 1 : 0;
    int num7 = num6 != 0 ? num4 : num2;
    int num8 = num6 != 0 ? num2 : num4;
    int num9 = num6 != 0 ? num5 : num3;
    int num10 = num6 != 0 ? num3 : num5;
    int num11 = num8 - num7;
    int num12 = Mathf.Abs(num10 - num9);
    int num13 = num9 < num10 ? 1 : -1;
    int num14 = num11 / 2;
    int num15 = num9;
    if (num1 != 0)
    {
      if (num7 == end.y)
      {
        int num16 = num8;
        int y = end.y;
        int num17 = num10;
        if (num16 >= this.Height || num16 < 0 || (num17 < 0 || num17 >= this.Width))
          return (Coords) null;
        for (int index = num16; index > y && index >= 0; --index)
        {
          if (!this.CheckClampedPixel(num17, index))
          {
            if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              spell.ApplyExplosionForce(new MyLocation(num17, index), 0, true, (ISpellBridge) null, (ZCreature) null);
            return new Coords(num17, index);
          }
          ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, num17, index, mask);
          if ((ZComponent) creatureAtPoint != (object) null)
          {
            if ((ZComponent) spell != (object) null)
            {
              spell.position = new MyLocation(num17, index);
              if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              {
                spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
              }
              else
              {
                spell.Damage(creatureAtPoint);
                if ((ZComponent) creatureAtPoint.tower == (object) null)
                {
                  creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(num17, index), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                  creatureAtPoint.StartMoving(false);
                }
              }
            }
            return new Coords(num17, index);
          }
          num14 -= num12;
          if (num14 < 0)
          {
            num17 -= num13;
            if (num17 >= 0 && num17 < this.Width)
              num14 += num11;
            else
              break;
          }
        }
      }
      else
      {
        if (num7 >= this.Height || num7 < 0 || (num15 < 0 || num15 >= this.Width))
          return (Coords) null;
        for (int index = num7; index <= num8 && index < this.Height; ++index)
        {
          if (!this.CheckClampedPixel(num15, index))
          {
            if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              spell.ApplyExplosionForce(new MyLocation(num15, index), 0, true, (ISpellBridge) null, (ZCreature) null);
            return new Coords(num15, index);
          }
          ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, num15, index, mask);
          if ((ZComponent) creatureAtPoint != (object) null)
          {
            if ((ZComponent) spell != (object) null)
            {
              spell.position = new MyLocation(num15, index);
              if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              {
                spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
              }
              else
              {
                spell.Damage(creatureAtPoint);
                if ((ZComponent) creatureAtPoint.tower == (object) null)
                {
                  creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(num15, index), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                  creatureAtPoint.StartMoving(false);
                }
              }
            }
            return new Coords(num15, index);
          }
          num14 -= num12;
          if (num14 < 0)
          {
            num15 += num13;
            if (num15 >= 0 && num15 < this.Width)
              num14 += num11;
            else
              break;
          }
        }
      }
    }
    else if (num7 == end.x)
    {
      int num16 = num8;
      int x = end.x;
      int num17 = num10;
      if (num16 >= this.Width || num16 < 0 || (num17 < 0 || num17 >= this.Height))
        return (Coords) null;
      for (int index = num16; index > x && index >= 0; --index)
      {
        if (!this.CheckClampedPixel(index, num17))
        {
          if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            spell.ApplyExplosionForce(new MyLocation(index, num17), 0, true, (ISpellBridge) null, (ZCreature) null);
          return new Coords(index, num17);
        }
        ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, index, num17, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
        {
          if ((ZComponent) spell != (object) null)
          {
            spell.position = new MyLocation(index, num17);
            if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            {
              spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
            }
            else
            {
              spell.Damage(creatureAtPoint);
              if ((ZComponent) creatureAtPoint.tower == (object) null)
              {
                creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(index, num17), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                creatureAtPoint.StartMoving(false);
              }
            }
          }
          return new Coords(index, num17);
        }
        num14 -= num12;
        if (num14 < 0)
        {
          num17 -= num13;
          if (num17 >= 0 && num17 < this.Height)
            num14 += num11;
          else
            break;
        }
      }
    }
    else
    {
      if (num7 >= this.Width || num7 < 0 || (num15 < 0 || num15 >= this.Height))
        return (Coords) null;
      for (int index = num7; index <= num8 && index < this.Width; ++index)
      {
        if (!this.CheckClampedPixel(index, num15))
        {
          if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            spell.ApplyExplosionForce(new MyLocation(index, num15), 0, true, (ISpellBridge) null, (ZCreature) null);
          return new Coords(index, num15);
        }
        ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, index, num15, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
        {
          if ((ZComponent) spell != (object) null)
          {
            spell.position = new MyLocation(index, num15);
            if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            {
              spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
            }
            else
            {
              spell.Damage(creatureAtPoint);
              if ((ZComponent) creatureAtPoint.tower == (object) null)
              {
                creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(index, num15), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                creatureAtPoint.StartMoving(false);
              }
            }
          }
          return new Coords(index, num15);
        }
        num14 -= num12;
        if (num14 < 0)
        {
          num15 += num13;
          if (num15 >= 0 && num15 < this.Height)
            num14 += num11;
          else
            break;
        }
      }
    }
    return (Coords) null;
  }

  public Coords bresenhamsCircleCast(
    Coords start,
    Coords end,
    ZCreature c,
    int mask,
    int radius)
  {
    List<Coords> outlineArray = MapGenerator.getOutlineArray(radius);
    int num1 = ((FixedInt.Create(360) - (Inert.AngleOfVelocity(new MyLocation(end.x, end.y) - new MyLocation(start.x, start.y)) - FixedInt.Create(90))) * FixedInt.ThreeSixtyBy1 * outlineArray.Count - radius).ToInt();
    if (num1 < 0)
      num1 += outlineArray.Count;
    int num2 = Mathf.Abs(end.y - start.y) > Mathf.Abs(end.x - start.x) ? 1 : 0;
    int num3 = num2 != 0 ? start.y : start.x;
    int num4 = num2 != 0 ? start.x : start.y;
    int num5 = num2 != 0 ? end.y : end.x;
    int num6 = num2 != 0 ? end.x : end.y;
    int num7 = num3 > num5 ? 1 : 0;
    int num8 = num7 != 0 ? num5 : num3;
    int num9 = num7 != 0 ? num3 : num5;
    int num10 = num7 != 0 ? num6 : num4;
    int num11 = num7 != 0 ? num4 : num6;
    int num12 = num9 - num8;
    int num13 = Mathf.Abs(num11 - num10);
    int num14 = num10 < num11 ? 1 : -1;
    int num15 = num12 / 2;
    int num16 = num10;
    if (num2 != 0)
    {
      if (num8 == end.y)
      {
        int num17 = num9;
        int y = end.y;
        int num18 = num11;
        for (int index1 = num17; index1 > y && index1 >= 0; --index1)
        {
          for (int index2 = 0; index2 < radius * 2; ++index2)
          {
            if (!this.CheckPositionOnlyMap(num18 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y))
              return new Coords(num18 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y);
            if ((ZComponent) this.FindCreatureAtPoint(c, num18 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y, mask) != (object) null)
              return new Coords(num18 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y);
          }
          num15 -= num13;
          if (num15 < 0)
          {
            num18 -= num14;
            if (num18 >= 0 && num18 < this.Width)
              num15 += num12;
            else
              break;
          }
        }
      }
      else
      {
        for (int index1 = num8; index1 <= num9 && index1 < this.Height; ++index1)
        {
          for (int index2 = 0; index2 < radius * 2; ++index2)
          {
            if (!this.CheckPositionOnlyMap(num16 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y))
              return new Coords(num16 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y);
            if ((ZComponent) this.FindCreatureAtPoint(c, num16 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y, mask) != (object) null)
              return new Coords(num16 + outlineArray[(num1 + index2) % outlineArray.Count].x, index1 + outlineArray[(num1 + index2) % outlineArray.Count].y);
          }
          num15 -= num13;
          if (num15 < 0)
          {
            num16 += num14;
            if (num16 >= 0 && num16 < this.Width)
              num15 += num12;
            else
              break;
          }
        }
      }
    }
    else if (num8 == end.x)
    {
      int num17 = num9;
      int x = end.x;
      int num18 = num11;
      for (int index1 = num17; index1 > x && index1 >= 0; --index1)
      {
        for (int index2 = 0; index2 < radius * 2; ++index2)
        {
          if (!this.CheckPositionOnlyMap(index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num18 + outlineArray[(num1 + index2) % outlineArray.Count].y))
            return new Coords(index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num18 + outlineArray[(num1 + index2) % outlineArray.Count].y);
          if ((ZComponent) this.FindCreatureAtPoint(c, index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num18 + outlineArray[(num1 + index2) % outlineArray.Count].y, mask) != (object) null)
            return new Coords(index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num18 + outlineArray[(num1 + index2) % outlineArray.Count].y);
        }
        num15 -= num13;
        if (num15 < 0)
        {
          num18 -= num14;
          if (num18 >= 0 && num18 < this.Height)
            num15 += num12;
          else
            break;
        }
      }
    }
    else
    {
      for (int index1 = num8; index1 <= num9 && index1 < this.Width; ++index1)
      {
        for (int index2 = 0; index2 < radius * 2; ++index2)
        {
          if (!this.CheckPositionOnlyMap(index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num16 + outlineArray[(num1 + index2) % outlineArray.Count].y))
            return new Coords(index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num16 + outlineArray[(num1 + index2) % outlineArray.Count].y);
          if ((ZComponent) this.FindCreatureAtPoint(c, index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num16 + outlineArray[(num1 + index2) % outlineArray.Count].y, mask) != (object) null)
            return new Coords(index1 + outlineArray[(num1 + index2) % outlineArray.Count].x, num16 + outlineArray[(num1 + index2) % outlineArray.Count].y);
        }
        num15 -= num13;
        if (num15 < 0)
        {
          num16 += num14;
          if (num16 >= 0 && num16 < this.Height)
            num15 += num12;
          else
            break;
        }
      }
    }
    return (Coords) null;
  }

  public Coords GetLineByLength(Coords start, Coords end, int count)
  {
    int num1 = Mathf.Abs(end.y - start.y) > Mathf.Abs(end.x - start.x) ? 1 : 0;
    int num2 = num1 != 0 ? start.y : start.x;
    int num3 = num1 != 0 ? start.x : start.y;
    int num4 = num1 != 0 ? end.y : end.x;
    int num5 = num1 != 0 ? end.x : end.y;
    int num6 = num2 > num4 ? 1 : 0;
    int num7 = num6 != 0 ? num4 : num2;
    int num8 = num6 != 0 ? num2 : num4;
    int num9 = num6 != 0 ? num5 : num3;
    int num10 = num6 != 0 ? num3 : num5;
    int num11 = num8 - num7;
    int num12 = Mathf.Abs(num10 - num9);
    int num13 = num9 < num10 ? 1 : -1;
    int num14 = num11 / 2;
    int num15 = num9;
    if (num1 != 0)
    {
      if (num7 == end.y)
      {
        int num16 = num8;
        int y1 = end.y;
        int x = num10;
        if (num16 >= this.Height || num16 < 0 || (x < 0 || x >= this.Width))
          return (Coords) null;
        for (int y2 = num16; y2 > y1 && y2 >= 0; --y2)
        {
          num14 -= num12;
          if (num14 < 0)
          {
            x -= num13;
            if (x >= 0 && x < this.Width)
              num14 += num11;
            else
              break;
          }
          --count;
          if (count <= 0)
            return new Coords(x, y2);
        }
      }
      else
      {
        if (num7 >= this.Height || num7 < 0 || (num15 < 0 || num15 >= this.Width))
          return (Coords) null;
        for (int y = num7; y <= num8 && y < this.Height; ++y)
        {
          num14 -= num12;
          if (num14 < 0)
          {
            num15 += num13;
            if (num15 >= 0 && num15 < this.Width)
              num14 += num11;
            else
              break;
          }
          --count;
          if (count <= 0)
            return new Coords(num15, y);
        }
      }
    }
    else if (num7 == end.x)
    {
      int num16 = num8;
      int x1 = end.x;
      int y = num10;
      if (num16 >= this.Width || num16 < 0 || (y < 0 || y >= this.Height))
        return (Coords) null;
      for (int x2 = num16; x2 > x1 && x2 >= 0; --x2)
      {
        num14 -= num12;
        if (num14 < 0)
        {
          y -= num13;
          if (y >= 0 && y < this.Height)
            num14 += num11;
          else
            break;
        }
        --count;
        if (count <= 0)
          return new Coords(x2, y);
      }
    }
    else
    {
      if (num7 >= this.Width || num7 < 0 || (num15 < 0 || num15 >= this.Height))
        return (Coords) null;
      for (int x = num7; x <= num8 && x < this.Width; ++x)
      {
        num14 -= num12;
        if (num14 < 0)
        {
          num15 += num13;
          if (num15 >= 0 && num15 < this.Height)
            num14 += num11;
          else
            break;
        }
        --count;
        if (count <= 0)
          return new Coords(x, num15);
      }
    }
    return (Coords) null;
  }

  public Coords bresenhamsLineCastLightningStrike(
    Coords start,
    Coords end,
    ZCreature c,
    ZSpell spell,
    int mask)
  {
    if (start.y >= this.Height)
      start.y = this.Height - 1;
    if (end.y >= this.Height)
      end.y = this.Height - 1;
    int num1 = Mathf.Abs(end.y - start.y) > Mathf.Abs(end.x - start.x) ? 1 : 0;
    int num2 = num1 != 0 ? start.y : start.x;
    int num3 = num1 != 0 ? start.x : start.y;
    int num4 = num1 != 0 ? end.y : end.x;
    int num5 = num1 != 0 ? end.x : end.y;
    int num6 = num2 > num4 ? 1 : 0;
    int num7 = num6 != 0 ? num4 : num2;
    int num8 = num6 != 0 ? num2 : num4;
    int num9 = num6 != 0 ? num5 : num3;
    int num10 = num6 != 0 ? num3 : num5;
    int num11 = num8 - num7;
    int num12 = Mathf.Abs(num10 - num9);
    int num13 = num9 < num10 ? 1 : -1;
    int num14 = num11 / 2;
    int num15 = num9;
    if (num1 != 0)
    {
      if (num7 == end.y)
      {
        int num16 = num8;
        int y = end.y;
        int num17 = num10;
        if (num16 >= this.Height || num16 < 0 || (num17 < 0 || num17 >= this.Width))
          return (Coords) null;
        for (int index = num16; index > y && index >= 0; --index)
        {
          if (!this.CheckClampedPixel(num17, index))
          {
            if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              spell.ApplyExplosionForce(new MyLocation(num17, index), 0, true, (ISpellBridge) null, (ZCreature) null);
            return new Coords(num17, index);
          }
          ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, num17, index, mask);
          if ((ZComponent) creatureAtPoint != (object) null)
          {
            if ((ZComponent) spell != (object) null)
            {
              spell.position = new MyLocation(num17, index);
              if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              {
                spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
              }
              else
              {
                spell.Damage(creatureAtPoint);
                spell.isDead = true;
                if ((ZComponent) creatureAtPoint.tower == (object) null)
                {
                  creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(num17, index), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                  creatureAtPoint.StartMoving(false);
                }
              }
            }
            return new Coords(num17, index, creatureAtPoint);
          }
          num14 -= num12;
          if (num14 < 0)
          {
            num17 -= num13;
            if (num17 >= 0 && num17 < this.Width)
              num14 += num11;
            else
              break;
          }
        }
      }
      else
      {
        if (num7 >= this.Height || num7 < 0 || (num15 < 0 || num15 >= this.Width))
          return (Coords) null;
        for (int index = num7; index <= num8 && index < this.Height; ++index)
        {
          if (!this.CheckClampedPixel(num15, index))
          {
            if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              spell.ApplyExplosionForce(new MyLocation(num15, index), 0, true, (ISpellBridge) null, (ZCreature) null);
            return new Coords(num15, index);
          }
          ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, num15, index, mask);
          if ((ZComponent) creatureAtPoint != (object) null)
          {
            if ((ZComponent) spell != (object) null)
            {
              spell.position = new MyLocation(num15, index);
              if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
              {
                spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
              }
              else
              {
                spell.Damage(creatureAtPoint);
                spell.isDead = true;
                if ((ZComponent) creatureAtPoint.tower == (object) null)
                {
                  creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(num15, index), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                  creatureAtPoint.StartMoving(false);
                }
              }
            }
            return new Coords(num15, index, creatureAtPoint);
          }
          num14 -= num12;
          if (num14 < 0)
          {
            num15 += num13;
            if (num15 >= 0 && num15 < this.Width)
              num14 += num11;
            else
              break;
          }
        }
      }
    }
    else if (num7 == end.x)
    {
      int num16 = num8;
      int x = end.x;
      int num17 = num10;
      if (num16 >= this.Width || num16 < 0 || (num17 < 0 || num17 >= this.Height))
        return (Coords) null;
      for (int index = num16; index > x && index >= 0; --index)
      {
        if (!this.CheckClampedPixel(index, num17))
        {
          if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            spell.ApplyExplosionForce(new MyLocation(index, num17), 0, true, (ISpellBridge) null, (ZCreature) null);
          return new Coords(index, num17);
        }
        ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, index, num17, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
        {
          if ((ZComponent) spell != (object) null)
          {
            spell.position = new MyLocation(index, num17);
            if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            {
              spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
            }
            else
            {
              spell.Damage(creatureAtPoint);
              spell.isDead = true;
              if ((ZComponent) creatureAtPoint.tower == (object) null)
              {
                creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(index, num17), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                creatureAtPoint.StartMoving(false);
              }
            }
          }
          return new Coords(index, num17);
        }
        num14 -= num12;
        if (num14 < 0)
        {
          num17 -= num13;
          if (num17 >= 0 && num17 < this.Height)
            num14 += num11;
          else
            break;
        }
      }
    }
    else
    {
      if (num7 >= this.Width || num7 < 0 || (num15 < 0 || num15 >= this.Height))
        return (Coords) null;
      for (int index = num7; index <= num8 && index < this.Width; ++index)
      {
        if (!this.CheckClampedPixel(index, num15))
        {
          if ((ZComponent) spell != (object) null && spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            spell.ApplyExplosionForce(new MyLocation(index, num15), 0, true, (ISpellBridge) null, (ZCreature) null);
          return new Coords(index, num15);
        }
        ZCreature creatureAtPoint = this.FindCreatureAtPoint(c, index, num15, mask);
        if ((ZComponent) creatureAtPoint != (object) null)
        {
          if ((ZComponent) spell != (object) null)
          {
            spell.position = new MyLocation(index, num15);
            if (spell.spellEnum == SpellEnum.Storm_Dragon_Breath)
            {
              spell.ApplyExplosionForce(spell.position, 0, true, (ISpellBridge) null, (ZCreature) null);
            }
            else
            {
              spell.Damage(creatureAtPoint);
              spell.isDead = true;
              if ((ZComponent) creatureAtPoint.tower == (object) null)
              {
                creatureAtPoint.ApplyExplosionForce(spell.radius, new MyLocation(index, num15), spell.explisiveForce, spell.EXORADIUS, spell.forceOverDistance, false);
                creatureAtPoint.StartMoving(false);
              }
            }
          }
          return new Coords(index, num15);
        }
        num14 -= num12;
        if (num14 < 0)
        {
          num15 += num13;
          if (num15 >= 0 && num15 < this.Height)
            num14 += num11;
          else
            break;
        }
      }
    }
    return (Coords) null;
  }

  public Coords bresenhamsLineCastOnlyTerrain(Coords start, Coords end)
  {
    int num1 = Mathf.Abs(end.y - start.y) > Mathf.Abs(end.x - start.x) ? 1 : 0;
    int num2 = num1 != 0 ? start.y : start.x;
    int num3 = num1 != 0 ? start.x : start.y;
    int num4 = num1 != 0 ? end.y : end.x;
    int num5 = num1 != 0 ? end.x : end.y;
    int num6 = num2 > num4 ? 1 : 0;
    int num7 = num6 != 0 ? num4 : num2;
    int num8 = num6 != 0 ? num2 : num4;
    int num9 = num6 != 0 ? num5 : num3;
    int num10 = num6 != 0 ? num3 : num5;
    int num11 = num8 - num7;
    int num12 = Mathf.Abs(num10 - num9);
    int num13 = num9 < num10 ? 1 : -1;
    int num14 = num11 / 2;
    int num15 = num9;
    if (num1 != 0)
    {
      if (num7 == end.y)
      {
        int num16 = num8;
        int y1 = end.y;
        int x = num10;
        for (int y2 = num16; y2 > y1; --y2)
        {
          if (y2 < this.Height && y2 >= 0 && (x >= 0 && x < this.Width) && !this.CheckClampedPixel(x, y2))
            return new Coords(x, y2);
          num14 -= num12;
          if (num14 < 0)
          {
            x -= num13;
            num14 += num11;
          }
        }
      }
      else
      {
        if (num7 >= this.Height || num7 < 0 || (num15 < 0 || num15 >= this.Width))
          return (Coords) null;
        for (int y = num7; y <= num8; ++y)
        {
          if (y < this.Height && y >= 0 && (num15 >= 0 && num15 < this.Width) && !this.CheckClampedPixel(num15, y))
            return new Coords(num15, y);
          num14 -= num12;
          if (num14 < 0)
          {
            num15 += num13;
            num14 += num11;
          }
        }
      }
    }
    else if (num7 == end.x)
    {
      int num16 = num8;
      int x1 = end.x;
      int y = num10;
      for (int x2 = num16; x2 > x1; --x2)
      {
        if (x2 < this.Width && x2 >= 0 && (y >= 0 && y < this.Height) && !this.CheckClampedPixel(x2, y))
          return new Coords(x2, y);
        num14 -= num12;
        if (num14 < 0)
        {
          y -= num13;
          num14 += num11;
        }
      }
    }
    else
    {
      for (int x = num7; x <= num8; ++x)
      {
        if (x < this.Width && x >= 0 && (num15 >= 0 && num15 < this.Height) && !this.CheckClampedPixel(x, num15))
          return new Coords(x, num15);
        num14 -= num12;
        if (num14 < 0)
        {
          num15 += num13;
          num14 += num11;
        }
      }
    }
    return (Coords) null;
  }

  public class GhostTerrain
  {
    public ZMap.GhostTerrain next;
    public int x;
    public int y;
    public int radius2;
  }

  public class RawSprite
  {
    public bool requireUpdate = true;
    public Sprite sprite;
    public SpriteRenderer sr;
    public Color32[] colors;

    public RawSprite(Sprite s, SpriteRenderer sr, Color32[] c)
    {
      this.sr = sr;
      this.sprite = s;
      this.colors = c;
    }

    public void SetPixel(int i, Color32 c)
    {
      this.colors[i] = c;
      this.requireUpdate = true;
    }

    public Color32 GetPixel(int i)
    {
      return this.colors[i];
    }

    public void Apply()
    {
      if (!this.requireUpdate)
        return;
      this.requireUpdate = false;
      this.sprite.texture.SetPixels32(this.colors);
      this.sprite.texture.Apply(true);
    }

    public void Purpalize()
    {
      for (int index = 0; index < this.colors.Length; ++index)
      {
        if (this.colors[index].a == byte.MaxValue)
          this.colors[index] = RotateImage.Purpalize(this.colors[index], false);
      }
      this.sprite.texture.SetPixels32(this.colors);
      this.sprite.texture.Apply(true);
    }
  }
}
