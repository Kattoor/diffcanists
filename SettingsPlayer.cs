
using Hazel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using UnityEngine;

[Serializable]
public class SettingsPlayer
{
  public static readonly byte[] clanOutfit = new byte[9]
  {
    (byte) 100,
    (byte) 80,
    (byte) 106,
    (byte) 120,
    (byte) 112,
    (byte) 79,
    (byte) 100,
    (byte) 100,
    byte.MaxValue
  };
  public static byte Achievement_GameOutfit = byte.MaxValue;
  public static ulong id_sno = 628590527973163009;
  public static int sno_body = 65;
  public static int sno_body2 = 67;
  public static int sno_body3 = 68;
  public static int sno_body4 = 69;
  public static int brine_body = 76;
  public static int dharok_body = 80;
  public static int strelizia_body = 125;
  public static int quinn_body2 = 140;
  public static int sno_head = 59;
  public static int sno_head2 = 61;
  public static int sno_head3 = 62;
  public static int sno_head4 = 63;
  public static int brine_head = 67;
  public static int sno_pHand = 63;
  public static int sno_pHand2 = 64;
  public static int sno_pHand3 = 65;
  public static int brine_hand = 73;
  public static int strelizia_pHand = 144;
  public static int godsword = 145;
  public static int olympic_torch = 146;
  public static int cosmos_helper = 154;
  public static int sno_mHand = 64;
  public static int sno_mHand2 = 65;
  public static int sno_mHand3 = 66;
  public static int strelizia_mHand = 118;
  public static int sno_hat = 74;
  public static int strelizia_hat = 142;
  public static int sno_beard = 57;
  public static int sno_beard2 = 59;
  public static int body_skate = 142;
  public static List<List<SettingsPlayer.ByDust>> LockedByDust = new List<List<SettingsPlayer.ByDust>>()
  {
    new List<SettingsPlayer.ByDust>(),
    new List<SettingsPlayer.ByDust>(),
    new List<SettingsPlayer.ByDust>(),
    new List<SettingsPlayer.ByDust>()
    {
      new SettingsPlayer.ByDust(97, 30, "Bronze Trophy"),
      new SettingsPlayer.ByDust(98, 50, "Silver Trophy"),
      new SettingsPlayer.ByDust(99, 101, "Gold Trophy")
    },
    new List<SettingsPlayer.ByDust>(),
    new List<SettingsPlayer.ByDust>()
    {
      new SettingsPlayer.ByDust(66, 20, "Olympic Bronze Medal"),
      new SettingsPlayer.ByDust(67, 50, "Olympic Silver Medal"),
      new SettingsPlayer.ByDust(68, 100, "Olympic Gold Medal")
    }
  };
  private static Dictionary<string, SettingsPlayer.ByDust> buyables = new Dictionary<string, SettingsPlayer.ByDust>();
  public SpellsOnly _spells = new SpellsOnly();
  public Recolor coloring = new Recolor();
  public const int NumOutfitParts = 11;
  public const byte _Version = 4;
  public byte indexHead;
  public byte indexBeard;
  public byte indexBeard2;
  public byte indexBeard3;
  public byte indexHat;
  public byte indexBody;
  public byte indexLeftHand;
  public byte indexRightHand;
  public byte indexLeftFoot;
  public byte indexRightFoot;
  public byte indexMouth;
  public byte custom;
  public string[] customPieces;
  public Sprite[] textures;
  public SettingsPlayer.CustomAnim[] animations;
  public SettingsPlayer.MetaData[] metaData;

  public byte fullBook
  {
    get
    {
      return this._spells.fullBook;
    }
    set
    {
      this._spells.fullBook = value;
    }
  }

  public byte extraInfo
  {
    get
    {
      return this._spells.extraInfo;
    }
    set
    {
      this._spells.extraInfo = value;
    }
  }

  public BookOf Elemental
  {
    get
    {
      return (BookOf) ((int) this.fullBook - 1);
    }
    set
    {
      this.fullBook = (byte) (value + 1);
    }
  }

  public byte GetOutfitIndex(Outfit o)
  {
    switch (o)
    {
      case Outfit.Body:
        return this.indexBody;
      case Outfit.Head:
        return this.indexHead;
      case Outfit.LeftHand:
        return this.indexLeftHand;
      case Outfit.RightHand:
        return this.indexRightHand;
      case Outfit.Hair:
        return this.indexHat;
      case Outfit.Beard:
        return this.indexBeard;
      case Outfit.LeftFoot:
        return this.indexLeftFoot;
      case Outfit.RightFoot:
        return this.indexRightFoot;
      case Outfit.Mouth:
        return this.indexMouth;
      case Outfit.Beard2:
        return this.indexBeard2;
      case Outfit.Beard3:
        return this.indexBeard3;
      default:
        return 0;
    }
  }

  public void SetOutfitIndex(Outfit o, byte i)
  {
    switch (o)
    {
      case Outfit.Body:
        this.indexBody = i;
        break;
      case Outfit.Head:
        this.indexHead = i;
        break;
      case Outfit.LeftHand:
        this.indexLeftHand = i;
        break;
      case Outfit.RightHand:
        this.indexRightHand = i;
        break;
      case Outfit.Hair:
        this.indexHat = i;
        break;
      case Outfit.Beard:
        this.indexBeard = i;
        break;
      case Outfit.LeftFoot:
        this.indexLeftFoot = i;
        break;
      case Outfit.RightFoot:
        this.indexRightFoot = i;
        break;
      case Outfit.Mouth:
        this.indexMouth = i;
        break;
      case Outfit.Beard2:
        this.indexBeard2 = i;
        break;
      case Outfit.Beard3:
        this.indexBeard3 = i;
        break;
    }
  }

  public byte[] spells
  {
    get
    {
      return this._spells.spells;
    }
    set
    {
      this._spells.spells = value;
    }
  }

  internal void Export(string fileName)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        for (int index = 0; index < 11; ++index)
        {
          if ((UnityEngine.Object) this.textures[index] != (UnityEngine.Object) null)
          {
            w.Write(1);
            w.Write(this.customPieces[index]);
            this.metaData[index].Serialize(w);
            w.Write(this.textures[index].texture.EncodeToPNG());
            if (this.animations[index] != null)
              w.Write(this.animations[index].sprites[0].texture.EncodeToPNG());
            else
              w.Write(0);
          }
          else
            w.Write(0);
        }
      }
      string path = SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + "OutfitPackages" + Path.DirectorySeparatorChar.ToString();
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      File.WriteAllBytes(path + fileName + ".outfitPKG", memoryStream.ToArray());
      Global.OpenFileLocation(path);
    }
  }

  internal void Import(string file)
  {
    using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(file)))
    {
      this.MakeSureIntitialized();
      string persistentDataPath = SaveFolder.persistentDataPath;
      char directorySeparatorChar = Path.DirectorySeparatorChar;
      string str1 = directorySeparatorChar.ToString();
      directorySeparatorChar = Path.DirectorySeparatorChar;
      string str2 = directorySeparatorChar.ToString();
      string path = persistentDataPath + str1 + "_Temporary" + str2;
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      using (myBinaryReader r = new myBinaryReader((Stream) memoryStream))
      {
        StringBuilder stringBuilder = new StringBuilder();
        for (int index = 0; index < 11 && r.BaseStream.Position != r.BaseStream.Length; ++index)
        {
          if (r.ReadInt32() != 0)
          {
            string str3 = Path.GetFileNameWithoutExtension(r.ReadString());
            if (!str3.StartsWith("temp_"))
              str3 = "temp_" + str3;
            this.customPieces[index] = path + str3 + ".png";
            this.metaData[index] = SettingsPlayer.MetaData.Deserialize(r).meta;
            byte[] numArray = r.ReadBytes();
            Texture2D texture2D = new Texture2D(2, 2);
            texture2D.LoadImage(numArray);
            this.textures[index] = Global.AddSprite(Sprite.Create(texture2D, new Rect(0.0f, 0.0f, (float) texture2D.width, (float) texture2D.height), this.metaData[index].pivot, 2f));
            File.WriteAllBytes(this.customPieces[index], numArray);
            this.metaData[index].SerializeToFile(this.customPieces[index]);
            int count = r.ReadInt32();
            if (count != 0)
            {
              byte[] bytes = r.ReadBytes(count);
              this.animations[index] = CharacterCreation.GenerateAnim(bytes, texture2D, this.metaData[index]);
              File.WriteAllBytes(path + str3 + "_effect.png", bytes);
              stringBuilder.Append(((Outfit) index).ToString()).Append(": ").Append((object) this.metaData[index].pivot).Append("\n");
            }
          }
        }
        File.WriteAllText(path + "meta.txt", stringBuilder.ToString());
      }
    }
  }

  internal bool CustomContainsSomething()
  {
    if (this.customPieces == null)
      return false;
    for (int index = 0; index < 11; ++index)
    {
      if (!string.IsNullOrWhiteSpace(this.customPieces[index]))
        return true;
    }
    return false;
  }

  internal void UpdatePivot(Outfit o, Vector2 p, SpriteRenderer sr)
  {
    int index1 = (int) o;
    Texture2D texture = this.textures[index1].texture;
    this.textures[index1] = Global.AddSprite(Sprite.Create(texture, new Rect(0.0f, 0.0f, (float) texture.width, (float) texture.height), p, 2f));
    sr.sprite = Global.AddSprite(Sprite.Create(sr.sprite.texture, new Rect(0.0f, 0.0f, (float) texture.width, (float) texture.height), p, 2f));
    this.metaData[index1].pivot = p;
    if (this.animations[index1] != null)
    {
      for (int index2 = 0; index2 < this.animations[index1].sprites.Count; ++index2)
        this.animations[index1].sprites[index2] = Global.AddSprite(Sprite.Create(this.animations[index1].sprites[index2].texture, this.animations[index1].sprites[index2].rect, p, 2f));
    }
    foreach (SpriteRenderer componentsInChild in sr.GetComponentsInChildren<SpriteRenderer>())
    {
      if ((UnityEngine.Object) componentsInChild != (UnityEngine.Object) sr)
      {
        AnimateRepeat component = componentsInChild.GetComponent<AnimateRepeat>();
        if ((UnityEngine.Object) component != (UnityEngine.Object) null)
        {
          for (int index2 = 0; index2 < component.sprites.Length; ++index2)
            component.sprites[index2] = Global.AddSprite(Sprite.Create(component.sprites[index2].texture, component.sprites[index2].rect, p, 2f));
        }
      }
    }
    this.metaData[index1].SerializeToFile(this.customPieces[index1]);
  }

  public void MakeSureIntitialized()
  {
    if (this.customPieces == null)
      this.customPieces = new string[11];
    if (this.textures != null)
      return;
    this.textures = new Sprite[11];
    this.animations = new SettingsPlayer.CustomAnim[11];
    this.metaData = new SettingsPlayer.MetaData[11];
    for (int index = 0; index < 11; ++index)
      this.metaData[index] = new SettingsPlayer.MetaData();
  }

  public void Reset(Outfit o)
  {
    switch (o)
    {
      case Outfit.Body:
        this.indexBody = (byte) 0;
        break;
      case Outfit.Head:
        this.indexHead = (byte) 0;
        break;
      case Outfit.LeftHand:
        this.indexLeftHand = (byte) 0;
        break;
      case Outfit.RightHand:
        this.indexRightHand = (byte) 0;
        break;
      case Outfit.Hair:
        this.indexHat = (byte) 0;
        break;
      case Outfit.Beard:
        this.indexBeard = (byte) 0;
        break;
      case Outfit.LeftFoot:
        this.indexLeftFoot = (byte) 0;
        break;
      case Outfit.RightFoot:
        this.indexRightFoot = (byte) 0;
        break;
      case Outfit.Beard2:
        this.indexBeard2 = (byte) 0;
        break;
      case Outfit.Beard3:
        this.indexBeard3 = (byte) 0;
        break;
    }
  }

  public void ResetAll()
  {
    this.indexMouth = (byte) 0;
    this.indexLeftFoot = (byte) 0;
    this.indexRightFoot = (byte) 0;
    for (int index = 0; index < 11; ++index)
      this.ResetCustom((Outfit) index);
  }

  public void ResetCustom(Outfit o)
  {
    int index = (int) o;
    if (this.customPieces == null)
      return;
    this.customPieces[index] = (string) null;
    if ((UnityEngine.Object) this.textures[index] != (UnityEngine.Object) null)
    {
      Global.DestroySprite(this.textures[index]);
      this.textures[index] = (Sprite) null;
    }
    this.ResetAnimation(o);
  }

  public void ResetAnimation(Outfit o)
  {
    int index = (int) o;
    if (this.animations[index] == null)
      return;
    foreach (Sprite sprite in this.animations[index].sprites)
      Global.DestroySprite(sprite);
    this.animations[index] = (SettingsPlayer.CustomAnim) null;
  }

  public static SettingsPlayer DefaultSettings()
  {
    SettingsPlayer settingsPlayer = new SettingsPlayer();
    settingsPlayer.coloring = new Recolor();
    for (int index = 0; index < settingsPlayer.spells.Length; ++index)
      settingsPlayer.spells[index] = byte.MaxValue;
    return settingsPlayer;
  }

  public static SettingsPlayer Load(string path)
  {
    SettingsPlayer settingsPlayer = new SettingsPlayer();
    if (File.Exists(path))
    {
      try
      {
        using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
        {
          using (myBinaryReader r = new myBinaryReader((Stream) fileStream))
            settingsPlayer.Deserialize(r);
        }
      }
      catch (Exception ex)
      {
        settingsPlayer = new SettingsPlayer();
      }
    }
    return settingsPlayer;
  }

  public void RemoveSpellSlot(int i)
  {
    for (; i < 15 && this.spells[i + 1] < byte.MaxValue; ++i)
      this.spells[i] = this.spells[i + 1];
    this.spells[i] = byte.MaxValue;
  }

  public void Realign()
  {
    int index1 = 0;
    bool flag = false;
    for (int index2 = 0; index2 < 16; ++index2)
    {
      if (this.spells[index2] < byte.MaxValue)
      {
        if (flag)
        {
          this.spells[index1] = this.spells[index2];
          this.spells[index2] = byte.MaxValue;
          ++index1;
        }
        else
          ++index1;
      }
      else
        flag = true;
    }
  }

  public void VerifySpells()
  {
    HashSet<byte> byteSet = new HashSet<byte>();
    int[] numArray = new int[(int) (RandomExtensions.LastBook() + 1)];
    bool flag = false;
    for (int index1 = 0; index1 < 16; ++index1)
    {
      byte spell = this.spells[index1];
      int index2 = (int) spell / 12;
      if (index2 < 0 || index2 >= numArray.Length)
      {
        this.spells[index1] = byte.MaxValue;
        flag = true;
      }
      else
      {
        int num = (int) spell % 12;
        if (num < 10)
        {
          if (num % 2 == 1 && spell >= (byte) 12 && (index1 == 0 || (int) this.spells[index1 - 1] != (int) spell - 1))
          {
            this.spells[index1] = byte.MaxValue;
            flag = true;
            continue;
          }
        }
        else if (index2 > 0 && numArray[index2] < 5)
        {
          this.spells[index1] = byte.MaxValue;
          flag = true;
          continue;
        }
        if (byteSet.Contains(spell))
        {
          this.spells[index1] = byte.MaxValue;
          flag = true;
        }
        else
        {
          ++numArray[index2];
          byteSet.Add(spell);
        }
      }
    }
    if (!flag)
      return;
    this.Realign();
  }

  private void DefaultSpells()
  {
    this.spells = new byte[16]
    {
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 4,
      (byte) 5,
      (byte) 6,
      (byte) 7,
      (byte) 8,
      (byte) 9,
      (byte) 10,
      (byte) 11,
      (byte) 12,
      (byte) 13,
      (byte) 14,
      (byte) 15
    };
  }

  public bool CanEquipSpellLevel3Only(int index, byte spellID)
  {
    if (index < 0 || index >= 16 || Inert.Instance._spells.Length <= (int) spellID)
      return false;
    for (int index1 = 0; index1 < 16; ++index1)
    {
      if ((int) this.spells[index1] == (int) spellID && index != index1)
        return false;
    }
    KeyValuePair<string, Spell> keyValuePair = Inert.Instance.spells.GetItem((int) spellID);
    Spell spell = keyValuePair.Value;
    if (spell.level == 1 || spell.level == 2)
      return true;
    if (spell.level == 3)
    {
      int num = 0;
      for (int index1 = 0; index1 < index; ++index1)
      {
        if ((int) this.spells[index1] < Inert.Instance._spells.Length)
        {
          keyValuePair = Inert.Instance.spells.GetItem((int) this.spells[index1]);
          if (keyValuePair.Value.bookOf == spell.bookOf)
          {
            keyValuePair = Inert.Instance.spells.GetItem((int) this.spells[index1]);
            if (keyValuePair.Value.level < 3)
            {
              ++num;
              if (num >= 5)
                return true;
            }
          }
        }
      }
    }
    else
      Debug.LogError((object) ("Unknown Spell Level: " + (object) spell.level));
    return false;
  }

  public bool CanEquipSpell(int index, byte spellID)
  {
    if (index < 0 || index >= 16 || Inert.Instance._spells.Length <= (int) spellID)
      return false;
    for (int index1 = 0; index1 < 16; ++index1)
    {
      if ((int) this.spells[index1] == (int) spellID && index != index1)
        return false;
    }
    KeyValuePair<string, Spell> keyValuePair = Inert.Instance.spells.GetItem((int) spellID);
    Spell spell = keyValuePair.Value;
    if (spell.level == 1)
      return true;
    if (spell.level == 2)
    {
      byte num = (byte) ((uint) spellID - 1U);
      for (int index1 = 0; index1 < 16; ++index1)
      {
        if ((int) this.spells[index1] == (int) num)
          return true;
      }
    }
    else if (spell.level == 3)
    {
      int num = 0;
      for (int index1 = 0; index1 < index; ++index1)
      {
        if ((int) this.spells[index1] < Inert.Instance._spells.Length)
        {
          keyValuePair = Inert.Instance.spells.GetItem((int) this.spells[index1]);
          if (keyValuePair.Value.bookOf == spell.bookOf)
          {
            keyValuePair = Inert.Instance.spells.GetItem((int) this.spells[index1]);
            if (keyValuePair.Value.level < 3)
            {
              ++num;
              if (num >= 5)
                return true;
            }
          }
        }
      }
    }
    else
      Debug.LogError((object) ("Unknown Spell Level: " + (object) spell.level));
    return false;
  }

  public void CopyOutfit(SettingsPlayer b)
  {
    this.indexHead = b.indexHead;
    this.indexBeard = b.indexBeard;
    this.indexBeard2 = b.indexBeard2;
    this.indexBeard3 = b.indexBeard3;
    this.indexHat = b.indexHat;
    this.indexBody = b.indexBody;
    this.indexLeftHand = b.indexLeftHand;
    this.indexRightHand = b.indexRightHand;
    for (int index = 0; index < this.coloring.colors.Length; ++index)
      this.coloring.colors[index].Copy(b.coloring.colors[index]);
    this.custom = b.CustomContainsSomething() ? (byte) 1 : (byte) 0;
    if (this.custom != (byte) 0)
    {
      this.indexMouth = b.indexMouth;
      this.indexLeftFoot = b.indexLeftFoot;
      this.indexRightFoot = b.indexRightFoot;
      this.MakeSureIntitialized();
      for (int index = 0; index < 11; ++index)
      {
        this.customPieces[index] = b.customPieces[index];
        this.textures[index] = b.textures[index];
        this.metaData[index] = b.metaData[index];
        this.animations[index] = b.animations[index];
      }
    }
    else
    {
      this.indexMouth = (byte) 0;
      this.indexLeftFoot = (byte) 0;
      this.indexRightFoot = (byte) 0;
      this.ResetAll();
    }
  }

  public void CopySpells(SpellsOnly b)
  {
    this.fullBook = b.fullBook;
    this.extraInfo = b.extraInfo;
    for (int index = 0; index < 16; ++index)
      this.spells[index] = b.spells[index];
  }

  public void FakeCopySpells(SettingsPlayer b)
  {
    this.fullBook = b.fullBook;
    this.extraInfo = b.extraInfo;
    for (int index = 0; index < 16; ++index)
      this.spells[index] = byte.MaxValue;
  }

  public void CopySpells(SettingsPlayer b, bool force = false)
  {
    if (b.fullBook > (byte) 0 | force)
      this.fullBook = b.fullBook;
    this.extraInfo = b.extraInfo;
    for (int index = 0; index < 16; ++index)
      this.spells[index] = b.spells[index];
  }

  public void SaveAs(string s, bool spells)
  {
    string persistentDataPath = SaveFolder.persistentDataPath;
    char directorySeparatorChar = Path.DirectorySeparatorChar;
    string str1 = directorySeparatorChar.ToString();
    string str2 = spells ? "SavedSpells" : "SavedOutfits";
    directorySeparatorChar = Path.DirectorySeparatorChar;
    string str3 = directorySeparatorChar.ToString();
    string path1 = persistentDataPath + str1 + str2 + str3;
    Global.CheckDirectoryExists(path1, s);
    string path2 = path1 + s + (spells ? ".spellBook" : ".outfit");
    if (string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(path2)))
      return;
    using (FileStream fileStream = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) fileStream))
        this.Serialize(w);
    }
  }

  public void SerializeBasicOutfit(myBinaryWriter w)
  {
    w.Write(this.indexHead);
    w.Write(this.indexBeard);
    w.Write(this.indexBeard2);
    w.Write(this.indexBeard3);
    w.Write(this.indexHat);
    w.Write(this.indexBody);
    w.Write(this.indexLeftHand);
    w.Write(this.indexRightHand);
    this.coloring.Serialize(w);
  }

  public void DeserializeBasicOutfit(myBinaryReader r)
  {
    this.indexHead = r.ReadByte();
    this.indexBeard = r.ReadByte();
    this.indexBeard2 = r.ReadByte();
    this.indexBeard3 = r.ReadByte();
    this.indexHat = r.ReadByte();
    this.indexBody = r.ReadByte();
    this.indexLeftHand = r.ReadByte();
    this.indexRightHand = r.ReadByte();
    this.coloring.Deserialize(r);
  }

  public void Serialize(myBinaryWriter w)
  {
    w.Write((byte) 4);
    w.Write(this.indexHead);
    w.Write(this.indexBeard);
    w.Write(this.indexBeard2);
    w.Write(this.indexBeard3);
    w.Write(this.indexHat);
    w.Write(this.indexBody);
    w.Write(this.indexLeftHand);
    w.Write(this.indexRightHand);
    for (int index = 0; index < 16; ++index)
      w.Write(this.spells[index]);
    this.coloring.Serialize(w);
    w.Write(this.fullBook);
    w.Write(this.extraInfo);
    if (this.customPieces == null || this.customPieces.Length != 11 || !this.CustomContainsSomething())
      this.custom = (byte) 0;
    w.Write(this.custom);
    if (this.custom == (byte) 0)
      return;
    w.Write(this.indexMouth);
    w.Write(this.indexLeftFoot);
    w.Write(this.indexRightFoot);
    w.Write((byte) 11);
    for (int index = 0; index < 11; ++index)
      w.Write(this.customPieces[index] ?? "");
  }

  public void Deserialize(myBinaryReader r)
  {
    byte num1 = r.ReadByte();
    this.indexHead = r.ReadByte();
    this.indexBeard = r.ReadByte();
    if (num1 > (byte) 3)
    {
      this.indexBeard2 = r.ReadByte();
      this.indexBeard3 = r.ReadByte();
    }
    else
    {
      this.indexBeard2 = (byte) 0;
      this.indexBeard3 = (byte) 0;
    }
    this.indexHat = r.ReadByte();
    this.indexBody = r.ReadByte();
    this.indexLeftHand = r.ReadByte();
    this.indexRightHand = r.ReadByte();
    for (int index = 0; index < 16; ++index)
      this.spells[index] = r.ReadByte();
    if (num1 <= (byte) 1)
    {
      byte num2 = r.ReadByte();
      byte num3 = r.ReadByte();
      byte num4 = r.ReadByte();
      byte num5 = r.ReadByte();
      if ((UnityEngine.Object) ClientResources.Instance != (UnityEngine.Object) null)
      {
        this.coloring.colors[0].red = (Color32) ClientResources.Instance.colorsMain[Mathf.Min((int) num2, ClientResources.Instance.colorsMain.Length - 1)];
        this.coloring.colors[0].green = (Color32) ClientResources.Instance.colorsSecondary[Mathf.Min((int) num3, ClientResources.Instance.colorsSecondary.Length - 1)];
        this.coloring.colors[0].blue = (Color32) ClientResources.Instance.colorsHair[Mathf.Min((int) num4, ClientResources.Instance.colorsHair.Length - 1)];
        this.coloring.colors[0].gray = (Color32) ClientResources.Instance.colorSkin[Mathf.Min((int) num5, ClientResources.Instance.colorSkin.Length - 1)];
        for (int index = 1; index < this.coloring.colors.Length; ++index)
        {
          this.coloring.colors[index].red = this.coloring.colors[0].red;
          this.coloring.colors[index].green = this.coloring.colors[0].green;
          this.coloring.colors[index].blue = this.coloring.colors[0].blue;
          this.coloring.colors[index].gray = this.coloring.colors[0].gray;
        }
      }
      if (num1 > (byte) 0)
        this.fullBook = r.ReadByte();
      this.ResetAll();
    }
    else
    {
      this.coloring.Deserialize(r);
      this.fullBook = r.ReadByte();
      this.extraInfo = num1 <= (byte) 2 ? (byte) 0 : r.ReadByte();
      byte num2 = r.ReadByte();
      if (num2 != (byte) 0)
      {
        this.custom = num2;
        this.indexMouth = r.ReadByte();
        this.indexLeftFoot = r.ReadByte();
        this.indexRightFoot = r.ReadByte();
        this.MakeSureIntitialized();
        int num3 = (int) r.ReadByte();
        for (int index = 0; index < num3; ++index)
        {
          if (index < 11)
            this.customPieces[index] = r.ReadString();
        }
      }
      else
        this.ResetAll();
    }
  }

  public void ReseralizeSpells(Connection c)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 44);
        this.Serialize(w);
      }
      c.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public byte FootIndex()
  {
    if ((int) this.indexBody == SettingsPlayer.sno_body4)
      return 2;
    if ((int) this.indexBody == SettingsPlayer.brine_body)
      return 3;
    if ((int) this.indexBody == SettingsPlayer.dharok_body)
      return 4;
    if (this.indexBody == (byte) 46)
      return 5;
    if (this.indexBody == (byte) 98 || this.indexBody == (byte) 140)
      return 6;
    if (this.indexBody == (byte) 93)
      return 7;
    if (this.indexBody == (byte) 101)
      return 8;
    if (this.indexBody == (byte) 142)
      return 9;
    if (this.indexBody == (byte) 152 || this.indexBody == (byte) 153)
      return 5;
    return this.indexBody == (byte) 161 ? (byte) 10 : (byte) 0;
  }

  public static bool HeadNoMouth(string name, SettingsPlayer sp)
  {
    if ((int) sp.indexHead == (int) SettingsPlayer.clanOutfit[1])
    {
      ClanOutfit clanOutfit = ClientResources.Instance.GetClanOutfit(Client.GetAccount(name, false).clan);
      if (clanOutfit != null && clanOutfit.outfits != null && (clanOutfit.outfits[1] != null && clanOutfit.outfits[1].effect == (byte) 1))
        return true;
    }
    return SettingsPlayer.BeardNoMouth(sp.indexBeard) || SettingsPlayer.BeardNoMouth(sp.indexBeard2) || (SettingsPlayer.BeardNoMouth(sp.indexBeard3) || !Inert.Instance._characterBody[(int) sp.indexBody].hasMouth) || !Inert.Instance._characterHeads[(int) sp.indexHead].hasMouth;
  }

  private static bool BeardNoMouth(byte i)
  {
    return !Inert.Instance._characterBeards[(int) i].hasMouth;
  }

  public void VerifyOutfit(Cosmetics cosmetics, Account a = null)
  {
    if (Prefs.charPreview && (Client.game == null || Client.game.isSandbox))
      return;
    if (a == null)
      a = Client.MyAccount;
    if (!SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.Body, (int) this.indexBody))
      this.indexBody = (byte) 0;
    if (!SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.Head, (int) this.indexHead))
      this.indexHead = (byte) 0;
    if (!SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.LeftHand, (int) this.indexLeftHand))
      this.indexLeftHand = (byte) 0;
    if (!SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.RightHand, (int) this.indexRightHand))
      this.indexRightHand = (byte) 0;
    if (!SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.Hair, (int) this.indexHat))
      this.indexHat = (byte) 0;
    if (!SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.Beard, (int) this.indexBeard))
      this.indexBeard = (byte) 0;
    if (!a.accountType.has(AccountType.Donator | AccountType.Owner) || !SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.Beard, (int) this.indexBeard2))
      this.indexBeard2 = (byte) 0;
    if (a.accountType.has(AccountType.Arch_Donator | AccountType.Owner) && SettingsPlayer.VerifyOutfit(a, cosmetics, a.accountType, Outfit.Beard, (int) this.indexBeard3))
      return;
    this.indexBeard3 = (byte) 0;
  }

  public void VerifyColors()
  {
  }

  public static OutfitDataList GetOutfits(int o)
  {
    switch (o)
    {
      case 0:
        return Inert.Instance._characterBody;
      case 1:
        return Inert.Instance._characterHeads;
      case 2:
        return Inert.Instance._characterLeftHand;
      case 3:
        return Inert.Instance._characterRightHand;
      case 4:
        return Inert.Instance._characterHats;
      case 5:
        return Inert.Instance._characterBeards;
      default:
        Debug.LogError((object) ("Invalid index " + (object) o));
        return Inert.Instance._characterBody;
    }
  }

  public static Achievement CheckAchievements(Outfit type, int index)
  {
    return Inert.Instance.GetOutfit(type)[index].achievement;
  }

  public static AccountType CheckAccountType(Outfit type, int index)
  {
    return Inert.Instance.GetOutfit(type)[index].accountType;
  }

  public static bool CheckAlwaysUnlocked(Outfit type, int index)
  {
    return !Inert.Instance.GetOutfit(type)[index].isLocked;
  }

  public static int CheckPrestige(Outfit type, int index)
  {
    return Inert.Instance.GetOutfit(type)[index].prestige;
  }

  public static int CheckExperience(Outfit type, int index)
  {
    return Inert.Instance.GetOutfit(type)[index].experience;
  }

  public static int CheckTournament(Outfit type, int index)
  {
    return Inert.Instance.GetOutfit(type)[index].tournament;
  }

  public static int ClientHasAchievement(Outfit type, int index)
  {
    if (SettingsPlayer.CheckAlwaysUnlocked(type, index) || Client.MyAccount.accountType.has(AccountType.Owner | AccountType.Press_Account))
      return 1;
    Achievement achievement = SettingsPlayer.CheckAchievements(type, index);
    if (achievement != Achievement.None && Client.cosmetics.achievements[(int) achievement])
      return 1;
    Account myAccount = Client.MyAccount;
    AccountType accountType = SettingsPlayer.CheckAccountType(type, index);
    if ((myAccount.accountType & accountType) != AccountType.None)
      return 1;
    int num1 = SettingsPlayer.CheckPrestige(type, index);
    if (num1 > 0)
      return (int) myAccount.prestige < num1 ? 0 : 1;
    int num2 = SettingsPlayer.CheckExperience(type, index);
    return num2 > 0 ? ((int) myAccount.experience < num2 ? 0 : 1) : (SettingsPlayer.CheckTournament(type, index) > 0 || Inert.Instance.GetOutfit(type)[index].season != Server.ServerSettings.Season.None || (!string.IsNullOrEmpty(Inert.Instance.GetOutfit(type)[index].reason) || accountType != AccountType.None) || achievement != Achievement.None ? 0 : -1);
  }

  public static bool IsSeasonal(Outfit type, int index)
  {
    return (uint) Inert.Instance.GetOutfit(type)[index].season > 0U;
  }

  public static SettingsPlayer.ByDust GetBuyable(string name)
  {
    SettingsPlayer.ByDust byDust;
    SettingsPlayer.buyables.TryGetValue(name, out byDust);
    return byDust;
  }

  public static bool VerifyOutfit(
    Account acc,
    Cosmetics c,
    AccountType a,
    Outfit type,
    int index)
  {
    return Inert.Instance.GetOutfit(type)[index].IsUnlocked(acc);
  }

  public static void SetupClientData()
  {
    for (int index1 = 0; index1 < 8; ++index1)
    {
      List<OutfitData> list = Inert.Instance.GetOutfit((Outfit) index1).list;
      for (int index2 = 0; index2 < list.Count; ++index2)
      {
        list[index2].outfit = Outfit.Body;
        list[index2].index = index2;
        int achievement = (int) list[index2].achievement;
      }
    }
  }

  public class CustomAnim
  {
    public List<Sprite> sprites = new List<Sprite>();
  }

  public class MetaData
  {
    private static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);
    private static Dictionary<string, SettingsPlayer.MetaData> metaQueue = new Dictionary<string, SettingsPlayer.MetaData>();
    public float fps = 12f;
    public Vector2 pivot = new Vector2(0.5f, 0.5f);
    public const byte _version = 1;
    internal bool hasEffect;

    public static (SettingsPlayer.MetaData meta, bool exist) Deserialize(
      myBinaryReader r)
    {
      int num = (int) r.ReadByte();
      SettingsPlayer.MetaData metaData = new SettingsPlayer.MetaData();
      if (num == 0)
        return (metaData, false);
      metaData.fps = r.ReadSingle();
      metaData.pivot = r.ReadVector2();
      return (metaData, true);
    }

    public static (SettingsPlayer.MetaData meta, bool exist) Deserialize(string file)
    {
      string persistentDataPath = SaveFolder.persistentDataPath;
      char directorySeparatorChar = Path.DirectorySeparatorChar;
      string str1 = directorySeparatorChar.ToString();
      directorySeparatorChar = Path.DirectorySeparatorChar;
      string str2 = directorySeparatorChar.ToString();
      string path = persistentDataPath + str1 + "meta" + str2;
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      file = path + Path.GetFileName(file);
      if (File.Exists(file))
      {
        try
        {
          using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(file)))
          {
            using (myBinaryReader r = new myBinaryReader((Stream) memoryStream))
              return SettingsPlayer.MetaData.Deserialize(r);
          }
        }
        catch (Exception ex)
        {
        }
      }
      return (new SettingsPlayer.MetaData(), false);
    }

    public async void SerializeToFile(string file)
    {
      SettingsPlayer.MetaData metaData = this;
      string path = SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + "meta" + Path.DirectorySeparatorChar.ToString();
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      file = path + Path.GetFileName(file) + ".meta";
      SettingsPlayer.MetaData.metaQueue[file] = metaData;
      await SettingsPlayer.MetaData.semaphoreSlim.WaitAsync();
      try
      {
        if (!SettingsPlayer.MetaData.metaQueue.ContainsKey(file))
          return;
        SettingsPlayer.MetaData meta = SettingsPlayer.MetaData.metaQueue[file];
        SettingsPlayer.MetaData.metaQueue.Remove(file);
        using (MemoryStream m = new MemoryStream())
        {
          using (myBinaryWriter w = new myBinaryWriter((Stream) m))
            meta.Serialize(w);
          byte[] array = m.ToArray();
          using (FileStream f = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.ReadWrite, array.Length, true))
            await f.WriteAsync(array, 0, array.Length);
        }
      }
      finally
      {
        SettingsPlayer.MetaData.semaphoreSlim.Release();
      }
    }

    public void Serialize(myBinaryWriter w)
    {
      w.Write((byte) 1);
      w.Write(this.fps);
      w.Write(this.pivot);
    }
  }

  public class Seasonal
  {
    public int index;
    public Outfit outfit;
  }

  public class ByRole
  {
    public int index;
    public AccountType a;

    public ByRole(int index, AccountType a)
    {
      this.index = index;
      this.a = a;
    }
  }

  public class ByPrestige
  {
    public int index;
    public int prestige;

    public ByPrestige(int index, int a)
    {
      this.index = index;
      this.prestige = a;
    }
  }

  public class ByTournament
  {
    public int index;
    public int coins;

    public ByTournament(int index, int a)
    {
      this.index = index;
      this.coins = a;
    }
  }

  public class ByAchievement
  {
    public int index;
    public Achievement a;

    public ByAchievement(int index, Achievement a)
    {
      this.index = index;
      this.a = a;
    }
  }

  public class ByReason
  {
    public int index;
    public string a;

    public ByReason(int index, string a)
    {
      this.index = index;
      this.a = a;
    }
  }

  public class ByDust
  {
    public int index;
    public int cost;
    public string name;
    public Outfit outfitType;

    public ByDust(int index, int a, string n)
    {
      this.index = index;
      this.cost = a;
      this.name = n;
    }
  }
}
