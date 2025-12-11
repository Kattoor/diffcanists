
using System;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
  public ArcanistsStore tomatoes = new ArcanistsStore();
  public ArcanistsStore pets = new ArcanistsStore();
  public ArcanistsStore monsters = new ArcanistsStore();
  public ArcanistsStore spellSkins = new ArcanistsStore();
  public ArcanistsStore playerAnimation = new ArcanistsStore();
  public ArcanistsStore icons = new ArcanistsStore();
  public static Store Instance;

  public List<ArcanistsStore.Item> Get(ArcanistsStore.Which which)
  {
    switch (which)
    {
      case ArcanistsStore.Which.Tomato:
        return this.tomatoes.items;
      case ArcanistsStore.Which.Pet:
        return this.pets.items;
      case ArcanistsStore.Which.Monster:
        return this.monsters.items;
      case ArcanistsStore.Which.SpellSkin:
        return this.spellSkins.items;
      case ArcanistsStore.Which.PlayerAnimation:
        return this.playerAnimation.items;
      case ArcanistsStore.Which.Icon:
        return this.icons.items;
      default:
        throw new Exception("Unknown which " + which.ToString());
    }
  }
}
