
using System;

namespace LibNoise.Generator
{
  public class Spheres : ModuleBase
  {
    private double _frequency = 1.0;

    public Spheres()
      : base(0)
    {
    }

    public Spheres(double frequency)
      : base(0)
    {
      this.Frequency = frequency;
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

    public override double GetValue(double x, double y, double z)
    {
      x *= this._frequency;
      y *= this._frequency;
      z *= this._frequency;
      double d = Math.Sqrt(x * x + y * y + z * z);
      double val1 = d - Math.Floor(d);
      double val2 = 1.0 - val1;
      return 1.0 - Math.Min(val1, val2) * 4.0;
    }
  }
}
