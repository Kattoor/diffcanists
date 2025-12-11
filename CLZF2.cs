
using System;
using UnityEngine;

public static class CLZF2
{
  private static readonly uint HLOG = 14;
  private static readonly uint HSIZE = 16384;
  private static readonly uint MAX_LIT = 32;
  private static readonly uint MAX_OFF = 8192;
  private static readonly uint MAX_REF = 264;
  private static readonly long[] HashTable = new long[(int) CLZF2.HSIZE];

  public static byte[] Compress(byte[] inputBytes)
  {
    int length = inputBytes.Length / 2;
    byte[] output = new byte[length];
    int count;
    for (count = CLZF2.lzf_compress(inputBytes, ref output); count == 0; count = CLZF2.lzf_compress(inputBytes, ref output))
    {
      Debug.LogError((object) ("Realocation needed " + (object) length));
      length *= 2;
      output = new byte[length];
    }
    byte[] numArray = new byte[count];
    Buffer.BlockCopy((Array) output, 0, (Array) numArray, 0, count);
    return numArray;
  }

  public static byte[] Decompress(byte[] inputBytes)
  {
    int length = inputBytes.Length * 2;
    byte[] output = new byte[length];
    int count;
    for (count = CLZF2.lzf_decompress(inputBytes, ref output); count == 0; count = CLZF2.lzf_decompress(inputBytes, ref output))
    {
      length *= 2;
      output = new byte[length];
    }
    byte[] numArray = new byte[count];
    Buffer.BlockCopy((Array) output, 0, (Array) numArray, 0, count);
    return numArray;
  }

  public static int lzf_compress(byte[] input, ref byte[] output)
  {
    int length1 = input.Length;
    int length2 = output.Length;
    Array.Clear((Array) CLZF2.HashTable, 0, (int) CLZF2.HSIZE);
    uint num1 = 0;
    uint num2 = 0;
    uint num3 = (uint) input[(int) num1] << 8 | (uint) input[(int) num1 + 1];
    int num4 = 0;
label_1:
    do
    {
      if ((long) num1 < (long) (length1 - 2))
      {
        num3 = num3 << 8 | (uint) input[(int) num1 + 2];
        long index1 = (long) ((num3 ^ num3 << 5) >> 24 - (int) CLZF2.HLOG - (int) num3 * 5 & CLZF2.HSIZE - 1U);
        long index2 = CLZF2.HashTable[index1];
        CLZF2.HashTable[index1] = (long) num1;
        long num5;
        if ((num5 = (long) num1 - index2 - 1L) < (long) CLZF2.MAX_OFF && (long) (num1 + 4U) < (long) length1 && (index2 > 0L && (int) input[index2] == (int) input[(int) num1]) && ((int) input[index2 + 1L] == (int) input[(int) num1 + 1] && (int) input[index2 + 2L] == (int) input[(int) num1 + 2]))
        {
          uint num6 = 2;
          uint num7 = (uint) length1 - num1 - num6;
          uint num8 = num7 > CLZF2.MAX_REF ? CLZF2.MAX_REF : num7;
          if ((long) num2 + (long) num4 + 1L + 3L >= (long) length2)
            return 0;
          do
          {
            ++num6;
          }
          while (num6 < num8 && (int) input[index2 + (long) num6] == (int) input[(int) num1 + (int) num6]);
          if (num4 != 0)
          {
            output[(int) num2++] = (byte) (num4 - 1);
            num4 = -num4;
            do
            {
              output[(int) num2++] = input[(long) num1 + (long) num4];
            }
            while (++num4 != 0);
          }
          uint num9 = num6 - 2U;
          uint num10 = num1 + 1U;
          uint num11;
          if (num9 < 7U)
          {
            byte[] numArray = output;
            int index3 = (int) num2;
            num11 = (uint) (index3 + 1);
            int num12 = (int) (byte) ((ulong) (num5 >> 8) + (ulong) (num9 << 5));
            numArray[index3] = (byte) num12;
          }
          else
          {
            byte[] numArray1 = output;
            int index3 = (int) num2;
            uint num12 = (uint) (index3 + 1);
            int num13 = (int) (byte) ((ulong) (num5 >> 8) + 224UL);
            numArray1[index3] = (byte) num13;
            byte[] numArray2 = output;
            int index4 = (int) num12;
            num11 = (uint) (index4 + 1);
            int num14 = (int) (byte) (num9 - 7U);
            numArray2[index4] = (byte) num14;
          }
          byte[] numArray3 = output;
          int index5 = (int) num11;
          num2 = (uint) (index5 + 1);
          int num15 = (int) (byte) num5;
          numArray3[index5] = (byte) num15;
          uint num16 = num10 + (num9 - 1U);
          uint num17 = ((uint) input[(int) num16] << 8 | (uint) input[(int) num16 + 1]) << 8 | (uint) input[(int) num16 + 2];
          CLZF2.HashTable[(int) ((num17 ^ num17 << 5) >> 24 - (int) CLZF2.HLOG - (int) num17 * 5) & (int) CLZF2.HSIZE - 1] = (long) num16;
          uint num18 = num16 + 1U;
          num3 = num17 << 8 | (uint) input[(int) num18 + 2];
          CLZF2.HashTable[(int) ((num3 ^ num3 << 5) >> 24 - (int) CLZF2.HLOG - (int) num3 * 5) & (int) CLZF2.HSIZE - 1] = (long) num18;
          num1 = num18 + 1U;
          continue;
        }
      }
      else if ((long) num1 == (long) length1)
        goto label_19;
      ++num4;
      ++num1;
    }
    while ((long) num4 != (long) CLZF2.MAX_LIT);
    if ((long) (num2 + 1U + CLZF2.MAX_LIT) >= (long) length2)
      return 0;
    output[(int) num2++] = (byte) (CLZF2.MAX_LIT - 1U);
    num4 = -num4;
    do
    {
      output[(int) num2++] = input[(long) num1 + (long) num4];
    }
    while (++num4 != 0);
    goto label_1;
label_19:
    if (num4 != 0)
    {
      if ((long) num2 + (long) num4 + 1L >= (long) length2)
        return 0;
      output[(int) num2++] = (byte) (num4 - 1);
      int num5 = -num4;
      do
      {
        output[(int) num2++] = input[(long) num1 + (long) num5];
      }
      while (++num5 != 0);
    }
    return (int) num2;
  }

  public static int lzf_decompress(byte[] input, ref byte[] output)
  {
    int length1 = input.Length;
    int length2 = output.Length;
    uint num1 = 0;
    uint num2 = 0;
    do
    {
      uint num3 = (uint) input[(int) num1++];
      if (num3 < 32U)
      {
        uint num4 = num3 + 1U;
        if ((long) (num2 + num4) > (long) length2)
          return 0;
        do
        {
          output[(int) num2++] = input[(int) num1++];
        }
        while (--num4 != 0U);
      }
      else
      {
        uint num4 = num3 >> 5;
        int num5 = (int) num2 - (((int) num3 & 31) << 8) - 1;
        if (num4 == 7U)
          num4 += (uint) input[(int) num1++];
        int num6 = num5 - (int) input[(int) num1++];
        if ((long) (uint) ((int) num2 + (int) num4 + 2) > (long) length2 || num6 < 0)
          return 0;
        byte[] numArray1 = output;
        int index1 = (int) num2;
        uint num7 = (uint) (index1 + 1);
        byte[] numArray2 = output;
        int index2 = num6;
        int num8 = index2 + 1;
        int num9 = (int) numArray2[index2];
        numArray1[index1] = (byte) num9;
        byte[] numArray3 = output;
        int index3 = (int) num7;
        num2 = (uint) (index3 + 1);
        byte[] numArray4 = output;
        int index4 = num8;
        int num10 = index4 + 1;
        int num11 = (int) numArray4[index4];
        numArray3[index3] = (byte) num11;
        do
        {
          output[(int) num2++] = output[num10++];
        }
        while (--num4 != 0U);
      }
    }
    while ((long) num1 < (long) length1);
    return (int) num2;
  }
}
