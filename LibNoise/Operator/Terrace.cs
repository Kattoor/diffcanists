
using System;
using System.Collections.Generic;
using UnityEngine;

namespace LibNoise.Operator
{
  public class Terrace : ModuleBase
  {
    private readonly List<double> _data = new List<double>();
    private bool _inverted;

    public Terrace()
      : base(1)
    {
    }

    public Terrace(ModuleBase input)
      : base(1)
    {
      this.Modules[0] = input;
    }

    public Terrace(bool inverted, ModuleBase input)
      : base(1)
    {
      this.Modules[0] = input;
      this.IsInverted = inverted;
    }

    public int ControlPointCount
    {
      get
      {
        return this._data.Count;
      }
    }

    public List<double> ControlPoints
    {
      get
      {
        return this._data;
      }
    }

    public bool IsInverted
    {
      get
      {
        return this._inverted;
      }
      set
      {
        this._inverted = value;
      }
    }

    public void Add(double input)
    {
      if (!this._data.Contains(input))
        this._data.Add(input);
      this._data.Sort((Comparison<double>) ((lhs, rhs) => lhs.CompareTo(rhs)));
    }

    public void Clear()
    {
      this._data.Clear();
    }

    public void Generate(int steps)
    {
      if (steps < 2)
        throw new ArgumentException("Need at least two steps");
      this.Clear();
      double num = 2.0 / ((double) steps - 1.0);
      double input = -1.0;
      for (int index = 0; index < steps; ++index)
      {
        this.Add(input);
        input += num;
      }
    }

    public override double GetValue(double x, double y, double z)
    {
      double num1 = this.Modules[0].GetValue(x, y, z);
      int index1 = 0;
      while (index1 < this._data.Count && num1 >= this._data[index1])
        ++index1;
      int index2 = Mathf.Clamp(index1 - 1, 0, this._data.Count - 1);
      int index3 = Mathf.Clamp(index1, 0, this._data.Count - 1);
      if (index2 == index3)
        return this._data[index3];
      double a = this._data[index2];
      double b = this._data[index3];
      double num2 = (num1 - a) / (b - a);
      if (this._inverted)
      {
        num2 = 1.0 - num2;
        double num3 = a;
        a = b;
        b = num3;
      }
      double position = num2 * num2;
      return Utils.InterpolateLinear(a, b, position);
    }
  }
}
