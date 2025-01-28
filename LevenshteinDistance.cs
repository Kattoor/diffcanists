
using Hazel;
using System;

public static class LevenshteinDistance
{
  public static AccountType ClosestAccountType(string s)
  {
    string[] names = Enum.GetNames(typeof (AccountType));
    int index1 = -1;
    int num1 = int.MaxValue;
    for (int index2 = 0; index2 < names.Length; ++index2)
    {
      int num2 = LevenshteinDistance.Compute2(s.ToLower(), names[index2].ToLower());
      if (num2 < num1)
      {
        index1 = index2;
        num1 = num2;
        if (num2 == 0)
          break;
      }
    }
    return index1 >= 0 ? (AccountType) Enum.Parse(typeof (AccountType), names[index1]) : AccountType.None;
  }

  public static T Closest<T>(string s, T defaultT = null)
  {
    string[] names = Enum.GetNames(typeof (T));
    int index1 = -1;
    int num1 = int.MaxValue;
    for (int index2 = 0; index2 < names.Length; ++index2)
    {
      int num2 = LevenshteinDistance.Compute2(s.ToLower(), names[index2].ToLower());
      if (num2 < num1)
      {
        index1 = index2;
        num1 = num2;
        if (num2 == 0)
          break;
      }
    }
    return index1 >= 0 ? (T) Enum.Parse(typeof (T), names[index1]) : defaultT;
  }

  public static int Compute2(string s, string t)
  {
    if (string.Equals(s, t, StringComparison.OrdinalIgnoreCase))
      return 0;
    for (int index = 0; index < s.Length && index < t.Length; ++index)
    {
      if ((int) s[index] != (int) t[index] && (s[index] != ' ' || t[index] != '_'))
        return LevenshteinDistance.Compute(s, t);
    }
    return 0;
  }

  public static int Compute(string s, string t)
  {
    int length1 = s.Length;
    int length2 = t.Length;
    int[,] numArray = new int[length1 + 1, length2 + 1];
    if (length1 == 0)
      return length2;
    if (length2 == 0)
      return length1;
    int index1 = 0;
    while (index1 <= length1)
      numArray[index1, 0] = index1++;
    int index2 = 0;
    while (index2 <= length2)
      numArray[0, index2] = index2++;
    for (int index3 = 1; index3 <= length1; ++index3)
    {
      for (int index4 = 1; index4 <= length2; ++index4)
      {
        int num = (int) t[index4 - 1] == (int) s[index3 - 1] ? 0 : 1;
        numArray[index3, index4] = Math.Min(Math.Min(numArray[index3 - 1, index4] + 1, numArray[index3, index4 - 1] + 1), numArray[index3 - 1, index4 - 1] + num);
      }
    }
    return numArray[length1, length2];
  }
}
