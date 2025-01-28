
using UnityEngine;

public class Surface
{
  public Color32[] pixels;
  public int width;
  public int height;
  private Texture2D tex;

  ~Surface()
  {
    this.tex = (Texture2D) null;
    this.pixels = (Color32[]) null;
  }

  public void set_Item(int x, int y, Color32 c)
  {
    if (y >= this.height || y < 0 || (x >= this.width || x < 0) || c.a == (byte) 0)
      return;
    this.pixels[x + y * this.width] = c;
  }

  public Color32 get_Item(int x, int y)
  {
    return y >= this.height || y < 0 || (x >= this.width || x < 0) ? (Color32) Color.clear : this.pixels[x + y * this.width];
  }

  public Surface(Texture2D tex)
  {
    this.tex = tex;
    this.pixels = tex.GetPixels32();
    this.width = tex.width;
    this.height = tex.height;
  }

  public Surface(Texture2D tex, Color32[] c)
  {
    this.tex = tex;
    this.pixels = c;
    this.width = tex.width;
    this.height = tex.height;
  }

  public Surface(Color32[] c, int w, int h)
  {
    this.pixels = c;
    this.width = w;
    this.height = h;
  }

  public void Apply()
  {
    if (!((Object) this.tex != (Object) null))
      return;
    this.tex.SetPixels32(this.pixels);
    this.tex.Apply();
  }
}
