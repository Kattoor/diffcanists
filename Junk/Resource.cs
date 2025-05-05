
#nullable disable
namespace Junk
{
  public class Resource
  {
    public BufferedImage image;
    public bool canRotate;
    public bool needLevelGround;
    public bool requireFlatten;
    public int offsetX;
    public int offsetY;
    public int offset;
    public bool isForground;

    public Resource(SerializedResources.Resource m)
    {
      this.image = new BufferedImage(m.texture);
      this.canRotate = m.rotate;
      this.offsetX = m.offX;
      this.offsetY = m.offY;
      this.offset = 0;
      this.needLevelGround = m.level;
      this.requireFlatten = m.flatten;
      this.isForground = m.front;
    }
  }
}
