
using System;
using System.Collections.Generic;

namespace mattmc3.dotmore.Collections.Generic
{
  public class Comparer2<T> : Comparer<T>
  {
    private readonly Comparison<T> _compareFunction;

    public Comparer2(Comparison<T> comparison)
    {
      if (comparison == null)
        throw new ArgumentNullException(nameof (comparison));
      this._compareFunction = comparison;
    }

    public override int Compare(T arg1, T arg2)
    {
      return this._compareFunction(arg1, arg2);
    }
  }
}
