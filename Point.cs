
using UnityEngine;

public struct Point
{
  public static readonly Point Empty;
  private int _x;
  private int _y;

  public bool IsEmpty
  {
    get
    {
      return this._x == 0 && this._y == 0;
    }
  }

  public int x
  {
    get
    {
      return this._x;
    }
    set
    {
      this._x = value;
    }
  }

  public int y
  {
    get
    {
      return this._y;
    }
    set
    {
      this._y = value;
    }
  }

  public Point(int x, int y)
  {
    this._x = x;
    this._y = y;
  }

  public Point(MyLocation m)
  {
    this._x = (int) m.x;
    this._y = (int) m.y;
  }

  public Point(Size sz)
  {
    this._x = sz.Width;
    this._y = sz.Height;
  }

  public Vector3 ToVector3()
  {
    return new Vector3((float) this.x, (float) this.y);
  }

  public Vector2 ToVector2()
  {
    return new Vector2((float) this.x, (float) this.y);
  }

  public static implicit operator Point(MyLocation v)
  {
    return new Point(v.x.ToInt(), v.y.ToInt());
  }

  public Point(int dw)
  {
    this._x = (int) (short) Point.LOWORD(dw);
    this._y = (int) (short) Point.HIWORD(dw);
  }

  public static explicit operator Size(Point p)
  {
    return new Size(p.x, p.y);
  }

  public static Point operator +(Point pt, Size sz)
  {
    return Point.Add(pt, sz);
  }

  public static Point operator *(Point pt, Point sz)
  {
    return new Point(pt._x * sz._x, pt._y * sz._y);
  }

  public static Point operator -(Point pt, Size sz)
  {
    return Point.Subtract(pt, sz);
  }

  public static bool operator ==(Point left, Point right)
  {
    return left.x == right.x && left.y == right.y;
  }

  public static bool operator !=(Point left, Point right)
  {
    return !(left == right);
  }

  public static Point Add(Point pt, Size sz)
  {
    return new Point(pt.x + sz.Width, pt.y + sz.Height);
  }

  public static Point Subtract(Point pt, Size sz)
  {
    return new Point(pt.x - sz.Width, pt.y - sz.Height);
  }

  public override bool Equals(object obj)
  {
    return obj is Point point && point.x == this.x && point.y == this.y;
  }

  public override int GetHashCode()
  {
    return this._x ^ this._y;
  }

  public void Offset(int dx, int dy)
  {
    this.x += dx;
    this.y += dy;
  }

  public void Offset(Point p)
  {
    this.Offset(p.x, p.y);
  }

  public override string ToString()
  {
    return "{X=" + this.x.ToString() + ",Y=" + this.y.ToString() + "}";
  }

  private static int HIWORD(int n)
  {
    return n >> 16 & (int) ushort.MaxValue;
  }

  private static int LOWORD(int n)
  {
    return n & (int) ushort.MaxValue;
  }

  internal void setLocation(double v1, double v2)
  {
    this._x = (int) v1;
    this._y = (int) v2;
  }
}
