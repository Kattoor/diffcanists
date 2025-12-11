
using System.Collections.Generic;
using System.IO;

public class RatedContainer
{
  public List<RatedFacts> list = new List<RatedFacts>();
  public int diff = 400;
  public const byte Version = 5;

  public void IncreaseDiff()
  {
    if (this.diff >= 600)
      return;
    this.diff += 20;
  }

  public void AddDefault()
  {
    this.list.Add(new RatedFacts());
  }

  public static RatedContainer Deserialize(myBinaryReader r)
  {
    RatedContainer ratedContainer = new RatedContainer();
    byte num1 = r.ReadByte();
    if (num1 == (byte) 1)
    {
      RatedFacts ratedFacts = new RatedFacts();
      ratedFacts._Deserialize(5, r);
      ratedContainer.list.Add(ratedFacts);
      return ratedContainer;
    }
    int num2 = r.ReadInt32();
    if (num2 > 10)
      num2 = 10;
    for (int index = 0; index < num2; ++index)
      ratedContainer.list.Add(RatedFacts.Deserialize((int) num1, r));
    if (num2 == 0)
      ratedContainer.AddDefault();
    return ratedContainer;
  }

  public void Serialize(myBinaryWriter w, bool includeBook = true)
  {
    if (this.list.Count == 0)
      this.AddDefault();
    w.Write((byte) 5);
    w.Write(this.list.Count);
    foreach (RatedFacts ratedFacts in this.list)
      ratedFacts.Serialize(w, includeBook);
  }

  public void SerializeToFile(string s)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
        this.Serialize(w, true);
      File.WriteAllBytes(s, memoryStream.ToArray());
    }
  }

  public static RatedContainer DeserializeFromFile(string s)
  {
    using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(s)))
    {
      using (myBinaryReader r = new myBinaryReader((Stream) memoryStream))
        return RatedContainer.Deserialize(r);
    }
  }

  public void Copy(RatedContainer g)
  {
    this.list.Clear();
    for (int index = 0; index < g.list.Count; ++index)
      this.list.Add(g.list[index].Copy());
    if (this.list.Count != 0)
      return;
    this.AddDefault();
  }
}
