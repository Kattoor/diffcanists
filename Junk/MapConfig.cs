
using System;

namespace Junk
{
  public class MapConfig
  {
    public int width;
    public int height;
    public int mapSeed;
    private int borderLeft;
    private int borderRight;
    private int decoGapLeft;
    private int decoGapRight;
    public GameFacts gameFacts;

    public bool altMap
    {
      get
      {
        return this.gameFacts != null && this.gameFacts.settings.altGeneration;
      }
    }

    public MapConfig()
    {
      this.width = 1920;
      this.height = 960;
      this.mapSeed = 45;
      this.borderLeft = 32;
      this.borderRight = 32;
      this.decoGapLeft = 128;
      this.decoGapRight = 128;
    }

    public int getWidth()
    {
      return this.width;
    }

    public int getHeight()
    {
      return this.height;
    }

    public void setWidth(int width)
    {
      this.width = width;
    }

    public void setHeight(int height)
    {
      this.height = height;
    }

    public MapConfig setSize(int width, int height)
    {
      if (width <= 0)
        throw new Exception("invalid width");
      if (height <= 0)
        throw new Exception("invalid height");
      this.width = width;
      this.height = height;
      return this;
    }

    public IsaacCipher getRandom()
    {
      return new IsaacCipher(new int[2]{ this.mapSeed, -1 });
    }

    public int getSeed()
    {
      return this.mapSeed;
    }

    public MapConfig setSeed(int mapSeed)
    {
      this.mapSeed = mapSeed;
      return this;
    }

    public int getMapStart()
    {
      return this.borderLeft;
    }

    public int getMapEnd()
    {
      return this.width - this.borderRight;
    }

    public int getGroundPos(int pos, int len)
    {
      return this.borderLeft + (this.width - this.borderLeft - this.borderRight) * pos / (len - 1);
    }

    public int getCurvePos(int x, int len)
    {
      int num = this.width - this.borderLeft - this.borderRight;
      return (len - 1) * (x - this.borderLeft) / num;
    }

    public MapConfig setBorderLeft(int borderLeft)
    {
      this.borderLeft = borderLeft;
      return this;
    }

    public MapConfig setBorderRight(int borderRight)
    {
      this.borderRight = borderRight;
      return this;
    }

    public int getDecoStart()
    {
      return this.decoGapLeft;
    }

    public int getDecoEnd()
    {
      return this.width - this.decoGapRight;
    }

    public MapConfig setDecoGapLeft(int decoGapLeft)
    {
      this.decoGapLeft = decoGapLeft;
      return this;
    }

    public MapConfig setDecoGapRight(int decoGapRight)
    {
      this.decoGapRight = decoGapRight;
      return this;
    }
  }
}
