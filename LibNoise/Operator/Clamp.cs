
namespace LibNoise.Operator
{
  public class Clamp : ModuleBase
  {
    private double _min = -1.0;
    private double _max = 1.0;

    public Clamp()
      : base(1)
    {
    }

    public Clamp(ModuleBase input)
      : base(1)
    {
      this.Modules[0] = input;
    }

    public Clamp(double min, double max, ModuleBase input)
      : base(1)
    {
      this.Minimum = min;
      this.Maximum = max;
      this.Modules[0] = input;
    }

    public double Maximum
    {
      get
      {
        return this._max;
      }
      set
      {
        this._max = value;
      }
    }

    public double Minimum
    {
      get
      {
        return this._min;
      }
      set
      {
        this._min = value;
      }
    }

    public void SetBounds(double min, double max)
    {
      this._min = min;
      this._max = max;
    }

    public override double GetValue(double x, double y, double z)
    {
      if (this._min > this._max)
      {
        double min = this._min;
        this._min = this._max;
        this._max = min;
      }
      double num = this.Modules[0].GetValue(x, y, z);
      if (num < this._min)
        return this._min;
      return num > this._max ? this._max : num;
    }
  }
}
