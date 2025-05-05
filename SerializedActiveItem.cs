
using System;
using System.Collections.Generic;

#nullable disable
public class SerializedActiveItem : MySerializeable
{
  public List<ActiveItem> items = new List<ActiveItem>();
  public byte Version = 1;

  public ActiveItem Find(Predicate<ActiveItem> a) => this.items.Find(a);

  public int FindIndex(Predicate<ActiveItem> a) => this.items.FindIndex(a);

  public void Add(ActiveItem x) => this.items.Add(x);

  public void RemoveAt(int i) => this.items.RemoveAt(i);

  public int Count => this.items.Count;

  public ActiveItem this[int x] => this.items[x];

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.Version);
    w.Write(this.items.Count);
    foreach (ActiveItem activeItem in this.items)
    {
      w.Write((int) activeItem.which);
      w.Write(activeItem.index);
    }
  }

  public void Deserialize(myBinaryReader r)
  {
    int num1 = (int) r.ReadByte();
    int num2 = r.ReadInt32();
    for (int index = 0; index < num2; ++index)
      this.items.Add(new ActiveItem()
      {
        which = (ArcanistsStore.Which) r.ReadInt32(),
        index = r.ReadInt32()
      });
  }
}
