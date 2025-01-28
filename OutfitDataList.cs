
using System;
using System.Collections.Generic;

[Serializable]
public class OutfitDataList
{
  public List<OutfitData> list;

  public void Clear()
  {
    this.list.Clear();
  }

  public int Length
  {
    get
    {
      return this.list.Count;
    }
  }

  public int Count
  {
    get
    {
      return this.list.Count;
    }
  }

  public OutfitData this[int x]
  {
    get
    {
      return x < this.list.Count ? this.list[x] : this.list[0];
    }
  }

  public int Random(Account a)
  {
    int max = 0;
    for (int index = 0; index < this.list.Count; ++index)
    {
      if (this.list[index].IsUnlocked(a))
        ++max;
    }
    if (max == 0)
      return 0;
    int num1 = 0;
    int num2 = UnityEngine.Random.Range(0, max);
    for (int index = 0; index < this.list.Count; ++index)
    {
      if (this.list[index].IsUnlocked(a))
      {
        if (num1 == num2)
          return index;
        ++num1;
      }
    }
    return UnityEngine.Random.Range(0, this.list.Count);
  }
}
