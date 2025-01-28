
using MoonSharp.Interpreter;
using UnityEngine;

namespace Educative
{
  public class Settings
  {
    [MoonSharpHidden]
    public SettingsPlayer settings = new SettingsPlayer();

    [MoonSharpHidden]
    public Settings(SettingsPlayer s)
    {
      this.settings.CopyOutfit(s);
      this.settings.CopySpells(s, false);
    }

    public Settings(Table outfit, Table colors, Table spells, BookOf elemental)
    {
      this.settings.fullBook = (byte) (elemental + 1);
      int num = 0;
      if (outfit != null)
      {
        foreach (DynValue dynValue in outfit.Values)
        {
          this.settings.SetOutfitIndex((Outfit) num, (byte) dynValue.CastToNumber().Value);
          ++num;
          if (num > 8)
            break;
        }
      }
      Color color;
      if (colors != null && colors.Length > 0 && ColorUtility.TryParseHtmlString((string) colors[(object) 1], out color))
        this.settings.coloring.colors[0].red = (Color32) color;
      if (colors != null && colors.Length > 1 && ColorUtility.TryParseHtmlString((string) colors[(object) 2], out color))
        this.settings.coloring.colors[0].green = (Color32) color;
      if (colors != null && colors.Length > 2 && ColorUtility.TryParseHtmlString((string) colors[(object) 3], out color))
        this.settings.coloring.colors[0].blue = (Color32) color;
      if (colors != null && colors.Length > 3 && ColorUtility.TryParseHtmlString((string) colors[(object) 4], out color))
        this.settings.coloring.colors[0].gray = (Color32) color;
      for (int index = 1; index < this.settings.coloring.colors.Length; ++index)
      {
        this.settings.coloring.colors[index].red = this.settings.coloring.colors[0].red;
        this.settings.coloring.colors[index].green = this.settings.coloring.colors[0].green;
        this.settings.coloring.colors[index].blue = this.settings.coloring.colors[0].blue;
        this.settings.coloring.colors[index].gray = this.settings.coloring.colors[0].gray;
      }
      int index1 = 0;
      if (spells != null)
      {
        foreach (DynValue dynValue in spells.Values)
        {
          this.settings.spells[index1] = (byte) Inert.Instance.spells.IndexOf(dynValue.CastToString().Trim());
          ++index1;
          if (index1 >= 16)
            break;
        }
      }
      for (; index1 < 16; ++index1)
        this.settings.spells[index1] = byte.MaxValue;
    }

    public Settings(Table spells)
    {
      int index = 0;
      foreach (DynValue dynValue in spells.Values)
      {
        this.settings.spells[index] = (byte) Inert.Instance.spells.IndexOf(dynValue.CastToString().Trim());
        ++index;
        if (index >= 16)
          break;
      }
    }
  }
}
