
using System;
using UnityEngine;

public static class HSVUtil
{
  public static HsvColor ConvertRgbToHsv(Color color)
  {
    return HSVUtil.ConvertRgbToHsv((double) (int) ((double) color.r * (double) byte.MaxValue), (double) (int) ((double) color.g * (double) byte.MaxValue), (double) (int) ((double) color.b * (double) byte.MaxValue));
  }

  public static HsvColor ConvertRgbToHsv(double r, double b, double g)
  {
    double num1 = 0.0;
    double num2 = Math.Min(Math.Min(r, g), b);
    double num3 = Math.Max(Math.Max(r, g), b);
    double num4 = num3 - num2;
    double num5 = num3 != 0.0 ? num4 / num3 : 0.0;
    double num6;
    if (num5 == 0.0)
    {
      num6 = 360.0;
    }
    else
    {
      if (r == num3)
        num1 = (g - b) / num4;
      else if (g == num3)
        num1 = 2.0 + (b - r) / num4;
      else if (b == num3)
        num1 = 4.0 + (r - g) / num4;
      num6 = num1 * 60.0;
      if (num6 <= 0.0)
        num6 += 360.0;
    }
    return new HsvColor()
    {
      H = 360.0 - num6,
      S = num5,
      V = num3 / (double) byte.MaxValue
    };
  }

  public static Color ConvertHsvToRgb(double h, double s, double v, float alpha)
  {
    double num1;
    double num2;
    double num3;
    if (s == 0.0)
    {
      num1 = v;
      num2 = v;
      num3 = v;
    }
    else
    {
      if (h == 360.0)
        h = 0.0;
      else
        h /= 60.0;
      int num4 = (int) h;
      double num5 = h - (double) num4;
      double num6 = v * (1.0 - s);
      double num7 = v * (1.0 - s * num5);
      double num8 = v * (1.0 - s * (1.0 - num5));
      switch (num4)
      {
        case 0:
          num1 = v;
          num2 = num8;
          num3 = num6;
          break;
        case 1:
          num1 = num7;
          num2 = v;
          num3 = num6;
          break;
        case 2:
          num1 = num6;
          num2 = v;
          num3 = num8;
          break;
        case 3:
          num1 = num6;
          num2 = num7;
          num3 = v;
          break;
        case 4:
          num1 = num8;
          num2 = num6;
          num3 = v;
          break;
        default:
          num1 = v;
          num2 = num6;
          num3 = num7;
          break;
      }
    }
    return new Color((float) num1, (float) num2, (float) num3, alpha);
  }
}
