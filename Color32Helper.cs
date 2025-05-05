
using UnityEngine;

#nullable disable
public static class Color32Helper
{
  public static int ToInt(this Color32 color)
  {
    return (int) color.r << 24 | (int) color.g << 16 | (int) color.b << 8 | (int) color.a;
  }

  public static Color32 ToColor(this int value)
  {
    int r = (int) (byte) (value >> 24 & (int) byte.MaxValue);
    byte num1 = (byte) (value >> 16 & (int) byte.MaxValue);
    byte num2 = (byte) (value >> 8 & (int) byte.MaxValue);
    byte num3 = (byte) (value & (int) byte.MaxValue);
    int g = (int) num1;
    int b = (int) num2;
    int a = (int) num3;
    return new Color32((byte) r, (byte) g, (byte) b, (byte) a);
  }
}
