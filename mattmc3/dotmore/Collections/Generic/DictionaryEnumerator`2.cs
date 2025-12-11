
using System;
using System.Collections;
using System.Collections.Generic;

namespace mattmc3.dotmore.Collections.Generic
{
  public class DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator, IDisposable
  {
    private readonly IEnumerator<KeyValuePair<TKey, TValue>> _impl;

    public void Dispose()
    {
      this._impl.Dispose();
    }

    public DictionaryEnumerator(IDictionary<TKey, TValue> value)
    {
      this._impl = value.GetEnumerator();
    }

    public void Reset()
    {
      this._impl.Reset();
    }

    public bool MoveNext()
    {
      return this._impl.MoveNext();
    }

    public DictionaryEntry Entry
    {
      get
      {
        KeyValuePair<TKey, TValue> current = this._impl.Current;
        return new DictionaryEntry((object) current.Key, (object) current.Value);
      }
    }

    public object Key
    {
      get
      {
        return (object) this._impl.Current.Key;
      }
    }

    public object Value
    {
      get
      {
        return (object) this._impl.Current.Value;
      }
    }

    public object Current
    {
      get
      {
        return (object) this.Entry;
      }
    }
  }
}
