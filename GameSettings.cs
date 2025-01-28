
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class GameSettings
{
  public int gameModes = 1073808464;
  public int gameModes2 = 2097152;
  public int gameModes4 = 32768;
  public byte elementalLevel = 3;
  public ushort startHealth = 250;
  public byte armageddonTurn = 10;
  public byte countdownDelay = 5;
  public ushort customTime = 60;
  public byte customPlayerCount = 6;
  public string description = "";
  public byte mapWidth = 100;
  public byte mapHeight = 100;
  public ZGame.GameType gameType;
  public int gameModes3;
  public short countdownTime;
  public Restrictions restrictions;
  public int mapSeed;
  public bool fixedMapSeed;
  public bool altGeneration;
  public WaterStyle water;
  public const byte Version = 5;
  public List<SpellEnum> customArmageddon;
  public List<SpellEnum> autoInclude;

  public string FilteredDescription()
  {
    return !string.IsNullOrEmpty(this.description) ? WordFilter.FilterForbiddenWords(WordFilter.ReplaceBadWords(this.description)) : this.description;
  }

  public void SerializeToFile(string s)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 5);
        this.Serialize(w);
      }
      File.WriteAllBytes(s, memoryStream.ToArray());
    }
  }

  public static GameSettings DeserializeFromFile(string s)
  {
    GameSettings gameSettings = new GameSettings();
    using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(s)))
    {
      using (myBinaryReader r = new myBinaryReader((Stream) memoryStream))
      {
        byte version = r.ReadByte();
        gameSettings.Deserialize(r, version);
      }
    }
    return gameSettings;
  }

  public void Copy(GameSettings b)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryReader r = new myBinaryReader((Stream) memoryStream))
      {
        using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
        {
          b.Serialize(w);
          memoryStream.Position = 0L;
          this.Deserialize(r, (byte) 5);
        }
      }
    }
  }

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.description);
    w.Write(this.gameModes);
    w.Write(this.gameModes2);
    w.Write(this.gameModes3);
    w.Write(this.gameModes4);
    w.Write(this.elementalLevel);
    w.Write(this.startHealth);
    w.Write(this.armageddonTurn);
    w.Write(this.countdownTime);
    w.Write(this.countdownDelay);
    w.Write(this.customTime);
    w.Write(this.customPlayerCount);
    w.Write((int) this.gameType);
    w.Write(this.altGeneration);
    w.Write((int) this.water);
    w.Write(this.restrictions == null ? (byte) 0 : (byte) 1);
    if (this.restrictions != null)
      this.restrictions.Serialize(w);
    w.Write(this.mapSeed);
    w.Write(this.fixedMapSeed);
    w.Write(this.mapWidth);
    w.Write(this.mapHeight);
    if (this.customArmageddon != null && this.customArmageddon.Count > 5)
    {
      while (this.customArmageddon.Count > 5)
        this.customArmageddon.RemoveAt(5);
    }
    w.Write(this.customArmageddon == null ? 0 : this.customArmageddon.Count);
    if (this.customArmageddon != null)
    {
      for (int index = 0; index < this.customArmageddon.Count; ++index)
        w.Write((int) this.customArmageddon[index]);
    }
    if (this.autoInclude != null && this.autoInclude.Count > 250)
      this.autoInclude.RemoveRange(250, this.autoInclude.Count - 250);
    w.Write(this.autoInclude == null ? 0 : this.autoInclude.Count);
    if (this.autoInclude == null)
      return;
    for (int index = 0; index < this.autoInclude.Count; ++index)
      w.Write((int) this.autoInclude[index]);
  }

  public void Deserialize(myBinaryReader r, byte version = 5)
  {
    this.description = r.ReadString();
    this.gameModes = r.ReadInt32();
    this.gameModes2 = r.ReadInt32();
    this.gameModes3 = r.ReadInt32();
    this.gameModes4 = r.ReadInt32();
    this.elementalLevel = r.ReadByte();
    this.startHealth = r.ReadUInt16();
    this.armageddonTurn = r.ReadByte();
    this.countdownTime = r.ReadInt16();
    this.countdownDelay = r.ReadByte();
    this.customTime = r.ReadUInt16();
    this.customPlayerCount = r.ReadByte();
    this.gameType = version <= (byte) 2 ? ZGame.GameType.Party : (ZGame.GameType) Mathf.Clamp(r.ReadInt32(), 0, 2);
    if (version > (byte) 4)
    {
      this.altGeneration = r.ReadBoolean();
      this.water = (WaterStyle) r.ReadInt32();
    }
    else
    {
      this.altGeneration = false;
      this.water = WaterStyle.Water;
    }
    byte version1 = r.ReadByte();
    if (version1 > (byte) 0)
    {
      if (this.restrictions != null)
        this.restrictions.DeserializeInstance(r);
      else
        this.restrictions = Restrictions.Deserialize(r, version1);
    }
    else
      this.restrictions = (Restrictions) null;
    if (version <= (byte) 1)
      return;
    this.mapSeed = r.ReadInt32();
    this.fixedMapSeed = r.ReadBoolean();
    this.mapWidth = r.ReadByte();
    this.mapHeight = r.ReadByte();
    if (version <= (byte) 3)
      return;
    int num1 = r.ReadInt32();
    if (num1 > 0 && num1 <= 5)
    {
      this.customArmageddon = new List<SpellEnum>();
      for (int index = 0; index < num1; ++index)
        this.customArmageddon.Add((SpellEnum) r.ReadInt32());
    }
    else
      this.customArmageddon = (List<SpellEnum>) null;
    if (version <= (byte) 4)
      return;
    int num2 = r.ReadInt32();
    if (num2 > 0 && num2 <= 250)
    {
      this.autoInclude = new List<SpellEnum>();
      for (int index = 0; index < num2; ++index)
        this.autoInclude.Add((SpellEnum) r.ReadInt32());
    }
    else
      this.autoInclude = (List<SpellEnum>) null;
  }

  public void Clamp()
  {
    this.elementalLevel = (byte) Mathf.Clamp((int) this.elementalLevel, 0, 5);
    this.startHealth = (ushort) Mathf.Clamp((int) this.startHealth, 1, 500);
    this.armageddonTurn = (byte) Mathf.Clamp((int) this.armageddonTurn, 0, 60);
    this.countdownTime = (short) Mathf.Clamp((int) this.countdownTime, -3600, 3600);
    this.countdownDelay = (byte) Mathf.Clamp((int) this.countdownDelay, 0, 30);
    this.customTime = (ushort) Mathf.Clamp((int) this.customTime, 5, 120);
    this.customPlayerCount = (byte) Mathf.Clamp((int) this.customPlayerCount, 1, 24);
    this.mapWidth = (byte) Mathf.Clamp((int) this.mapWidth, 50, 150);
    this.mapHeight = (byte) Mathf.Clamp((int) this.mapHeight, 50, 150);
  }
}
