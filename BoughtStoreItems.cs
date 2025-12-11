
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class BoughtStoreItems
{
  public List<List<int>> list = new List<List<int>>();
  [JsonIgnore]
  [NonSerialized]
  public bool changes;

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.list.Count);
    for (int index1 = 0; index1 < this.list.Count; ++index1)
    {
      w.Write(this.list[index1].Count);
      for (int index2 = 0; index2 < this.list[index1].Count; ++index2)
        w.Write(this.list[index1][index2]);
    }
  }

  public static BoughtStoreItems Deserialize(myBinaryReader r)
  {
    BoughtStoreItems boughtStoreItems = new BoughtStoreItems();
    int num1 = r.ReadInt32();
    for (int index1 = 0; index1 < num1; ++index1)
    {
      List<int> intList = new List<int>();
      int num2 = r.ReadInt32();
      for (int index2 = 0; index2 < num2; ++index2)
        intList.Add(r.ReadInt32());
      boughtStoreItems.list.Add(intList);
    }
    return boughtStoreItems;
  }

  public bool IsUnlocked(ArcanistsStore.Which which, int index)
  {
    int index1 = (int) (which - 1);
    int index2 = index / 32;
    return index1 >= 0 && this.list.Count > index1 && this.list[index1].Count > index2 && (uint) (this.list[index1][index2] & 1 << index - index2 * 32) > 0U;
  }

  public void Set(ArcanistsStore.Which which, int index)
  {
    int index1 = (int) (which - 1);
    int index2 = index / 32;
    if (index1 < 0)
      return;
    this.changes = true;
    while (this.list.Count <= index1)
      this.list.Add(new List<int>());
    while (this.list[index1].Count <= index2)
      this.list[index1].Add(0);
    this.list[index1][index2] |= 1 << index - index2 * 32;
  }

  public void Reset(ArcanistsStore.Which which, int index)
  {
    int index1 = (int) (which - 1);
    int index2 = index / 32;
    if (index1 < 0)
      return;
    this.changes = true;
    while (this.list.Count <= index1)
      this.list.Add(new List<int>());
    while (this.list[index1].Count <= index2)
      this.list[index1].Add(0);
    this.list[index1][index2] &= ~(1 << index - index2 * 32);
  }

  public override bool Equals(object obj)
  {
    if (this.changes)
      return false;
    return obj is BoughtStoreItems ? !(obj as BoughtStoreItems).changes : base.Equals(obj);
  }
}
