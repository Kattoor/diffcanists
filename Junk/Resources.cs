
using UnityEngine;

#nullable disable
namespace Junk
{
  public class Resources
  {
    private BufferedImage ground;
    private BufferedImage grass;
    private BufferedImage underBelly;
    private Resource[] objects;
    private static BufferedImage bridge;
    private static BufferedImage developer;
    private static BufferedImage developer2;

    public static void SetResource(Resources r)
    {
    }

    internal static Resources getInstance(MapEnum mapEnum) => (Resources) null;

    public Resources(SerializedResources.MapGroup p)
    {
      this.ground = new BufferedImage(p.bgTexture);
      this.grass = new BufferedImage(p.grass);
      this.underBelly = new BufferedImage(p.underbelly);
      this.objects = new Resource[p.resources.Count];
      for (int index = 0; index < p.resources.Count; ++index)
        this.objects[index] = new Resource(p.resources[index]);
    }

    public BufferedImage getGround() => this.ground;

    internal int getLength() => this.objects.Length;

    internal Rectangle getBounds(int decoIdx)
    {
      Resource resource = this.objects[decoIdx];
      return new Rectangle(resource.offsetX, resource.offsetY, resource.image.getWidth(), resource.image.getHeight());
    }

    internal bool getCanRotate(int decoIdx) => this.objects[decoIdx].canRotate;

    internal bool getNeedLevelGround(int decoIdx) => this.objects[decoIdx].needLevelGround;

    internal bool getRequireFlatten(int decoIdx) => this.objects[decoIdx].requireFlatten;

    internal int getOffset(int decoIdx) => this.objects[decoIdx].offset;

    internal int getOffsetX(int decoIdx) => this.objects[decoIdx].offsetX;

    internal int getOffsetY(int decoIdx) => this.objects[decoIdx].offsetY;

    internal bool getIsForeground(int decoIdx) => this.objects[decoIdx].isForground;

    internal BufferedImage getDecoration(int decoIdx) => this.objects[decoIdx].image;

    internal BufferedImage getGrass() => this.grass;

    internal BufferedImage getUnerbelly() => this.underBelly;

    internal static BufferedImage getHarmlessBridge() => Resources.bridge;

    internal static BufferedImage getDeveloper() => Resources.developer;

    internal static BufferedImage getDeveloper2() => Resources.developer2;

    public static void SetBridge(Texture2D t)
    {
      if ((Object) t == (Object) null)
        Resources.bridge = (BufferedImage) null;
      else
        Resources.bridge = new BufferedImage(t);
    }

    public static void SetDeveloper(Texture2D t)
    {
      if ((Object) t == (Object) null)
        Resources.developer = (BufferedImage) null;
      else
        Resources.developer = new BufferedImage(t);
    }

    public static void SetDeveloper2(Texture2D t)
    {
      if ((Object) t == (Object) null)
        Resources.developer2 = (BufferedImage) null;
      else
        Resources.developer2 = new BufferedImage(t);
    }
  }
}
