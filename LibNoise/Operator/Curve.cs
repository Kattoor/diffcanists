
using System;
using System.Collections.Generic;
using UnityEngine;

namespace LibNoise.Operator
{
  public class Curve : ModuleBase
  {
    private readonly List<KeyValuePair<double, double>> _data = new List<KeyValuePair<double, double>>();

    public Curve()
      : base(1)
    {
    }

    public Curve(ModuleBase input)
      : base(1)
    {
      this.Modules[0] = input;
    }

    public int ControlPointCount
    {
      get
      {
        return this._data.Count;
      }
    }

    public List<KeyValuePair<double, double>> ControlPoints
    {
      get
      {
        return this._data;
      }
    }

    public void Add(double input, double output)
    {
      KeyValuePair<double, double> keyValuePair = new KeyValuePair<double, double>(input, output);
      if (!this._data.Contains(keyValuePair))
        this._data.Add(keyValuePair);
      this._data.Sort((Comparison<KeyValuePair<double, double>>) ((lhs, rhs) => lhs.Key.CompareTo(rhs.Key)));
    }

    public void Clear()
    {
      this._data.Clear();
    }

    public override double GetValue(double x, double y, double z)
    {
      double num1 = this.Modules[0].GetValue(x, y, z);
      int index1 = 0;
      while (index1 < this._data.Count && num1 >= this._data[index1].Key)
        ++index1;
      int index2 = Mathf.Clamp(index1 - 2, 0, this._data.Count - 1);
      int index3 = Mathf.Clamp(index1 - 1, 0, this._data.Count - 1);
      int index4 = Mathf.Clamp(index1, 0, this._data.Count - 1);
      int index5 = Mathf.Clamp(index1 + 1, 0, this._data.Count - 1);
      if (index3 == index4)
        return this._data[index3].Value;
      double key1 = this._data[index3].Key;
      double key2 = this._data[index4].Key;
      double num2 = (num1 - key1) / (key2 - key1);
      KeyValuePair<double, double> keyValuePair = this._data[index2];
      double a = keyValuePair.Value;
      keyValuePair = this._data[index3];
      double b = keyValuePair.Value;
      keyValuePair = this._data[index4];
      double c = keyValuePair.Value;
      keyValuePair = this._data[index5];
      double d = keyValuePair.Value;
      double position = num2;
      return Utils.InterpolateCubic(a, b, c, d, position);
    }
  }
}
