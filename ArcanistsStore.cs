
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ArcanistsStore
{
  public ArcanistsStore.Which which;
  public List<ArcanistsStore.Item> items;

  public static bool OnlyOneActive(ArcanistsStore.Which w)
  {
    return w == ArcanistsStore.Which.Pet;
  }

  public static bool IsToggleable(ArcanistsStore.Which w)
  {
    switch (w)
    {
      case ArcanistsStore.Which.Pet:
      case ArcanistsStore.Which.SpellSkin:
        return true;
      default:
        return false;
    }
  }

  [Serializable]
  public class Item
  {
    public string name = "";
    public int amount = 100;
    public int cost = 100;
    public SpellEnum spellEnum;
    public Sprite sprite;
    public StoreObject obj;
    public ArcanistsStore.Tag tags;
  }

  [Serializable]
  public enum Which
  {
    Tomato,
    Pet,
    Monster,
    SpellSkin,
    PlayerAnimation,
    Icon,
  }

  [System.Flags]
  [Serializable]
  public enum Tag
  {
    Golden = 1,
    HD = 2,
  }
}
