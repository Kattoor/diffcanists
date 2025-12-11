
using UnityEngine;

public class Coords
{
  public int x;
  public int y;
  public ZCreature hit;

  public Coords(int x, int y)
  {
    this.x = x;
    this.y = y;
  }

  public Coords(int x, int y, ZCreature z)
  {
    this.x = x;
    this.y = y;
    this.hit = z;
  }

  public override string ToString()
  {
    return "Coords (" + (object) this.x + ", " + (object) this.y + ")";
  }

  public Vector3 ToVector()
  {
    return new Vector3((float) this.x, (float) this.y);
  }

  public MyLocation ToMyLocation()
  {
    return new MyLocation(this.x, this.y);
  }

  public float distance
  {
    get
    {
      return Mathf.Sqrt((float) (this.x * this.x + this.y * this.y));
    }
  }

  public int Distance(Coords b)
  {
    return Mathf.Abs(b.x - this.x) + Mathf.Abs(b.y - this.y);
  }

  public float DistanceSq(Coords b)
  {
    return Mathf.Sqrt((float) (Mathf.Abs(b.x - this.x) * Mathf.Abs(b.x - this.x) + Mathf.Abs(b.y - this.y) * Mathf.Abs(b.y - this.y)));
  }
}
