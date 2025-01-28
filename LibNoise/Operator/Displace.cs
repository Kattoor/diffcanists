
namespace LibNoise.Operator
{
  public class Displace : ModuleBase
  {
    public Displace()
      : base(4)
    {
    }

    public Displace(ModuleBase input, ModuleBase x, ModuleBase y, ModuleBase z)
      : base(4)
    {
      this.Modules[0] = input;
      this.Modules[1] = x;
      this.Modules[2] = y;
      this.Modules[3] = z;
    }

    public ModuleBase X
    {
      get
      {
        return this.Modules[1];
      }
      set
      {
        this.Modules[1] = value;
      }
    }

    public ModuleBase Y
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

    public ModuleBase Z
    {
      get
      {
        return this.Modules[3];
      }
      set
      {
        this.Modules[3] = value;
      }
    }

    public override double GetValue(double x, double y, double z)
    {
      return this.Modules[0].GetValue(x + this.Modules[1].GetValue(x, y, z), y + this.Modules[2].GetValue(x, y, z), z + this.Modules[3].GetValue(x, y, z));
    }
  }
}
