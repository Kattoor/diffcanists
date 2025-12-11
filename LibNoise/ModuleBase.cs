
using System;
using System.Xml.Serialization;
using UnityEngine;

namespace LibNoise
{
  public abstract class ModuleBase : IDisposable
  {
    private ModuleBase[] _modules;
    [XmlIgnore]
    [NonSerialized]
    private bool _disposed;

    protected ModuleBase(int count)
    {
      if (count <= 0)
        return;
      this._modules = new ModuleBase[count];
    }

    public virtual ModuleBase this[int index]
    {
      get
      {
        if (index < 0 || index >= this._modules.Length)
          throw new ArgumentOutOfRangeException("Index out of valid module range");
        if (this._modules[index] == null)
          throw new ArgumentNullException("Desired element is null");
        return this._modules[index];
      }
      set
      {
        if (index < 0 || index >= this._modules.Length)
          throw new ArgumentOutOfRangeException("Index out of valid module range");
        if (value == null)
          throw new ArgumentNullException("Value should not be null");
        this._modules[index] = value;
      }
    }

    protected ModuleBase[] Modules
    {
      get
      {
        return this._modules;
      }
    }

    public int SourceModuleCount
    {
      get
      {
        return this._modules != null ? this._modules.Length : 0;
      }
    }

    public abstract double GetValue(double x, double y, double z);

    public double GetValue(Vector3 coordinate)
    {
      return this.GetValue((double) coordinate.x, (double) coordinate.y, (double) coordinate.z);
    }

    public double GetValue(ref Vector3 coordinate)
    {
      return this.GetValue((double) coordinate.x, (double) coordinate.y, (double) coordinate.z);
    }

    public bool IsDisposed
    {
      get
      {
        return this._disposed;
      }
    }

    public void Dispose()
    {
      if (!this._disposed)
        this._disposed = this.Disposing();
      GC.SuppressFinalize((object) this);
    }

    protected virtual bool Disposing()
    {
      if (this._modules != null)
      {
        for (int index = 0; index < this._modules.Length; ++index)
        {
          this._modules[index].Dispose();
          this._modules[index] = (ModuleBase) null;
        }
        this._modules = (ModuleBase[]) null;
      }
      return true;
    }
  }
}
