
using System.Collections.Generic;

#nullable disable
public class SteamStore
{
  public static List<SteamStore.Item> items = new List<SteamStore.Item>()
  {
    new SteamStore.Item()
    {
      which = SteamStore.Which.Crystals,
      amount = 100,
      cost = 99
    },
    new SteamStore.Item()
    {
      which = SteamStore.Which.Crystals,
      amount = 360,
      cost = 299
    },
    new SteamStore.Item()
    {
      which = SteamStore.Which.Crystals,
      amount = 910,
      cost = 699
    },
    new SteamStore.Item()
    {
      which = SteamStore.Which.Crystals,
      amount = 1820,
      cost = 1299
    },
    new SteamStore.Item()
    {
      which = SteamStore.Which.Crystals,
      amount = 3750,
      cost = 2499
    },
    new SteamStore.Item()
    {
      which = SteamStore.Which.Membership,
      amount = 1000,
      cost = 999
    }
  };

  public class Item
  {
    public string name = "";
    public SteamStore.Which which;
    public int amount = 100;
    public int cost = 100;
  }

  public enum Which
  {
    Crystals,
    Membership,
  }
}
