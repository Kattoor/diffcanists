
using LibNoise.Generator;

namespace LibNoise.Operator
{
  public class Turbulence : ModuleBase
  {
    private double _power = 1.0;
    private const double X0 = 0.189422607421875;
    private const double Y0 = 0.99371337890625;
    private const double Z0 = 0.478164672851563;
    private const double X1 = 0.404647827148438;
    private const double Y1 = 0.276611328125;
    private const double Z1 = 0.923049926757813;
    private const double X2 = 0.82122802734375;
    private const double Y2 = 0.171096801757813;
    private const double Z2 = 0.684280395507813;
    private readonly Perlin _xDistort;
    private readonly Perlin _yDistort;
    private readonly Perlin _zDistort;

    public Turbulence()
      : base(1)
    {
      this._xDistort = new Perlin();
      this._yDistort = new Perlin();
      this._zDistort = new Perlin();
    }

    public Turbulence(ModuleBase input)
      : base(1)
    {
      this._xDistort = new Perlin();
      this._yDistort = new Perlin();
      this._zDistort = new Perlin();
      this.Modules[0] = input;
    }

    public Turbulence(double power, ModuleBase input)
      : this(new Perlin(), new Perlin(), new Perlin(), power, input)
    {
    }

    public Turbulence(Perlin x, Perlin y, Perlin z, double power, ModuleBase input)
      : base(1)
    {
      this._xDistort = x;
      this._yDistort = y;
      this._zDistort = z;
      this.Modules[0] = input;
      this.Power = power;
    }

    public double Frequency
    {
      get
      {
        return this._xDistort.Frequency;
      }
      set
      {
        this._xDistort.Frequency = value;
        this._yDistort.Frequency = value;
        this._zDistort.Frequency = value;
      }
    }

    public double Power
    {
      get
      {
        return this._power;
      }
      set
      {
        this._power = value;
      }
    }

    public int Roughness
    {
      get
      {
        return this._xDistort.OctaveCount;
      }
      set
      {
        this._xDistort.OctaveCount = value;
        this._yDistort.OctaveCount = value;
        this._zDistort.OctaveCount = value;
      }
    }

    public int Seed
    {
      get
      {
        return this._xDistort.Seed;
      }
      set
      {
        this._xDistort.Seed = value;
        this._yDistort.Seed = value + 1;
        this._zDistort.Seed = value + 2;
      }
    }

    public override double GetValue(double x, double y, double z)
    {
      return this.Modules[0].GetValue(x + this._xDistort.GetValue(x + 0.189422607421875, y + 0.99371337890625, z + 0.478164672851563) * this._power, y + this._yDistort.GetValue(x + 0.404647827148438, y + 0.276611328125, z + 0.923049926757813) * this._power, z + this._zDistort.GetValue(x + 0.82122802734375, y + 0.171096801757813, z + 0.684280395507813) * this._power);
    }
  }
}
