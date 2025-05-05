
using UnityEngine;

#nullable disable
public static class Prefs
{
  public static bool charPreview
  {
    get => Prefs.GetBool(nameof (charPreview), false);
    set => Prefs.SetBool(nameof (charPreview), value);
  }

  public static Color32 previewColor
  {
    get => Prefs.GetColor(nameof (previewColor), (Color32) Color.black);
    set => Prefs.SetColor(nameof (previewColor), value);
  }

  public static int mapEditorWidthX
  {
    get => Prefs.GetInt(nameof (mapEditorWidthX), 1920);
    set => Prefs.SetInt(nameof (mapEditorWidthX), value);
  }

  public static int mapEditorWidthY
  {
    get => Prefs.GetInt(nameof (mapEditorWidthY), 960);
    set => Prefs.SetInt(nameof (mapEditorWidthY), value);
  }

  public static void SetString(string p, string v) => PlayerPrefs.SetString(p, v);

  public static void SetFloat(string p, float v) => PlayerPrefs.SetFloat(p, v);

  public static void SetInt(string p, int v) => PlayerPrefs.SetInt(p, v);

  public static void SetBool(string p, bool v) => PlayerPrefs.SetInt(p, v ? 1 : 0);

  public static void SetColor(string p, Color32 v) => PlayerPrefs.SetInt(p, v.ToInt());

  public static string GetString(string p, string v = "") => PlayerPrefs.GetString(p, v);

  public static float GetFloat(string p, float v = 0.0f) => PlayerPrefs.GetFloat(p, v);

  public static int GetInt(string p, int v = 0) => PlayerPrefs.GetInt(p, v);

  public static bool GetBool(string p, bool v = true) => PlayerPrefs.GetInt(p, v ? 1 : 0) == 1;

  public static Color32 GetColor(string p, Color32 c) => PlayerPrefs.GetInt(p, c.ToInt()).ToColor();
}
