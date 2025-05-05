
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Serializable]
public class ArcanistsStore
{
  public ArcanistsStore.Which which;
  public List<ArcanistsStore.Item> items;

  public static bool OnlyOneActive(ArcanistsStore.Which w) => w == ArcanistsStore.Which.Pet;

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

  [Flags]
  [Serializable]
  public enum Tag
  {
    Golden = 1,
    HD = 2,
  }
}
