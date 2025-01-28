
using UnityEngine;

public static class Prefs
{
  public static bool charPreview
  {
    get
    {
      return Prefs.GetBool(nameof (charPreview), false);
    }
    set
    {
      Prefs.SetBool(nameof (charPreview), value);
    }
  }

  public static Color32 previewColor
  {
    get
    {
      return Prefs.GetColor(nameof (previewColor), (Color32) Color.black);
    }
    set
    {
      Prefs.SetColor(nameof (previewColor), value);
    }
  }

  public static void SetString(string p, string v)
  {
    PlayerPrefs.SetString(p, v);
  }

  public static void SetFloat(string p, float v)
  {
    PlayerPrefs.SetFloat(p, v);
  }

  public static void SetInt(string p, int v)
  {
    PlayerPrefs.SetInt(p, v);
  }

  public static void SetBool(string p, bool v)
  {
    PlayerPrefs.SetInt(p, v ? 1 : 0);
  }

  public static void SetColor(string p, Color32 v)
  {
    PlayerPrefs.SetInt(p, v.ToInt());
  }

  public static string GetString(string p, string v = "")
  {
    return PlayerPrefs.GetString(p, v);
  }

  public static float GetFloat(string p, float v = 0.0f)
  {
    return PlayerPrefs.GetFloat(p, v);
  }

  public static int GetInt(string p, int v = 0)
  {
    return PlayerPrefs.GetInt(p, v);
  }

  public static bool GetBool(string p, bool v = true)
  {
    return PlayerPrefs.GetInt(p, v ? 1 : 0) == 1;
  }

  public static Color32 GetColor(string p, Color32 c)
  {
    return PlayerPrefs.GetInt(p, c.ToInt()).ToColor();
  }
}
