
public struct Size
{
  public static readonly Size Empty;
  private int width;
  private int height;

  public bool IsEmpty
  {
    get
    {
      return this.width == 0 && this.height == 0;
    }
  }

  public int Width
  {
    get
    {
      return this.width;
    }
    set
    {
      this.width = value;
    }
  }

  public int Height
  {
    get
    {
      return this.height;
    }
    set
    {
      this.height = value;
    }
  }

  public Size(Point pt)
  {
    this.width = pt.x;
    this.height = pt.y;
  }

  public Size(int width, int height)
  {
    this.width = width;
    this.height = height;
  }

  public static explicit operator Point(Size size)
  {
    return new Point(size.Width, size.Height);
  }

  public static Size operator +(Size sz1, Size sz2)
  {
    return Size.Add(sz1, sz2);
  }

  public static Size operator -(Size sz1, Size sz2)
  {
    return Size.Subtract(sz1, sz2);
  }

  public static bool operator ==(Size sz1, Size sz2)
  {
    return sz1.Width == sz2.Width && sz1.Height == sz2.Height;
  }

  public static bool operator !=(Size sz1, Size sz2)
  {
    return !(sz1 == sz2);
  }

  public static Size Add(Size sz1, Size sz2)
  {
    return new Size(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
  }

  public static Size Subtract(Size sz1, Size sz2)
  {
    return new Size(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
  }

  public override bool Equals(object obj)
  {
    return obj is Size size && size.width == this.width && size.height == this.height;
  }

  public override int GetHashCode()
  {
    return this.width ^ this.height;
  }

  public override string ToString()
  {
    return "{Width=" + this.width.ToString() + ", Height=" + this.height.ToString() + "}";
  }
}
