
using System.Collections;
using System.Collections.Generic;

namespace mattmc3.dotmore.Collections.Generic
{
  public class OrderedSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
  {
    private readonly IDictionary<T, LinkedListNode<T>> m_Dictionary;
    private readonly LinkedList<T> m_LinkedList;

    public OrderedSet()
      : this((IEqualityComparer<T>) EqualityComparer<T>.Default)
    {
    }

    public OrderedSet(IEqualityComparer<T> comparer)
    {
      this.m_Dictionary = (IDictionary<T, LinkedListNode<T>>) new Dictionary<T, LinkedListNode<T>>(comparer);
      this.m_LinkedList = new LinkedList<T>();
    }

    public int Count
    {
      get
      {
        return this.m_Dictionary.Count;
      }
    }

    public virtual bool IsReadOnly
    {
      get
      {
        return this.m_Dictionary.IsReadOnly;
      }
    }

    void ICollection<T>.Add(T item)
    {
      this.Add(item);
    }

    public bool Add(T item)
    {
      if (this.m_Dictionary.ContainsKey(item))
        return false;
      LinkedListNode<T> linkedListNode = this.m_LinkedList.AddLast(item);
      this.m_Dictionary.Add(item, linkedListNode);
      return true;
    }

    public void Clear()
    {
      this.m_LinkedList.Clear();
      this.m_Dictionary.Clear();
    }

    public bool Remove(T item)
    {
      LinkedListNode<T> node;
      if ((object) item == null || !this.m_Dictionary.TryGetValue(item, out node))
        return false;
      this.m_Dictionary.Remove(item);
      this.m_LinkedList.Remove(node);
      return true;
    }

    public IEnumerator<T> GetEnumerator()
    {
      return (IEnumerator<T>) this.m_LinkedList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public bool Contains(T item)
    {
      return (object) item != null && this.m_Dictionary.ContainsKey(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
      this.m_LinkedList.CopyTo(array, arrayIndex);
    }
  }
}
