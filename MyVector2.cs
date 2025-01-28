
using Newtonsoft.Json;
using UnityEngine;

public struct MyVector2
{
  public float x;
  public float y;

  public MyVector2(float x, float y)
  {
    this.x = x;
    this.y = y;
  }

  public MyVector2(Vector2 b)
  {
    this.x = b.x;
    this.y = b.y;
  }

  [JsonIgnore]
  public static MyVector2 zero
  {
    get
    {
      return new MyVector2(0.0f, 0.0f);
    }
  }

  public static implicit operator Vector2(MyVector2 d)
  {
    return new Vector2(d.x, d.y);
  }

  public static implicit operator MyVector2(Vector2 d)
  {
    return new MyVector2(d.x, d.y);
  }
}
