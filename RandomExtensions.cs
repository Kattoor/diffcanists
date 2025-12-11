
using Hazel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public static class RandomExtensions
{
  private static Dictionary<SpellEnum, int> spellToIndex;

  public static BookOf LastBook()
  {
    return BookOf.Sands;
  }

  public static int Clamp(this ZGame.GameType gameType)
  {
    return Mathf.Clamp((int) gameType, 0, 2);
  }

  public static T Random<T>(this List<T> t, System.Random r = null)
  {
    if (t.Count == 0)
      return default (T);
    return r == null ? t[UnityEngine.Random.Range(0, t.Count - 1)] : t[r.Next(0, t.Count - 1)];
  }

  public static T Modulo<T>(this List<T> t, int index)
  {
    return t.Count == 0 ? default (T) : t[index % t.Count];
  }

  public static int ToInt(this string s, int def = 0)
  {
    int result = 0;
    return int.TryParse(s, out result) ? result : def;
  }

  public static float ToFloat(this string s, float def = 0.0f)
  {
    float result = 0.0f;
    return float.TryParse(s, out result) ? result : def;
  }

  public static string ToStringX(this BookOf b, bool alt = false)
  {
    if (alt)
    {
      switch (b)
      {
        case BookOf.Arcane:
          return "Corrupt Arcane";
        case BookOf.Flame:
          return "Phoenix";
        case BookOf.Stone:
          return "Rock";
        case BookOf.Storm:
          return "Energy";
        case BookOf.Frost:
          return "Ice";
        case BookOf.Underdark:
          return "Necromancy";
        case BookOf.OverLight:
          return "Blessings";
        case BookOf.Nature:
          return "Forest";
        case BookOf.Seas:
          return "Water";
        case BookOf.Cogs:
          return "Steampunk";
        case BookOf.Seasons:
          return "Holiday";
        case BookOf.Illusion:
          return "Allusion";
        case BookOf.Blood:
          return "Flesh";
        case BookOf.Druidism:
          return "The Wilds";
        case BookOf.Cosmos:
          return "Aliens";
        case BookOf.Sands:
          return "Desert";
      }
    }
    return b.ToString().Replace("_", " ");
  }

  public static Color32 To32(this Color c)
  {
    return new Color32()
    {
      r = (byte) Mathf.Clamp(Mathf.Round(c.r * (float) byte.MaxValue), 0.0f, (float) byte.MaxValue),
      g = (byte) Mathf.Clamp(Mathf.Round(c.g * (float) byte.MaxValue), 0.0f, (float) byte.MaxValue),
      b = (byte) Mathf.Clamp(Mathf.Round(c.b * (float) byte.MaxValue), 0.0f, (float) byte.MaxValue),
      a = (byte) Mathf.Clamp(Mathf.Round(c.a * (float) byte.MaxValue), 0.0f, (float) byte.MaxValue)
    };
  }

  public static bool Online(this Location loc)
  {
    return loc > Location.Disconnecting;
  }

  public static void HideIfWebGL(this GameObject g)
  {
  }

  public static List<int> AllIndexesOf(this string str, string value)
  {
    List<int> intList = new List<int>();
    if (string.IsNullOrEmpty(value))
      return intList;
    int startIndex = 0;
    while (true)
    {
      int num = str.IndexOf(value, startIndex);
      if (num != -1)
      {
        intList.Add(num);
        startIndex = num + value.Length;
      }
      else
        break;
    }
    return intList;
  }

  public static bool ContainsSpecialCharacters(this string s)
  {
    return Regex.IsMatch(s, "[^a-zA-Z0-9_. -]");
  }

  public static bool IsFlight(this SpellEnum e)
  {
    return e == SpellEnum.Flight || e == SpellEnum.Whistling_Winds || e == SpellEnum.Vampire_Bat;
  }

  public static bool Has(this FamiliarType f, FamiliarType t)
  {
    return (uint) (f & t) > 0U;
  }

  public static int Index(this SpellEnum s)
  {
    if (RandomExtensions.spellToIndex == null)
    {
      RandomExtensions.spellToIndex = new Dictionary<SpellEnum, int>(Inert.Instance.spells.Count);
      for (int index = 0; index < Inert.Instance.spells.Count; ++index)
        RandomExtensions.spellToIndex[Inert.Instance.spells[index].spellEnum] = index;
    }
    int num = 0;
    return RandomExtensions.spellToIndex.TryGetValue(s, out num) ? num : -1;
  }

  public static bool CaseInsensitiveContains(
    this string text,
    string value,
    StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
  {
    return text.IndexOf(value, stringComparison) >= 0;
  }

  public static void SetPosition(this Transform t, MyLocation p)
  {
    t.position = (Vector3) p.ToSinglePrecision();
  }

  public static void DestroyThis(this Component a)
  {
    UnityEngine.Object.Destroy((UnityEngine.Object) a);
  }

  public static int Squared(this int x)
  {
    return x * x;
  }

  public static FixedInt Squared(this FixedInt x)
  {
    return x * x;
  }

  public static void DestroyChildern(this RectTransform a)
  {
    for (int index = a.childCount - 1; index >= 0; --index)
      UnityEngine.Object.Destroy((UnityEngine.Object) a.GetChild(index).gameObject);
    a.DetachChildren();
  }

  public static string ToStringX(this byte[] b, string begining)
  {
    StringBuilder stringBuilder = new StringBuilder(begining);
    stringBuilder.Append(" {");
    for (int index = 0; index < b.Length - 1; ++index)
      stringBuilder.Append(b[index]).Append(", ");
    if (b.Length != 0)
      stringBuilder.Append(b[b.Length - 1]);
    stringBuilder.Append("}");
    return stringBuilder.ToString();
  }

  public static bool HasStyle(this GameStyle s, GameStyle t)
  {
    return (uint) (s & t) > 0U;
  }

  public static void SetNativeSize2(this Image i)
  {
    Sprite sprite = i.sprite;
    if (!((UnityEngine.Object) sprite != (UnityEngine.Object) null))
      return;
    ((RectTransform) i.transform).sizeDelta = new Vector2((float) sprite.texture.width, (float) sprite.texture.height);
  }

  public static void StartColor(this ParticleSystem p, Color c)
  {
    p.main.startColor = (ParticleSystem.MinMaxGradient) c;
  }

  public static Color32[] GetReadablePixels(this Texture2D texture)
  {
    if (texture.isReadable)
      return texture.GetPixels32();
    RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
    Graphics.Blit((Texture) texture, temporary);
    RenderTexture active = RenderTexture.active;
    RenderTexture.active = temporary;
    Texture2D texture2D = new Texture2D(texture.width, texture.height);
    texture2D.ReadPixels(new Rect(0.0f, 0.0f, (float) temporary.width, (float) temporary.height), 0, 0);
    texture2D.Apply();
    RenderTexture.active = active;
    RenderTexture.ReleaseTemporary(temporary);
    return texture2D.GetPixels32();
  }

  public static Color[] GetReadablePixels(
    this Texture2D texture,
    int x,
    int y,
    int blockWidth,
    int blockHeight)
  {
    RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
    Graphics.Blit((Texture) texture, temporary);
    RenderTexture active = RenderTexture.active;
    RenderTexture.active = temporary;
    Texture2D texture2D = new Texture2D(texture.width, texture.height);
    texture2D.ReadPixels(new Rect(0.0f, 0.0f, (float) temporary.width, (float) temporary.height), 0, 0);
    texture2D.Apply();
    RenderTexture.active = active;
    RenderTexture.ReleaseTemporary(temporary);
    return texture2D.GetPixels(x, y, blockWidth, blockHeight);
  }

  public static bool CompareColors(Color32 a, Color32 b)
  {
    return (int) a.r == (int) b.r && (int) a.g == (int) b.g && (int) a.b == (int) b.b;
  }

  public static Color32 RandomColor(System.Random r)
  {
    return new Color32((byte) r.Next((int) byte.MaxValue), (byte) r.Next((int) byte.MaxValue), (byte) r.Next((int) byte.MaxValue), byte.MaxValue);
  }

  public static bool Is(this OperatingSystem os, OperatingSystem e)
  {
    return (uint) (os & e) > 0U;
  }

  public static bool IsNot(this OperatingSystem os, OperatingSystem e)
  {
    return (os & e) == (OperatingSystem) 0;
  }

  public static string GetFirstFlags(this AccountType value)
  {
    foreach (AccountType accountType in Enum.GetValues(typeof (AccountType)))
    {
      if (value.HasFlag((Enum) accountType) && accountType != AccountType.None)
        return accountType.ToString();
    }
    return "";
  }

  public static string GetActiveFlags(this AccountType value)
  {
    StringBuilder stringBuilder = new StringBuilder();
    foreach (AccountType accountType in Enum.GetValues(typeof (AccountType)))
    {
      if (value.HasFlag((Enum) accountType) && accountType != AccountType.None)
        stringBuilder.Append(accountType.ToString()).Append(", ");
    }
    if (stringBuilder.Length > 0)
      stringBuilder.Length -= 2;
    return stringBuilder.ToString();
  }
}
