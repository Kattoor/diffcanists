
using Hazel;
using System;
using UnityEngine;

[Serializable]
public class OutfitData
{
  public bool isLocked = true;
  public bool hasMouth = true;
  public Achievement achievement = Achievement.None;
  [NonSerialized]
  public int index;
  [NonSerialized]
  public Outfit outfit;
  public Sprite sprite;
  public GameObject archObject;
  public int order;
  public int tournament;
  public int experience;
  public int prestige;
  public string reason;
  public AccountType accountType;
  public Server.ServerSettings.Season season;

  public Achievement _achievement
  {
    set
    {
      this.achievement = value;
      this.isLocked = true;
    }
  }

  public static implicit operator Sprite(OutfitData outfitData)
  {
    return outfitData.sprite;
  }

  public string name
  {
    get
    {
      return this.sprite?.name;
    }
  }

  public bool IsUnlocked(Account a)
  {
    return !this.isLocked || a.cosmetics.array[(int) this.outfit][this.index] || a.accountType.has(AccountType.Owner | AccountType.Press_Account) || !this.isLocked && (this.achievement == Achievement.None || a.cosmetics.achievements[(int) this.achievement] || this.prestige > 0 && (int) a.prestige >= this.prestige || (this.accountType != AccountType.None && (this.accountType & a.accountType) != AccountType.None || this.experience > 0 && (int) a.experience >= this.experience));
  }
}
