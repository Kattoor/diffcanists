
public struct ArmaWarning
{
  public int x;
  public int y;
  public int left;

  public bool Compare(ArmaWarning z)
  {
    return this.x == z.x && this.y == z.y && this.left == z.left;
  }

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.x);
    w.Write(this.y);
    w.Write(this.left);
  }

  public static ArmaWarning Deserialize(myBinaryReader r)
  {
    return new ArmaWarning()
    {
      x = r.ReadInt32(),
      y = r.ReadInt32(),
      left = r.ReadInt32()
    };
  }
}
