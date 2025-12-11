
using UnityEngine;

public class SpellSand : Spell
{
  internal static Color32 color1 = new Color32((byte) 187, (byte) 175, (byte) 124, (byte) 254);
  internal static Color32 color2 = new Color32((byte) 247, (byte) 230, (byte) 187, (byte) 254);
  public Color32 color = (Color32) new Color(0.7372549f, 0.6745098f, 0.4862745f);
  public SpriteRenderer spriteRenderer;

  internal static bool IsSand(Color32 c)
  {
    return c.a == (byte) 254;
  }
}
