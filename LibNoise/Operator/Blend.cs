
namespace LibNoise.Operator
{
  public class Blend : ModuleBase
  {
    public Blend()
      : base(3)
    {
    }

    public Blend(ModuleBase lhs, ModuleBase rhs, ModuleBase controller)
      : base(3)
    {
      this.Modules[0] = lhs;
      this.Modules[1] = rhs;
      this.Modules[2] = controller;
    }

    public ModuleBase Controller
    {
      get
      {
        return this.Modules[2];
      }
      set
      {
        this.Modules[2] = value;
      }
    }

    public override double GetValue(double x, double y, double z)
    {
      double a = this.Modules[0].GetValue(x, y, z);
      double num1 = this.Modules[1].GetValue(x, y, z);
      double num2 = (this.Modules[2].GetValue(x, y, z) + 1.0) / 2.0;
      double b = num1;
      double position = num2;
      return Utils.InterpolateLinear(a, b, position);
    }
  }
}
