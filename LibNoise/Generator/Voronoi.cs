
using System;

namespace LibNoise.Generator
{
  public class Voronoi : ModuleBase
  {
    private double _displacement = 1.0;
    private double _frequency = 1.0;
    private int _seed;
    private bool _distance;

    public Voronoi()
      : base(0)
    {
    }

    public Voronoi(double frequency, double displacement, int seed, bool distance)
      : base(0)
    {
      this.Frequency = frequency;
      this.Displacement = displacement;
      this.Seed = seed;
      this.UseDistance = distance;
    }

    public double Displacement
    {
      get
      {
        return this._displacement;
      }
      set
      {
        this._displacement = value;
      }
    }

    public double Frequency
    {
      get
      {
        return this._frequency;
      }
      set
      {
        this._frequency = value;
      }
    }

    public int Seed
    {
      get
      {
        return this._seed;
      }
      set
      {
        this._seed = value;
      }
    }

    public bool UseDistance
    {
      get
      {
        return this._distance;
      }
      set
      {
        this._distance = value;
      }
    }

    public override double GetValue(double x, double y, double z)
    {
      x *= this._frequency;
      y *= this._frequency;
      z *= this._frequency;
      int num1 = x > 0.0 ? (int) x : (int) x - 1;
      int num2 = y > 0.0 ? (int) y : (int) y - 1;
      int num3 = z > 0.0 ? (int) z : (int) z - 1;
      double num4 = (double) int.MaxValue;
      double d1 = 0.0;
      double d2 = 0.0;
      double d3 = 0.0;
      for (int z1 = num3 - 2; z1 <= num3 + 2; ++z1)
      {
        for (int y1 = num2 - 2; y1 <= num2 + 2; ++y1)
        {
          for (int x1 = num1 - 2; x1 <= num1 + 2; ++x1)
          {
            double num5 = (double) x1 + Utils.ValueNoise3D(x1, y1, z1, this._seed);
            double num6 = (double) y1 + Utils.ValueNoise3D(x1, y1, z1, this._seed + 1);
            double num7 = (double) z1 + Utils.ValueNoise3D(x1, y1, z1, this._seed + 2);
            double num8 = num5 - x;
            double num9 = num6 - y;
            double num10 = num7 - z;
            double num11 = num8 * num8 + num9 * num9 + num10 * num10;
            if (num11 < num4)
            {
              num4 = num11;
              d1 = num5;
              d2 = num6;
              d3 = num7;
            }
          }
        }
      }
      double num12;
      if (this._distance)
      {
        double num5 = d1 - x;
        double num6 = d2 - y;
        double num7 = d3 - z;
        num12 = Math.Sqrt(num5 * num5 + num6 * num6 + num7 * num7) * 1.73205080756888 - 1.0;
      }
      else
        num12 = 0.0;
      return num12 + this._displacement * Utils.ValueNoise3D((int) Math.Floor(d1), (int) Math.Floor(d2), (int) Math.Floor(d3), 0);
    }
  }
}
