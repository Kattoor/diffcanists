
using UnityEngine;

public interface IRecycledScrollViewGenericItem
{
  void Init(object obj, int index);

  GameObject gameObject { get; }
}
