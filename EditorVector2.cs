
using System;
using UnityEngine;

[Serializable]
public class EditorVector2
{
  public long x;
  public long y;

  public static implicit operator EditorVector2(Vector2 v)
  {
    return new EditorVector2()
    {
      x = (long) ((Decimal) v.x * new Decimal(1048576)),
      y = (long) ((Decimal) v.y * new Decimal(1048576))
    };
  }

  public MyLocation To()
  {
    return new MyLocation((FixedInt) this.x, (FixedInt) this.y);
  }
}
