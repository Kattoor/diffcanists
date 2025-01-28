
using System;

[Serializable]
public class EditorFixedInt
{
  public long x;

  public override bool Equals(object obj)
  {
    return this.x.Equals(obj);
  }

  public override int GetHashCode()
  {
    return this.x.GetHashCode();
  }

  public static bool operator ==(EditorFixedInt v, EditorFixedInt x)
  {
    return x.x == v.x;
  }

  public static bool operator !=(EditorFixedInt v, EditorFixedInt x)
  {
    return x.x != v.x;
  }

  public static bool operator ==(EditorFixedInt v, int x)
  {
    return (long) x == v.x >> 20;
  }

  public static bool operator !=(EditorFixedInt v, int x)
  {
    return (long) x != v.x >> 20;
  }

  public static implicit operator FixedInt(EditorFixedInt v)
  {
    return FixedInt.Create(v.x);
  }

  public static implicit operator EditorFixedInt(int v)
  {
    return new EditorFixedInt() { x = (long) (v << 20) };
  }

  public static implicit operator EditorFixedInt(long v)
  {
    return new EditorFixedInt() { x = v };
  }

  public static implicit operator EditorFixedInt(FixedInt v)
  {
    return new EditorFixedInt() { x = v.RawValue };
  }

  public static implicit operator EditorFixedInt(float v)
  {
    return new EditorFixedInt()
    {
      x = (long) ((Decimal) v * new Decimal(1048576))
    };
  }

  public static explicit operator int(EditorFixedInt v)
  {
    return (int) (v.x >> 20);
  }

  public static bool operator >(EditorFixedInt v, int x)
  {
    return (int) (v.x >> 20) > x;
  }

  public static bool operator <(EditorFixedInt v, int x)
  {
    return (int) (v.x >> 20) < x;
  }

  public static bool operator >(EditorFixedInt v, EditorFixedInt x)
  {
    return v.x > x.x;
  }

  public static bool operator <(EditorFixedInt v, EditorFixedInt x)
  {
    return v.x < x.x;
  }
}
