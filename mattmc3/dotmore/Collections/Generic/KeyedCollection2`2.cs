
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace mattmc3.dotmore.Collections.Generic
{
  public class KeyedCollection2<TKey, TItem> : KeyedCollection<TKey, TItem>
  {
    private const string DelegateNullExceptionMessage = "Delegate passed cannot be null";
    private Func<TItem, TKey> _getKeyForItemFunction;

    public KeyedCollection2(Func<TItem, TKey> getKeyForItemFunction)
    {
      if (getKeyForItemFunction == null)
        throw new ArgumentNullException("Delegate passed cannot be null");
      this._getKeyForItemFunction = getKeyForItemFunction;
    }

    public KeyedCollection2(
      Func<TItem, TKey> getKeyForItemDelegate,
      IEqualityComparer<TKey> comparer)
      : base(comparer)
    {
      if (getKeyForItemDelegate == null)
        throw new ArgumentNullException("Delegate passed cannot be null");
      this._getKeyForItemFunction = getKeyForItemDelegate;
    }

    protected override TKey GetKeyForItem(TItem item)
    {
      return this._getKeyForItemFunction(item);
    }

    public void SortByKeys()
    {
      this.SortByKeys((IComparer<TKey>) Comparer<TKey>.Default);
    }

    public void SortByKeys(IComparer<TKey> keyComparer)
    {
      this.Sort((IComparer<TItem>) new Comparer2<TItem>((Comparison<TItem>) ((x, y) => keyComparer.Compare(this.GetKeyForItem(x), this.GetKeyForItem(y)))));
    }

    public void SortByKeys(Comparison<TKey> keyComparison)
    {
      this.Sort((IComparer<TItem>) new Comparer2<TItem>((Comparison<TItem>) ((x, y) => keyComparison(this.GetKeyForItem(x), this.GetKeyForItem(y)))));
    }

    public void Sort()
    {
      this.Sort((IComparer<TItem>) Comparer<TItem>.Default);
    }

    public void Sort(Comparison<TItem> comparison)
    {
      this.Sort((IComparer<TItem>) new Comparer2<TItem>((Comparison<TItem>) ((x, y) => comparison(x, y))));
    }

    public void Sort(IComparer<TItem> comparer)
    {
      if (!(this.Items is List<TItem> items))
        return;
      items.Sort(comparer);
    }
  }
}
