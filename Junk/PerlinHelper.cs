
using System.Diagnostics;
using System.IO;
using UnityEngine;

namespace Junk
{
  public class PerlinHelper
  {
    public int sizeX = 1024;
    public int sizeY = 512;
    public int _octaveCount = 1;
    public float _frecuency = 1f;
    public float _persistence = 0.5f;
    public float threshold = 0.04f;
    public string name;
    public int count;
    public Resources resources;

    public void ExportImg(Texture2D t)
    {
      File.WriteAllBytes("SavedPerlinImg.png", t.EncodeToPNG());
    }

    public Sprite CreateRawImage(Color32[] pixels)
    {
      return this.CreateRawImage(pixels, this.sizeX, this.sizeY);
    }

    public Sprite CreateRawImage(Color32[] pixels, int w, int h)
    {
      Texture2D texture = new Texture2D(w, h);
      texture.wrapMode = TextureWrapMode.Clamp;
      texture.filterMode = FilterMode.Point;
      texture.SetPixels32(pixels);
      texture.Apply();
      return Sprite.Create(texture, new Rect(0.0f, 0.0f, (float) w, (float) h), Vector2.zero);
    }

    public class SW
    {
      private Stopwatch stopwatch;

      public void Start()
      {
        this.stopwatch = Stopwatch.StartNew();
      }

      public void Clock(string s = "")
      {
        UnityEngine.Debug.Log((object) (s + " " + (object) this.stopwatch.ElapsedMilliseconds + "ms"));
        this.stopwatch = Stopwatch.StartNew();
      }

      ~SW()
      {
        if (this.stopwatch == null)
          return;
        this.stopwatch.Stop();
      }
    }
  }
}
