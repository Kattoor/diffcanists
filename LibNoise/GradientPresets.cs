
using System.Collections.Generic;
using UnityEngine;

namespace LibNoise
{
  public static class GradientPresets
  {
    private static readonly Gradient _empty;
    private static readonly Gradient _grayscale;
    private static readonly Gradient _rgb;
    private static readonly Gradient _rgba;
    private static readonly Gradient _terrain;

    static GradientPresets()
    {
      List<GradientColorKey> gradientColorKeyList1 = new List<GradientColorKey>()
      {
        new GradientColorKey(Color.black, 0.0f),
        new GradientColorKey(Color.white, 1f)
      };
      List<GradientColorKey> gradientColorKeyList2 = new List<GradientColorKey>()
      {
        new GradientColorKey(Color.red, 0.0f),
        new GradientColorKey(Color.green, 0.5f),
        new GradientColorKey(Color.blue, 1f)
      };
      List<GradientColorKey> gradientColorKeyList3 = new List<GradientColorKey>()
      {
        new GradientColorKey(Color.red, 0.0f),
        new GradientColorKey(Color.green, 0.3333333f),
        new GradientColorKey(Color.blue, 0.6666667f),
        new GradientColorKey(Color.black, 1f)
      };
      List<GradientAlphaKey> gradientAlphaKeyList1 = new List<GradientAlphaKey>()
      {
        new GradientAlphaKey(0.0f, 0.6666667f),
        new GradientAlphaKey(1f, 1f)
      };
      List<GradientColorKey> gradientColorKeyList4 = new List<GradientColorKey>()
      {
        new GradientColorKey(new Color(0.0f, 0.0f, 0.5f), 0.0f),
        new GradientColorKey(new Color(0.125f, 0.25f, 0.5f), 0.4f),
        new GradientColorKey(new Color(0.25f, 0.375f, 0.75f), 0.48f),
        new GradientColorKey(new Color(0.0f, 0.75f, 0.0f), 0.5f),
        new GradientColorKey(new Color(0.75f, 0.75f, 0.0f), 0.625f),
        new GradientColorKey(new Color(0.625f, 0.375f, 0.25f), 0.75f),
        new GradientColorKey(new Color(0.5f, 1f, 1f), 0.875f),
        new GradientColorKey(Color.white, 1f)
      };
      List<GradientAlphaKey> gradientAlphaKeyList2 = new List<GradientAlphaKey>()
      {
        new GradientAlphaKey(1f, 0.0f),
        new GradientAlphaKey(1f, 1f)
      };
      GradientPresets._empty = new Gradient();
      GradientPresets._rgb = new Gradient();
      GradientPresets._rgb.SetKeys(gradientColorKeyList2.ToArray(), gradientAlphaKeyList2.ToArray());
      GradientPresets._rgba = new Gradient();
      GradientPresets._rgba.SetKeys(gradientColorKeyList3.ToArray(), gradientAlphaKeyList1.ToArray());
      GradientPresets._grayscale = new Gradient();
      GradientPresets._grayscale.SetKeys(gradientColorKeyList1.ToArray(), gradientAlphaKeyList2.ToArray());
      GradientPresets._terrain = new Gradient();
      GradientPresets._terrain.SetKeys(gradientColorKeyList4.ToArray(), gradientAlphaKeyList2.ToArray());
    }

    public static Gradient Empty
    {
      get
      {
        return GradientPresets._empty;
      }
    }

    public static Gradient Grayscale
    {
      get
      {
        return GradientPresets._grayscale;
      }
    }

    public static Gradient RGB
    {
      get
      {
        return GradientPresets._rgb;
      }
    }

    public static Gradient RGBA
    {
      get
      {
        return GradientPresets._rgba;
      }
    }

    public static Gradient Terrain
    {
      get
      {
        return GradientPresets._terrain;
      }
    }
  }
}
