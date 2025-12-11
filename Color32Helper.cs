
using UnityEngine;

public static class Color32Helper
{
  public static int ToInt(this Color32 color)
  {
    return (int) color.r << 24 | (int) color.g << 16 | (int) color.b << 8 | (int) color.a;
  }

  public static Color32 ToColor(this int value)
  {
    int num1 = (int) (byte) (value >> 24 & (int) byte.MaxValue);
    byte num2 = (byte) (value >> 16 & (int) byte.MaxValue);
    byte num3 = (byte) (value >> 8 & (int) byte.MaxValue);
    byte num4 = (byte) (value & (int) byte.MaxValue);
    int num5 = (int) num2;
    int num6 = (int) num3;
    int num7 = (int) num4;
    return new Color32((byte) num1, (byte) num5, (byte) num6, (byte) num7);
  }
}
