
using System;
using UnityEngine;

public static class RotateImage
{
  private static Color32 purple = (Color32) new Color(254f, 191f, 254f);

  public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
  {
    return Quaternion.Euler(angles) * (point - pivot) + pivot;
  }

  public static MyLocation RotatePoint(
    MyLocation pointToRotate,
    MyLocation centerPoint,
    FixedInt angleInDegrees)
  {
    FixedInt x = angleInDegrees * (FixedInt.Pi / 180);
    FixedInt fixedInt1 = FixedInt.Cos(x);
    FixedInt fixedInt2 = FixedInt.Sin(x);
    return new MyLocation(fixedInt1 * (pointToRotate.x - centerPoint.x) - fixedInt2 * (pointToRotate.y - centerPoint.y) + centerPoint.x, fixedInt2 * (pointToRotate.x - centerPoint.x) + fixedInt1 * (pointToRotate.y - centerPoint.y) + centerPoint.y);
  }

  public static MyLocation RotatePointAroundPivot(
    MyLocation point,
    MyLocation pivot,
    FixedInt angle)
  {
    MyLocation myLocation1 = new MyLocation(FixedInt.Cos(angle), FixedInt.Sin(angle));
    MyLocation myLocation2 = new MyLocation(-FixedInt.Sin(angle), FixedInt.Cos(angle));
    MyLocation myLocation3 = point - pivot;
    myLocation3.x = myLocation1.x * myLocation3.x + myLocation1.y * myLocation3.y;
    myLocation3.y = myLocation2.x * myLocation3.x + myLocation2.y * myLocation3.y;
    return myLocation3 + pivot;
  }

  public static void Render(
    ZMap dst,
    Surface src,
    int x,
    int y,
    float angle,
    int renderMode,
    bool infront,
    bool forceAlpha = true,
    float scale = 1f)
  {
    int num1 = src.width / 2;
    int num2 = src.height / 2;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    double num5 = -0.75;
    double num6 = num5 + 2.0;
    double num7 = num5 + 3.0;
    double num8 = 5.0 * num5;
    double num9 = 8.0 * num5;
    double num10 = 4.0 * num5;
    int width = dst.Width;
    int height = dst.Height;
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, (float) src.height), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, (float) src.height), pivot, angles);
    int num11 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num12 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num13 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    for (int index1 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y)); index1 < num13; ++index1)
    {
      for (int index2 = num12; index2 < num11; ++index2)
      {
        double num14 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num15 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double a1 = (num14 - (double) num1) / num3 + (double) num1;
        double num16 = (double) num2;
        double a2 = (num15 - num16) / num3 + (double) num2;
        if (renderMode == 0 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int num17 = (int) a1;
          int num18 = (int) a2;
          Color32 c = new Color32();
          double num19 = 0.0;
          double num20 = 0.0;
          double num21 = 0.0;
          double num22 = 0.0;
          for (int index3 = num18 - 1; index3 <= num18 + 2; ++index3)
          {
            for (int index4 = num17 - 1; index4 <= num17 + 2; ++index4)
            {
              double num23 = Math.Abs(a1 - (double) index4);
              double num24 = Math.Abs(a2 - (double) index3);
              double num25 = num23 > 1.0 ? num5 * num23 * num23 * num23 - num8 * num23 * num23 + num9 * num23 - num10 : num6 * num23 * num23 * num23 - num7 * num23 * num23 + 1.0;
              double num26 = num24 > 1.0 ? num5 * num24 * num24 * num24 - num8 * num24 * num24 + num9 * num24 - num10 : num6 * num24 * num24 * num24 - num7 * num24 * num24 + 1.0;
              int x1 = index4;
              if (x1 < 0 || x1 > width - 1)
                x1 = num17;
              int y1 = index3;
              if (y1 < 0 || y1 > height - 1)
                y1 = num18;
              num19 += (double) src.get_Item(x1, y1).a * num25 * num26;
              num20 += (double) src.get_Item(x1, y1).r * num25 * num26;
              num21 += (double) src.get_Item(x1, y1).g * num25 * num26;
              num22 += (double) src.get_Item(x1, y1).b * num25 * num26;
            }
          }
          if (num19 > 254.0)
            num19 = (double) byte.MaxValue;
          if (num19 < 0.0)
            num19 = 0.0;
          if (num20 > 254.0)
            num20 = (double) byte.MaxValue;
          if (num20 < 0.0)
            num20 = 0.0;
          if (num21 > 254.0)
            num21 = (double) byte.MaxValue;
          if (num21 < 0.0)
            num21 = 0.0;
          if (num22 > 254.0)
            num22 = (double) byte.MaxValue;
          if (num22 < 0.0)
            num22 = 0.0;
          c.a = (byte) num19;
          c.r = (byte) num20;
          c.g = (byte) num21;
          c.b = (byte) num22;
          if (forceAlpha)
            c.a = c.a >= (byte) 40 ? byte.MaxValue : (byte) 0;
          if (c.a != (byte) 0)
          {
            if (infront || !dst.BitBltPixelNotAlpha(index2 + x - num1, index1 + y))
              dst.UpdatePixel(index2 + x - num1, index1 + y, c);
          }
          else
            continue;
        }
        if (renderMode == 1 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int x1 = (int) a1;
          if (x1 < 0)
            x1 = 0;
          int x2 = x1 + 1;
          if (x2 > width - 1)
            x2 = x1;
          int y1 = (int) a2;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num17 = a1 - (double) x1;
          double num18 = 1.0 - num17;
          double num19 = a2 - (double) y1;
          double num20 = 1.0 - num19;
          Color32 c = new Color32();
          Color32 color32_1 = src.get_Item(x1, y1);
          Color32 color32_2 = src.get_Item(x2, y1);
          Color32 color32_3 = src.get_Item(x1, y2);
          Color32 color32_4 = src.get_Item(x2, y2);
          double num21 = (double) color32_1.r * num18 + (double) color32_2.r * num17;
          double num22 = (double) color32_3.r * num18 + (double) color32_4.r * num17;
          c.r = (byte) (num21 * num20 + num22 * num19);
          double num23 = (double) color32_1.g * num18 + (double) color32_2.g * num17;
          double num24 = (double) color32_3.g * num18 + (double) color32_4.g * num17;
          c.g = (byte) (num23 * num20 + num24 * num19);
          double num25 = (double) color32_1.b * num18 + (double) color32_2.b * num17;
          double num26 = (double) color32_3.b * num18 + (double) color32_4.b * num17;
          c.b = (byte) (num25 * num20 + num26 * num19);
          double num27 = (double) color32_1.a * num18 + (double) color32_2.a * num17;
          double num28 = (double) color32_3.a * num18 + (double) color32_4.a * num17;
          c.a = (byte) (num27 * num20 + num28 * num19);
          if (forceAlpha)
            c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (c.a != (byte) 0)
          {
            if (infront || !dst.BitBltPixelNotAlpha(index2 + x - num1, index1 + y))
              dst.UpdatePixel(index2 + x - num1, index1 + y, c);
          }
          else
            continue;
        }
        if (renderMode == 2 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int x1 = (int) Math.Round(a1);
          int y1 = (int) Math.Round(a2);
          if (x1 >= 0 && x1 < width && (y1 >= 0 && y1 < height))
          {
            Color32 c = src.get_Item(x1, y1);
            if (c.a != (byte) 0 && (infront || !dst.BitBltPixelNotAlpha(index2 + x - num1, index1 + y)))
              dst.UpdatePixel(index2 + x - num1, index1 + y, c);
          }
        }
      }
    }
    dst.Apply();
  }

  public static void Render(
    ZMap dst,
    Surface src,
    int x,
    int y,
    FixedInt angle,
    int renderMode,
    bool infront,
    bool forceAlpha,
    FixedInt scale,
    bool apply = true)
  {
    while (angle < 0)
      angle += 360;
    while (angle > 360)
      angle -= 360;
    int xInt = src.width / 2;
    int yInt = src.height / 2;
    FixedInt fixedInt1 = scale;
    FixedInt x1 = FixedInt.Pi * angle / 180;
    FixedInt fixedInt2 = (FixedInt) -786432L;
    FixedInt fixedInt3 = fixedInt2 + 2;
    FixedInt fixedInt4 = fixedInt2 + 3;
    FixedInt fixedInt5 = (FixedInt) 5 * fixedInt2;
    FixedInt fixedInt6 = (FixedInt) 8 * fixedInt2;
    FixedInt fixedInt7 = (FixedInt) 4 * fixedInt2;
    int width = dst.Width;
    int height = dst.Height;
    MyLocation centerPoint = new MyLocation(xInt, yInt);
    FixedInt angleInDegrees = -angle;
    MyLocation myLocation1 = RotateImage.RotatePoint(new MyLocation(-src.width, -src.height), centerPoint, angleInDegrees);
    MyLocation myLocation2 = RotateImage.RotatePoint(new MyLocation(src.width, -src.height), centerPoint, angleInDegrees);
    MyLocation myLocation3 = RotateImage.RotatePoint(new MyLocation(-src.width, src.height), centerPoint, angleInDegrees);
    MyLocation myLocation4 = RotateImage.RotatePoint(new MyLocation(src.width, src.height), centerPoint, angleInDegrees);
    int num1 = (int) FixedInt.Max(FixedInt.Max((FixedInt) (int) myLocation1.x, (FixedInt) (int) myLocation2.x), FixedInt.Max((FixedInt) (int) myLocation3.x, (FixedInt) (int) myLocation4.x));
    int num2 = (int) FixedInt.Min(FixedInt.Min((FixedInt) (int) myLocation1.x, (FixedInt) (int) myLocation2.x), FixedInt.Min((FixedInt) (int) myLocation3.x, (FixedInt) (int) myLocation4.x));
    int num3 = (int) FixedInt.Max(FixedInt.Max((FixedInt) (int) myLocation1.y, (FixedInt) (int) myLocation2.y), FixedInt.Max((FixedInt) (int) myLocation3.y, (FixedInt) (int) myLocation4.y));
    for (int index1 = (int) FixedInt.Min(FixedInt.Min((FixedInt) (int) myLocation1.y, (FixedInt) (int) myLocation2.y), FixedInt.Min((FixedInt) (int) myLocation3.y, (FixedInt) (int) myLocation4.y)); index1 < num3; ++index1)
    {
      for (int index2 = num2; index2 < num1; ++index2)
      {
        FixedInt fixedInt8 = (FixedInt) (index2 - xInt) * FixedInt.Cos(x1) - (FixedInt) (index1 - yInt) * FixedInt.Sin(x1) + (FixedInt) xInt;
        FixedInt fixedInt9 = (FixedInt) (index2 - xInt) * FixedInt.Sin(x1) + (FixedInt) (index1 - yInt) * FixedInt.Cos(x1) + (FixedInt) yInt;
        FixedInt a1 = (fixedInt8 - (FixedInt) xInt) / fixedInt1 + (FixedInt) xInt;
        FixedInt fixedInt10 = (FixedInt) yInt;
        FixedInt a2 = (fixedInt9 - fixedInt10) / fixedInt1 + (FixedInt) yInt;
        if (renderMode == 0 && a1 >= 0 && (a1 < (FixedInt) width && a2 >= 0) && a2 < (FixedInt) height)
        {
          int num4 = (int) a1;
          int num5 = (int) a2;
          Color32 c = new Color32();
          FixedInt fixedInt11 = (FixedInt) 0;
          FixedInt fixedInt12 = (FixedInt) 0;
          FixedInt fixedInt13 = (FixedInt) 0;
          FixedInt fixedInt14 = (FixedInt) 0;
          for (int index3 = num5 - 1; index3 <= num5 + 2; ++index3)
          {
            for (int index4 = num4 - 1; index4 <= num4 + 2; ++index4)
            {
              FixedInt fixedInt15 = FixedInt.Abs(a1 - (FixedInt) index4);
              FixedInt fixedInt16 = FixedInt.Abs(a2 - (FixedInt) index3);
              FixedInt fixedInt17 = fixedInt15 > 1 ? fixedInt2 * fixedInt15 * fixedInt15 * fixedInt15 - fixedInt5 * fixedInt15 * fixedInt15 + fixedInt6 * fixedInt15 - fixedInt7 : fixedInt3 * fixedInt15 * fixedInt15 * fixedInt15 - fixedInt4 * fixedInt15 * fixedInt15 + 1;
              FixedInt fixedInt18 = fixedInt16 > 1 ? fixedInt2 * fixedInt16 * fixedInt16 * fixedInt16 - fixedInt5 * fixedInt16 * fixedInt16 + fixedInt6 * fixedInt16 - fixedInt7 : fixedInt3 * fixedInt16 * fixedInt16 * fixedInt16 - fixedInt4 * fixedInt16 * fixedInt16 + 1;
              int x2 = index4;
              if (x2 < 0 || x2 > width - 1)
                x2 = num4;
              int y1 = index3;
              if (y1 < 0 || y1 > height - 1)
                y1 = num5;
              fixedInt11 += (FixedInt) (int) src.get_Item(x2, y1).a * fixedInt17 * fixedInt18;
              fixedInt12 += (FixedInt) (int) src.get_Item(x2, y1).r * fixedInt17 * fixedInt18;
              fixedInt13 += (FixedInt) (int) src.get_Item(x2, y1).g * fixedInt17 * fixedInt18;
              fixedInt14 += (FixedInt) (int) src.get_Item(x2, y1).b * fixedInt17 * fixedInt18;
            }
          }
          if (fixedInt11 > 254)
            fixedInt11 = (FixedInt) (int) byte.MaxValue;
          if (fixedInt11 < 0)
            fixedInt11 = (FixedInt) 0;
          if (fixedInt12 > 254)
            fixedInt12 = (FixedInt) (int) byte.MaxValue;
          if (fixedInt12 < 0)
            fixedInt12 = (FixedInt) 0;
          if (fixedInt13 > 254)
            fixedInt13 = (FixedInt) (int) byte.MaxValue;
          if (fixedInt13 < 0)
            fixedInt13 = (FixedInt) 0;
          if (fixedInt14 > 254)
            fixedInt14 = (FixedInt) (int) byte.MaxValue;
          if (fixedInt14 < 0)
            fixedInt14 = (FixedInt) 0;
          c.a = (byte) (int) fixedInt11;
          c.r = (byte) (int) fixedInt12;
          c.g = (byte) (int) fixedInt13;
          c.b = (byte) (int) fixedInt14;
          if (forceAlpha)
            c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (c.a != (byte) 0)
          {
            int x2 = index2 + x - xInt;
            int y1 = index1 + y;
            if (x2 >= 0 && x2 < dst.Width && (y1 >= 0 && y1 < dst.Height) && (infront || !dst.BitBltPixelNotAlpha(x2, y1)))
              dst.UpdatePixel(x2, y1, c);
          }
          else
            continue;
        }
        if (renderMode == 1 && a1 >= 0 && (a1 < (FixedInt) width && a2 >= 0) && a2 < (FixedInt) height)
        {
          int x2 = (int) a1;
          if (x2 < 0)
            x2 = 0;
          int x3 = x2 + 1;
          if (x3 > width - 1)
            x3 = x2;
          int y1 = (int) a2;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          FixedInt fixedInt11 = a1 - (FixedInt) x2;
          FixedInt fixedInt12 = (FixedInt) 1 - fixedInt11;
          FixedInt fixedInt13 = a2 - (FixedInt) y1;
          FixedInt fixedInt14 = (FixedInt) 1 - fixedInt13;
          Color32 c = new Color32();
          Color32 color32_1 = src.get_Item(x2, y1);
          Color32 color32_2 = src.get_Item(x3, y1);
          Color32 color32_3 = src.get_Item(x2, y2);
          Color32 color32_4 = src.get_Item(x3, y2);
          FixedInt fixedInt15 = (FixedInt) (int) color32_1.r * fixedInt12 + (FixedInt) (int) color32_2.r * fixedInt11;
          FixedInt fixedInt16 = (FixedInt) (int) color32_3.r * fixedInt12 + (FixedInt) (int) color32_4.r * fixedInt11;
          c.r = (byte) (int) (fixedInt15 * fixedInt14 + fixedInt16 * fixedInt13);
          FixedInt fixedInt17 = (FixedInt) (int) color32_1.g * fixedInt12 + (FixedInt) (int) color32_2.g * fixedInt11;
          FixedInt fixedInt18 = (FixedInt) (int) color32_3.g * fixedInt12 + (FixedInt) (int) color32_4.g * fixedInt11;
          c.g = (byte) (int) (fixedInt17 * fixedInt14 + fixedInt18 * fixedInt13);
          FixedInt fixedInt19 = (FixedInt) (int) color32_1.b * fixedInt12 + (FixedInt) (int) color32_2.b * fixedInt11;
          FixedInt fixedInt20 = (FixedInt) (int) color32_3.b * fixedInt12 + (FixedInt) (int) color32_4.b * fixedInt11;
          c.b = (byte) (int) (fixedInt19 * fixedInt14 + fixedInt20 * fixedInt13);
          FixedInt fixedInt21 = (FixedInt) (int) color32_1.a * fixedInt12 + (FixedInt) (int) color32_2.a * fixedInt11;
          FixedInt fixedInt22 = (FixedInt) (int) color32_3.a * fixedInt12 + (FixedInt) (int) color32_4.a * fixedInt11;
          c.a = (byte) (int) (fixedInt21 * fixedInt14 + fixedInt22 * fixedInt13);
          if (forceAlpha)
            c.a = c.a >= (byte) 100 ? byte.MaxValue : (byte) 0;
          if (c.a != (byte) 0)
          {
            int x4 = index2 + x - xInt;
            int y3 = index1 + y;
            if (x4 >= 0 && x4 < dst.Width && (y3 >= 0 && y3 < dst.Height) && (infront || !dst.BitBltPixelNotAlpha(x4, y3)))
              dst.UpdatePixel(x4, y3, c);
          }
          else
            continue;
        }
        if (renderMode == 2 && a1 >= 0 && (a1 < (FixedInt) width && a2 >= 0) && a2 < (FixedInt) height)
        {
          int x2 = (int) FixedInt.Round(a1);
          int y1 = (int) FixedInt.Round(a2);
          if (x2 >= 0 && x2 < width && (y1 >= 0 && y1 < height))
          {
            Color32 c = src.get_Item(x2, y1);
            if (c.a != (byte) 0)
            {
              int x3 = index2 + x - xInt;
              int y2 = index1 + y;
              if (x3 >= 0 && x3 < dst.Width && (y2 >= 0 && y2 < dst.Height) && (infront || !dst.BitBltPixelNotAlpha(x3, y2)))
                dst.UpdatePixel(x3, y2, c);
            }
          }
        }
      }
    }
    if (!apply)
      return;
    dst.Apply();
  }

  public static void Render(
    Surface dst,
    Surface src,
    int x,
    int y,
    float angle,
    int renderMode,
    bool infront,
    bool forceAlpha = true,
    float scale = 1f)
  {
    int num1 = src.width / 2;
    int num2 = 0;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    double num5 = -0.75;
    double num6 = num5 + 2.0;
    double num7 = num5 + 3.0;
    double num8 = 5.0 * num5;
    double num9 = 8.0 * num5;
    double num10 = 4.0 * num5;
    int width = dst.width;
    int height = dst.height;
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, (float) src.height), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, (float) src.height), pivot, angles);
    int num11 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num12 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num13 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    for (int index1 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y)); index1 < num13; ++index1)
    {
      for (int index2 = num12; index2 < num11; ++index2)
      {
        double num14 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num15 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double a1 = (num14 - (double) num1) / num3 + (double) num1;
        double num16 = (double) num2;
        double a2 = (num15 - num16) / num3 + (double) num2;
        if (renderMode == 0 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int num17 = (int) a1;
          int num18 = (int) a2;
          Color32 c = new Color32();
          double num19 = 0.0;
          double num20 = 0.0;
          double num21 = 0.0;
          double num22 = 0.0;
          for (int index3 = num18 - 1; index3 <= num18 + 2; ++index3)
          {
            for (int index4 = num17 - 1; index4 <= num17 + 2; ++index4)
            {
              double num23 = Math.Abs(a1 - (double) index4);
              double num24 = Math.Abs(a2 - (double) index3);
              double num25 = num23 > 1.0 ? num5 * num23 * num23 * num23 - num8 * num23 * num23 + num9 * num23 - num10 : num6 * num23 * num23 * num23 - num7 * num23 * num23 + 1.0;
              double num26 = num24 > 1.0 ? num5 * num24 * num24 * num24 - num8 * num24 * num24 + num9 * num24 - num10 : num6 * num24 * num24 * num24 - num7 * num24 * num24 + 1.0;
              int x1 = index4;
              if (x1 < 0 || x1 > width - 1)
                x1 = num17;
              int y1 = index3;
              if (y1 < 0 || y1 > height - 1)
                y1 = num18;
              num19 += (double) src.get_Item(x1, y1).a * num25 * num26;
              num20 += (double) src.get_Item(x1, y1).r * num25 * num26;
              num21 += (double) src.get_Item(x1, y1).g * num25 * num26;
              num22 += (double) src.get_Item(x1, y1).b * num25 * num26;
            }
          }
          if (num19 > 254.0)
            num19 = (double) byte.MaxValue;
          if (num19 < 0.0)
            num19 = 0.0;
          if (num20 > 254.0)
            num20 = (double) byte.MaxValue;
          if (num20 < 0.0)
            num20 = 0.0;
          if (num21 > 254.0)
            num21 = (double) byte.MaxValue;
          if (num21 < 0.0)
            num21 = 0.0;
          if (num22 > 254.0)
            num22 = (double) byte.MaxValue;
          if (num22 < 0.0)
            num22 = 0.0;
          c.a = (byte) num19;
          c.r = (byte) num20;
          c.g = (byte) num21;
          c.b = (byte) num22;
          if (forceAlpha)
            c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
            dst.set_Item(index2 + x - num1, index1 + y, c);
        }
        if (renderMode == 1 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int x1 = (int) a1;
          if (x1 < 0)
            x1 = 0;
          int x2 = x1 + 1;
          if (x2 > width - 1)
            x2 = x1;
          int y1 = (int) a2;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num17 = a1 - (double) x1;
          double num18 = 1.0 - num17;
          double num19 = a2 - (double) y1;
          double num20 = 1.0 - num19;
          Color32 c = new Color32();
          Color32 color32_1 = src.get_Item(x1, y1);
          Color32 color32_2 = src.get_Item(x2, y1);
          Color32 color32_3 = src.get_Item(x1, y2);
          Color32 color32_4 = src.get_Item(x2, y2);
          double num21 = (double) color32_1.r * num18 + (double) color32_2.r * num17;
          double num22 = (double) color32_3.r * num18 + (double) color32_4.r * num17;
          c.r = (byte) (num21 * num20 + num22 * num19);
          double num23 = (double) color32_1.g * num18 + (double) color32_2.g * num17;
          double num24 = (double) color32_3.g * num18 + (double) color32_4.g * num17;
          c.g = (byte) (num23 * num20 + num24 * num19);
          double num25 = (double) color32_1.b * num18 + (double) color32_2.b * num17;
          double num26 = (double) color32_3.b * num18 + (double) color32_4.b * num17;
          c.b = (byte) (num25 * num20 + num26 * num19);
          double num27 = (double) color32_1.a * num18 + (double) color32_2.a * num17;
          double num28 = (double) color32_3.a * num18 + (double) color32_4.a * num17;
          c.a = (byte) (num27 * num20 + num28 * num19);
          if (forceAlpha)
            c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
            dst.set_Item(index2 + x - num1, index1 + y, c);
        }
        if (renderMode == 2 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int x1 = (int) Math.Round(a1);
          int y1 = (int) Math.Round(a2);
          if (x1 >= 0 && x1 < width && (y1 >= 0 && y1 < height))
          {
            Color32 c = src.get_Item(x1, y1);
            if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
              dst.set_Item(index2 + x - num1, index1 + y, c);
          }
        }
      }
    }
    dst.Apply();
  }

  public static void RenderOverlay(
    Surface dst,
    Surface src,
    int x,
    int y,
    float angle,
    int renderMode,
    bool infront,
    bool forceAlpha = true,
    float scale = 1f)
  {
    int num1 = src.width / 2;
    int num2 = 0;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    double num5 = -0.75;
    double num6 = num5 + 2.0;
    double num7 = num5 + 3.0;
    double num8 = 5.0 * num5;
    double num9 = 8.0 * num5;
    double num10 = 4.0 * num5;
    int width = dst.width;
    int height = dst.height;
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, (float) src.height), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, (float) src.height), pivot, angles);
    int num11 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num12 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num13 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    for (int index1 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y)); index1 < num13; ++index1)
    {
      for (int index2 = num12; index2 < num11; ++index2)
      {
        double num14 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num15 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double a1 = (num14 - (double) num1) / num3 + (double) num1;
        double num16 = (double) num2;
        double a2 = (num15 - num16) / num3 + (double) num2;
        if (renderMode == 0 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int num17 = (int) a1;
          int num18 = (int) a2;
          Color32 c = new Color32();
          double num19 = 0.0;
          double num20 = 0.0;
          double num21 = 0.0;
          double num22 = 0.0;
          for (int index3 = num18 - 1; index3 <= num18 + 2; ++index3)
          {
            for (int index4 = num17 - 1; index4 <= num17 + 2; ++index4)
            {
              double num23 = Math.Abs(a1 - (double) index4);
              double num24 = Math.Abs(a2 - (double) index3);
              double num25 = num23 > 1.0 ? num5 * num23 * num23 * num23 - num8 * num23 * num23 + num9 * num23 - num10 : num6 * num23 * num23 * num23 - num7 * num23 * num23 + 1.0;
              double num26 = num24 > 1.0 ? num5 * num24 * num24 * num24 - num8 * num24 * num24 + num9 * num24 - num10 : num6 * num24 * num24 * num24 - num7 * num24 * num24 + 1.0;
              int x1 = index4;
              if (x1 < 0 || x1 > width - 1)
                x1 = num17;
              int y1 = index3;
              if (y1 < 0 || y1 > height - 1)
                y1 = num18;
              num19 += (double) src.get_Item(x1, y1).a * num25 * num26;
              num20 += (double) src.get_Item(x1, y1).r * num25 * num26;
              num21 += (double) src.get_Item(x1, y1).g * num25 * num26;
              num22 += (double) src.get_Item(x1, y1).b * num25 * num26;
            }
          }
          if (num19 > 254.0)
            num19 = (double) byte.MaxValue;
          if (num19 < 0.0)
            num19 = 0.0;
          if (num20 > 254.0)
            num20 = (double) byte.MaxValue;
          if (num20 < 0.0)
            num20 = 0.0;
          if (num21 > 254.0)
            num21 = (double) byte.MaxValue;
          if (num21 < 0.0)
            num21 = 0.0;
          if (num22 > 254.0)
            num22 = (double) byte.MaxValue;
          if (num22 < 0.0)
            num22 = 0.0;
          c.a = (byte) num19;
          c.r = (byte) num20;
          c.g = (byte) num21;
          c.b = (byte) num22;
          if (forceAlpha)
            c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
          {
            if (c.a < byte.MaxValue && dst.get_Item(index2 + x - num1, index1 + y).a > (byte) 0)
              dst.set_Item(index2 + x - num1, index1 + y, Global.CombineColors((Color) dst.get_Item(index2 + x - num1, index1 + y), (Color) c));
            else
              dst.set_Item(index2 + x - num1, index1 + y, c);
          }
        }
        if (renderMode == 1 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int x1 = (int) a1;
          if (x1 < 0)
            x1 = 0;
          int x2 = x1 + 1;
          if (x2 > width - 1)
            x2 = x1;
          int y1 = (int) a2;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num17 = a1 - (double) x1;
          double num18 = 1.0 - num17;
          double num19 = a2 - (double) y1;
          double num20 = 1.0 - num19;
          Color32 c = new Color32();
          Color32 color32_1 = src.get_Item(x1, y1);
          Color32 color32_2 = src.get_Item(x2, y1);
          Color32 color32_3 = src.get_Item(x1, y2);
          Color32 color32_4 = src.get_Item(x2, y2);
          double num21 = (double) color32_1.r * num18 + (double) color32_2.r * num17;
          double num22 = (double) color32_3.r * num18 + (double) color32_4.r * num17;
          c.r = (byte) (num21 * num20 + num22 * num19);
          double num23 = (double) color32_1.g * num18 + (double) color32_2.g * num17;
          double num24 = (double) color32_3.g * num18 + (double) color32_4.g * num17;
          c.g = (byte) (num23 * num20 + num24 * num19);
          double num25 = (double) color32_1.b * num18 + (double) color32_2.b * num17;
          double num26 = (double) color32_3.b * num18 + (double) color32_4.b * num17;
          c.b = (byte) (num25 * num20 + num26 * num19);
          double num27 = (double) color32_1.a * num18 + (double) color32_2.a * num17;
          double num28 = (double) color32_3.a * num18 + (double) color32_4.a * num17;
          c.a = (byte) (num27 * num20 + num28 * num19);
          if (forceAlpha)
            c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
          {
            if (c.a < byte.MaxValue && dst.get_Item(index2 + x - num1, index1 + y).a > (byte) 0)
              dst.set_Item(index2 + x - num1, index1 + y, Global.CombineColors((Color) dst.get_Item(index2 + x - num1, index1 + y), (Color) c));
            else
              dst.set_Item(index2 + x - num1, index1 + y, c);
          }
        }
        if (renderMode == 2 && a1 >= 0.0 && (a1 < (double) width && a2 >= 0.0) && a2 < (double) height)
        {
          int x1 = (int) Math.Round(a1);
          int y1 = (int) Math.Round(a2);
          if (x1 >= 0 && x1 < width && (y1 >= 0 && y1 < height))
          {
            Color32 c = src.get_Item(x1, y1);
            if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
            {
              if (c.a < byte.MaxValue && dst.get_Item(index2 + x - num1, index1 + y).a > (byte) 0)
                dst.set_Item(index2 + x - num1, index1 + y, Global.CombineColors((Color) dst.get_Item(index2 + x - num1, index1 + y), (Color) c));
              else
                dst.set_Item(index2 + x - num1, index1 + y, c);
            }
          }
        }
      }
    }
    dst.Apply();
  }

  public static void Editor_RenderHUE(
    ZMap dst,
    Surface src,
    int x,
    int y,
    float angle,
    bool infront,
    float h,
    float scale = 1f,
    bool reversed = false,
    Color32? overrideColor = null)
  {
    int num1 = src.width / 2;
    int num2 = 0;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    int width = dst.Width;
    int height = dst.Height;
    float num5 = (float) (((double) src.width * (double) scale - (double) src.width) / 2.0);
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(-num5, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width * scale - num5, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(-num5, (float) src.height * scale), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width * scale - num5, (float) src.height * scale), pivot, angles);
    int num6 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num7 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num8 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    int num9 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y));
    int num10 = src.width - 1;
    for (int index1 = num9; index1 < num8; ++index1)
    {
      for (int index2 = num7; index2 < num6; ++index2)
      {
        double num11 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num12 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double num13 = (num11 - (double) num1) / num3 + (double) num1;
        double num14 = (double) num2;
        double num15 = (num12 - num14) / num3 + (double) num2;
        if (num13 >= 0.0 && num13 < (double) width && (num15 >= 0.0 && num15 < (double) height) && MapEditor.Instance.isSelected(new Point(index2 + x - num1, index1 + y)))
        {
          int num16 = (int) num13;
          if (num16 < 0)
            num16 = 0;
          int num17 = num16 + 1;
          if (num17 > width - 1)
            num17 = num16;
          int y1 = (int) num15;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num18 = num13 - (double) num16;
          double num19 = 1.0 - num18;
          double num20 = num15 - (double) y1;
          double num21 = 1.0 - num20;
          Color32 c = new Color32();
          Color32 color32_1 = src.get_Item(reversed ? num10 - num16 : num16, y1);
          Color32 color32_2 = src.get_Item(reversed ? num10 - num17 : num17, y1);
          Color32 color32_3 = src.get_Item(reversed ? num10 - num16 : num16, y2);
          Color32 color32_4 = src.get_Item(reversed ? num10 - num17 : num17, y2);
          double num22 = (double) color32_1.r * num19 + (double) color32_2.r * num18;
          double num23 = (double) color32_3.r * num19 + (double) color32_4.r * num18;
          c.r = (byte) (num22 * num21 + num23 * num20);
          double num24 = (double) color32_1.g * num19 + (double) color32_2.g * num18;
          double num25 = (double) color32_3.g * num19 + (double) color32_4.g * num18;
          c.g = (byte) (num24 * num21 + num25 * num20);
          double num26 = (double) color32_1.b * num19 + (double) color32_2.b * num18;
          double num27 = (double) color32_3.b * num19 + (double) color32_4.b * num18;
          c.b = (byte) (num26 * num21 + num27 * num20);
          double num28 = (double) color32_1.a * num19 + (double) color32_2.a * num18;
          double num29 = (double) color32_3.a * num19 + (double) color32_4.a * num18;
          c.a = (byte) (num28 * num21 + num29 * num20);
          c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront && c.a > (byte) 0 || dst.GetPixel(index2 + x - num1, index1 + y).a == (byte) 0 && c.a > (byte) 0)
          {
            Color32 color32_5 = overrideColor.HasValue ? overrideColor.Value : ColorHSV.AdjustColor(c, h);
            if (!Global.CompareColorsAlpha(color32_5, dst.GetPixel(index2 + x - num1, index1 + y)))
              dst.SetPixelColor(index2 + x - num1, index1 + y, color32_5);
          }
        }
      }
    }
  }

  public static void RenderHUE(
    ZMap dst,
    Surface src,
    int x,
    int y,
    float angle,
    bool infront,
    float h,
    float scale = 1f)
  {
    int num1 = src.width / 2;
    int num2 = 0;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    int width = dst.Width;
    int height = dst.Height;
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, (float) src.height), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, (float) src.height), pivot, angles);
    int num5 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num6 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num7 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    for (int index1 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y)); index1 < num7; ++index1)
    {
      for (int index2 = num6; index2 < num5; ++index2)
      {
        double num8 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num9 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double num10 = (num8 - (double) num1) / num3 + (double) num1;
        double num11 = (double) num2;
        double num12 = (num9 - num11) / num3 + (double) num2;
        if (num10 >= 0.0 && num10 < (double) width && (num12 >= 0.0 && num12 < (double) height))
        {
          int x1 = (int) num10;
          if (x1 < 0)
            x1 = 0;
          int x2 = x1 + 1;
          if (x2 > width - 1)
            x2 = x1;
          int y1 = (int) num12;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num13 = num10 - (double) x1;
          double num14 = 1.0 - num13;
          double num15 = num12 - (double) y1;
          double num16 = 1.0 - num15;
          Color32 c = new Color32();
          Color32 color32_1 = src.get_Item(x1, y1);
          Color32 color32_2 = src.get_Item(x2, y1);
          Color32 color32_3 = src.get_Item(x1, y2);
          Color32 color32_4 = src.get_Item(x2, y2);
          double num17 = (double) color32_1.r * num14 + (double) color32_2.r * num13;
          double num18 = (double) color32_3.r * num14 + (double) color32_4.r * num13;
          c.r = (byte) (num17 * num16 + num18 * num15);
          double num19 = (double) color32_1.g * num14 + (double) color32_2.g * num13;
          double num20 = (double) color32_3.g * num14 + (double) color32_4.g * num13;
          c.g = (byte) (num19 * num16 + num20 * num15);
          double num21 = (double) color32_1.b * num14 + (double) color32_2.b * num13;
          double num22 = (double) color32_3.b * num14 + (double) color32_4.b * num13;
          c.b = (byte) (num21 * num16 + num22 * num15);
          double num23 = (double) color32_1.a * num14 + (double) color32_2.a * num13;
          double num24 = (double) color32_3.a * num14 + (double) color32_4.a * num13;
          c.a = (byte) (num23 * num16 + num24 * num15);
          c.a = c.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.GetPixel(index2 + x - num1, index1 + y).a == (byte) 0)
          {
            Color32 p = ColorHSV.AdjustColor(c, h);
            dst.SetPixelColor(index2 + x - num1, index1 + y, p);
          }
        }
      }
    }
    dst.Apply();
  }

  public static void RenderHUE(
    Surface dst,
    Surface src,
    int x,
    int y,
    float angle,
    bool infront,
    float h,
    float scale = 1f,
    float saturation = -0.5f)
  {
    int num1 = src.width / 2;
    int num2 = 0;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    int width = dst.width;
    int height = dst.height;
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, (float) src.height), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, (float) src.height), pivot, angles);
    int num5 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num6 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num7 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    for (int index1 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y)); index1 < num7; ++index1)
    {
      for (int index2 = num6; index2 < num5; ++index2)
      {
        double num8 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num9 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double num10 = (num8 - (double) num1) / num3 + (double) num1;
        double num11 = (double) num2;
        double num12 = (num9 - num11) / num3 + (double) num2;
        if (num10 >= 0.0 && num10 < (double) width && (num12 >= 0.0 && num12 < (double) height))
        {
          int x1 = (int) num10;
          if (x1 < 0)
            x1 = 0;
          int x2 = x1 + 1;
          if (x2 > width - 1)
            x2 = x1;
          int y1 = (int) num12;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num13 = num10 - (double) x1;
          double num14 = 1.0 - num13;
          double num15 = num12 - (double) y1;
          double num16 = 1.0 - num15;
          Color32 c1 = new Color32();
          Color32 color32_1 = src.get_Item(x1, y1);
          Color32 color32_2 = src.get_Item(x2, y1);
          Color32 color32_3 = src.get_Item(x1, y2);
          Color32 color32_4 = src.get_Item(x2, y2);
          double num17 = (double) color32_1.r * num14 + (double) color32_2.r * num13;
          double num18 = (double) color32_3.r * num14 + (double) color32_4.r * num13;
          c1.r = (byte) (num17 * num16 + num18 * num15);
          double num19 = (double) color32_1.g * num14 + (double) color32_2.g * num13;
          double num20 = (double) color32_3.g * num14 + (double) color32_4.g * num13;
          c1.g = (byte) (num19 * num16 + num20 * num15);
          double num21 = (double) color32_1.b * num14 + (double) color32_2.b * num13;
          double num22 = (double) color32_3.b * num14 + (double) color32_4.b * num13;
          c1.b = (byte) (num21 * num16 + num22 * num15);
          double num23 = (double) color32_1.a * num14 + (double) color32_2.a * num13;
          double num24 = (double) color32_3.a * num14 + (double) color32_4.a * num13;
          c1.a = (byte) (num23 * num16 + num24 * num15);
          c1.a = c1.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
          {
            Color32 c2 = ColorHSV.AdjustColor(c1, h, saturation);
            dst.set_Item(index2 + x - num1, index1 + y, c2);
          }
        }
      }
    }
    dst.Apply();
  }

  public static void RenderHUEReversed(
    Surface dst,
    Surface src,
    int x,
    int y,
    float angle,
    bool infront,
    float h,
    float scale = 1f,
    float saturation = -0.5f)
  {
    int num1 = src.width / 2;
    int num2 = 0;
    double num3 = (double) scale;
    double num4 = Math.PI * (double) angle / 180.0;
    int width = dst.width;
    int height = dst.height;
    Vector3 pivot = new Vector3((float) num1, (float) num2);
    Vector3 angles = new Vector3(0.0f, 0.0f, -angle);
    Vector3 vector3_1 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, 0.0f), pivot, angles);
    Vector3 vector3_2 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, 0.0f), pivot, angles);
    Vector3 vector3_3 = RotateImage.RotatePointAroundPivot(new Vector3(0.0f, (float) src.height), pivot, angles);
    Vector3 vector3_4 = RotateImage.RotatePointAroundPivot(new Vector3((float) src.width, (float) src.height), pivot, angles);
    int num5 = Math.Max(Math.Max((int) vector3_1.x, (int) vector3_2.x), Math.Max((int) vector3_3.x, (int) vector3_4.x));
    int num6 = Math.Min(Math.Min((int) vector3_1.x, (int) vector3_2.x), Math.Min((int) vector3_3.x, (int) vector3_4.x));
    int num7 = Math.Max(Math.Max((int) vector3_1.y, (int) vector3_2.y), Math.Max((int) vector3_3.y, (int) vector3_4.y));
    int num8 = Math.Min(Math.Min((int) vector3_1.y, (int) vector3_2.y), Math.Min((int) vector3_3.y, (int) vector3_4.y));
    int num9 = src.width - 1;
    for (int index1 = num8; index1 < num7; ++index1)
    {
      for (int index2 = num6; index2 < num5; ++index2)
      {
        double num10 = (double) (index2 - num1) * Math.Cos(num4) - (double) (index1 - num2) * Math.Sin(num4) + (double) num1;
        double num11 = (double) (index2 - num1) * Math.Sin(num4) + (double) (index1 - num2) * Math.Cos(num4) + (double) num2;
        double num12 = (num10 - (double) num1) / num3 + (double) num1;
        double num13 = (double) num2;
        double num14 = (num11 - num13) / num3 + (double) num2;
        if (num12 >= 0.0 && num12 < (double) width && (num14 >= 0.0 && num14 < (double) height))
        {
          int num15 = (int) num12;
          if (num15 < 0)
            num15 = 0;
          int num16 = num15 + 1;
          if (num16 > width - 1)
            num16 = num15;
          int y1 = (int) num14;
          if (y1 < 0)
            y1 = 0;
          int y2 = y1 + 1;
          if (y2 > height - 1)
            y2 = y1;
          double num17 = num12 - (double) num15;
          double num18 = 1.0 - num17;
          double num19 = num14 - (double) y1;
          double num20 = 1.0 - num19;
          Color32 c1 = new Color32();
          Color32 color32_1 = src.get_Item(num9 - num15, y1);
          Color32 color32_2 = src.get_Item(num9 - num16, y1);
          Color32 color32_3 = src.get_Item(num9 - num15, y2);
          Color32 color32_4 = src.get_Item(num9 - num16, y2);
          double num21 = (double) color32_1.r * num18 + (double) color32_2.r * num17;
          double num22 = (double) color32_3.r * num18 + (double) color32_4.r * num17;
          c1.r = (byte) (num21 * num20 + num22 * num19);
          double num23 = (double) color32_1.g * num18 + (double) color32_2.g * num17;
          double num24 = (double) color32_3.g * num18 + (double) color32_4.g * num17;
          c1.g = (byte) (num23 * num20 + num24 * num19);
          double num25 = (double) color32_1.b * num18 + (double) color32_2.b * num17;
          double num26 = (double) color32_3.b * num18 + (double) color32_4.b * num17;
          c1.b = (byte) (num25 * num20 + num26 * num19);
          double num27 = (double) color32_1.a * num18 + (double) color32_2.a * num17;
          double num28 = (double) color32_3.a * num18 + (double) color32_4.a * num17;
          c1.a = (byte) (num27 * num20 + num28 * num19);
          c1.a = c1.a >= (byte) 150 ? byte.MaxValue : (byte) 0;
          if (infront || dst.get_Item(index2 + x - num1, index1 + y).a == (byte) 0)
          {
            Color32 c2 = ColorHSV.AdjustColor(c1, h, saturation);
            dst.set_Item(index2 + x - num1, index1 + y, c2);
          }
        }
      }
    }
    dst.Apply();
  }

  public static Color32 Purpalize(Color32 c, bool log = false)
  {
    float S;
    float V;
    Color.RGBToHSV((Color) c, out float _, out S, out V);
    return (Color32) Color.HSVToRGB(Mathf.Lerp(1f, 0.6f, V), S * 0.5f, V);
  }

  public static Color32 CallOfTheVoid(Color32 c)
  {
    float H;
    float V;
    Color.RGBToHSV((Color) c, out H, out float _, out V);
    float S = (float) ((double) V * 0.5 - 0.150000005960464);
    if ((double) S < 0.0)
      S = 0.0f;
    return (Color32) Color.HSVToRGB(H, S, V);
  }

  public static Color32 BloodStain(Color32 c)
  {
    float S;
    float V;
    Color.RGBToHSV((Color) c, out float _, out S, out V);
    return (Color32) Color.HSVToRGB(Mathf.Lerp(0.0f, 0.1f, V), S * 0.5f, V);
  }

  public static int ColorToInt(int b, int g, int r)
  {
    return b | g << 8 | r << 16;
  }

  public static int ColorToInt(Color32 c)
  {
    return (int) c.b | (int) c.g << 8 | (int) c.r << 16;
  }

  public static Color32 intToColor(int c)
  {
    return new Color32((byte) ((c & 16711680) >> 16), (byte) ((c & 65280) >> 8), (byte) (c & (int) byte.MaxValue), byte.MaxValue);
  }

  public static Vector3 intToVec(int c)
  {
    return new Vector3((float) (c & (int) byte.MaxValue) / (float) byte.MaxValue, (float) ((c & 65280) >> 8) / (float) byte.MaxValue, (float) ((c & 16711680) >> 16) / (float) byte.MaxValue);
  }
}
