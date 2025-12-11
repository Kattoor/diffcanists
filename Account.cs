
using Hazel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Account
{
  private static int[] digitsValues = new int[13]
  {
    1,
    4,
    5,
    9,
    10,
    40,
    50,
    90,
    100,
    400,
    500,
    900,
    1000
  };
  private static string[] romanDigits = new string[13]
  {
    "I",
    "IV",
    "V",
    "IX",
    "X",
    "XL",
    "L",
    "XC",
    "C",
    "CD",
    "D",
    "CM",
    "M"
  };
  private static char[] punctuation = new char[1]{ ' ' };
  private static string[] InvalidWord = new string[3]
  {
    "mod",
    "dev",
    "m0d"
  };
  private static string[] fullWords = new string[4]
  {
    "pur3",
    "pure extreme",
    "pur extreme",
    "pure xtreme"
  };
  [JsonIgnore]
  public NewGamesPlayed gameLowTime = new NewGamesPlayed();
  [JsonIgnore]
  public NewGamesPlayed gameHighTime = new NewGamesPlayed();
  [JsonIgnore]
  public NewGamesPlayed gameFun = new NewGamesPlayed();
  [JsonIgnore]
  public NewGamesPlayed _oldGames = new NewGamesPlayed();
  private HashSet<string> _friends = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  private HashSet<string> _ignored = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  [JsonIgnore]
  public string state = "";
  [JsonIgnore]
  public long afkTimer;
  [JsonIgnore]
  public pfabName pfabName;
  public const byte AttributeIgnore = 1;
  [JsonIgnore]
  public int sessionWinningStreak;
  [JsonIgnore]
  public bool fake;
  [JsonIgnore]
  public Connection activeConnection;
  [JsonIgnore]
  public int server;
  [JsonProperty("at")]
  public int tomatoes;
  [JsonIgnore]
  public bool activeItemsChanged;
  [JsonIgnore]
  public bool steamVerified;
  [JsonIgnore]
  internal bool saveCosmetics;
  public const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
  public const string charsExpanded = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-<>,./?;:[{]}|";

  [JsonIgnore]
  public short HighestRating
  {
    get
    {
      return Math.Max(Math.Max(this.gameLowTime.rating, this.gameHighTime.rating), this.gameFun.rating);
    }
  }

  [JsonIgnore]
  public short similarRating
  {
    get
    {
      return Math.Max((short) 1000, this.HighestRating);
    }
  }

  [JsonIgnore]
  public string ratingString
  {
    get
    {
      return this[(int) Client.gameType].rating != (short) -1 ? this[(int) Client.gameType].rating.ToString() : "-";
    }
  }

  public async void ToFile()
  {
  }

  public async void ToFileUnimportant()
  {
  }

  public void OnActivity()
  {
    this.afkTimer = DateTime.UtcNow.ToBinary();
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 112);
        myBinaryWriter.Write(this.name);
        myBinaryWriter.Write(this.afkTimer);
      }
      Server.SendLobbyUnrated(memoryStream.ToArray());
    }
  }

  public bool IsInactive()
  {
    return this.afkTimer != 0L && (DateTime.UtcNow - DateTime.FromBinary(this.afkTimer)).TotalMinutes > 10.0;
  }

  public static async Task<Account> FromFile(string n, bool all = true)
  {
    return new Account();
  }

  public string key
  {
    get
    {
      return this.name.ToLower();
    }
    set
    {
    }
  }

  [JsonProperty("name")]
  public string name { get; set; } = "";

  [JsonProperty("date")]
  public string dateCreated { get; set; } = "";

  [JsonProperty("a")]
  [Indexed(null)]
  public string email { get; set; } = "";

  [JsonProperty("b")]
  public bool permBanned { get; set; }

  [JsonProperty("c")]
  public byte[] hash { get; set; }

  [JsonProperty("d")]
  public byte[] salt { get; set; }

  [JsonIgnore]
  public ushort iterations { get; set; } = 10000;

  [JsonProperty("e")]
  public string ispLock { get; set; } = "";

  [JsonProperty("f")]
  public string extraInfo { get; set; } = "";

  [JsonProperty("g")]
  [Indexed(null)]
  public string steamKey { get; set; } = "";

  [JsonProperty("h")]
  public int tournamentCoins { get; set; }

  [JsonIgnore]
  public int totalRatedGames
  {
    get
    {
      return this.TotalRatedGames + this.TotalRatedGames1 + this.TotalRatedGames2 + (this._oldGames != null ? this._oldGames.totalRatedGames : 0);
    }
  }

  [JsonIgnore]
  public int totalRatedGamesWon
  {
    get
    {
      return this.RatedGamesWon + this.RatedGamesWon1 + this.RatedGamesWon2 + (this._oldGames != null ? this._oldGames.ratedGamesWon : 0);
    }
  }

  [JsonProperty("i")]
  [Indexed(null)]
  public int totalUnratedGames { get; set; }

  [JsonIgnore]
  public int spellbookWinningStreak
  {
    get
    {
      return this.extraStuff.spellbookWinningStreak;
    }
    set
    {
      this.extraStuff.spellbookWinningStreak = value;
    }
  }

  [JsonIgnore]
  public int spellbookWinningStreak_Maps
  {
    get
    {
      return this.extraStuff.spellbookWinningStreak_Maps;
    }
    set
    {
      this.extraStuff.spellbookWinningStreak_Maps = value;
    }
  }

  [JsonIgnore]
  public byte[] lastSpellBook
  {
    get
    {
      return this.extraStuff.lastSpellBook;
    }
    set
    {
      this.extraStuff.lastSpellBook = value;
    }
  }

  [JsonIgnore]
  public long totalDamageDealt
  {
    get
    {
      return this.DamageDealt + this.DamageDealt1 + this.DamageDealt2 + (this._oldGames != null ? this._oldGames.damageDealt : 0L);
    }
  }

  [JsonIgnore]
  public NewGamesPlayed this[int i]
  {
    get
    {
      switch (i)
      {
        case 0:
          return this.gameLowTime;
        case 1:
          return this.gameHighTime;
        case 2:
          return this.gameFun;
        default:
          return this._oldGames;
      }
    }
  }

  [JsonProperty("ratelow")]
  [Indexed(null)]
  public short Rating
  {
    get
    {
      return this.gameLowTime.rating;
    }
    set
    {
      this.gameLowTime.rating = value;
    }
  }

  [JsonProperty("gg2")]
  public int RatedGamesWon
  {
    get
    {
      return this.gameLowTime.ratedGamesWon;
    }
    set
    {
      this.gameLowTime.ratedGamesWon = value;
    }
  }

  [JsonProperty("gg3")]
  public int TotalRatedGames
  {
    get
    {
      return this.gameLowTime.totalRatedGames;
    }
    set
    {
      this.gameLowTime.totalRatedGames = value;
    }
  }

  [JsonProperty("gg4")]
  public int CurrentWinningStreak
  {
    get
    {
      return this.gameLowTime.currentWinningStreak;
    }
    set
    {
      this.gameLowTime.currentWinningStreak = value;
    }
  }

  [JsonProperty("gg5")]
  public int LongestWinningStreak
  {
    get
    {
      return this.gameLowTime.longestWinningStreak;
    }
    set
    {
      this.gameLowTime.longestWinningStreak = value;
    }
  }

  [JsonProperty("gg6")]
  public long DamageDealt
  {
    get
    {
      return this.gameLowTime.damageDealt;
    }
    set
    {
      this.gameLowTime.damageDealt = value;
    }
  }

  [JsonProperty("gg7")]
  public int GamesSurvived
  {
    get
    {
      return this.gameLowTime.gamesSurvived;
    }
    set
    {
      this.gameLowTime.gamesSurvived = value;
    }
  }

  [JsonProperty("gg8")]
  public int Kills
  {
    get
    {
      return this.gameLowTime.kills;
    }
    set
    {
      this.gameLowTime.kills = value;
    }
  }

  [JsonProperty("gg9")]
  public int GamesWentFirst
  {
    get
    {
      return this.gameLowTime.gamesWentFirst;
    }
    set
    {
      this.gameLowTime.gamesWentFirst = value;
    }
  }

  [JsonProperty("gg10")]
  public int GamesWentFirstWon
  {
    get
    {
      return this.gameLowTime.gamesWentFirstWon;
    }
    set
    {
      this.gameLowTime.gamesWentFirstWon = value;
    }
  }

  [JsonProperty("gg11")]
  public int Draws
  {
    get
    {
      return this.gameLowTime.draws;
    }
    set
    {
      this.gameLowTime.draws = value;
    }
  }

  [JsonProperty("gg12")]
  public long LastGamePlayed
  {
    get
    {
      return this.gameLowTime.lastGamePlayed;
    }
    set
    {
      this.gameLowTime.lastGamePlayed = value;
    }
  }

  [JsonProperty("gg13")]
  public int TeamGames
  {
    get
    {
      return this.gameLowTime.teamGames;
    }
    set
    {
      this.gameLowTime.teamGames = value;
    }
  }

  [JsonProperty("ratehigh")]
  [Indexed(null)]
  public short Rating1
  {
    get
    {
      return this.gameHighTime.rating;
    }
    set
    {
      this.gameHighTime.rating = value;
    }
  }

  [JsonProperty("gh2")]
  public int RatedGamesWon1
  {
    get
    {
      return this.gameHighTime.ratedGamesWon;
    }
    set
    {
      this.gameHighTime.ratedGamesWon = value;
    }
  }

  [JsonProperty("gh3")]
  public int TotalRatedGames1
  {
    get
    {
      return this.gameHighTime.totalRatedGames;
    }
    set
    {
      this.gameHighTime.totalRatedGames = value;
    }
  }

  [JsonProperty("gh4")]
  public int CurrentWinningStreak1
  {
    get
    {
      return this.gameHighTime.currentWinningStreak;
    }
    set
    {
      this.gameHighTime.currentWinningStreak = value;
    }
  }

  [JsonProperty("gh5")]
  public int LongestWinningStreak1
  {
    get
    {
      return this.gameHighTime.longestWinningStreak;
    }
    set
    {
      this.gameHighTime.longestWinningStreak = value;
    }
  }

  [JsonProperty("gh6")]
  public long DamageDealt1
  {
    get
    {
      return this.gameHighTime.damageDealt;
    }
    set
    {
      this.gameHighTime.damageDealt = value;
    }
  }

  [JsonProperty("gh7")]
  public int GamesSurvived1
  {
    get
    {
      return this.gameHighTime.gamesSurvived;
    }
    set
    {
      this.gameHighTime.gamesSurvived = value;
    }
  }

  [JsonProperty("gh8")]
  public int Kills1
  {
    get
    {
      return this.gameHighTime.kills;
    }
    set
    {
      this.gameHighTime.kills = value;
    }
  }

  [JsonProperty("gh9")]
  public int GamesWentFirst1
  {
    get
    {
      return this.gameHighTime.gamesWentFirst;
    }
    set
    {
      this.gameHighTime.gamesWentFirst = value;
    }
  }

  [JsonProperty("gh10")]
  public int GamesWentFirstWon1
  {
    get
    {
      return this.gameHighTime.gamesWentFirstWon;
    }
    set
    {
      this.gameHighTime.gamesWentFirstWon = value;
    }
  }

  [JsonProperty("gh11")]
  public int Draws1
  {
    get
    {
      return this.gameHighTime.draws;
    }
    set
    {
      this.gameHighTime.draws = value;
    }
  }

  [JsonProperty("gh12")]
  public long LastGamePlayed1
  {
    get
    {
      return this.gameHighTime.lastGamePlayed;
    }
    set
    {
      this.gameHighTime.lastGamePlayed = value;
    }
  }

  [JsonProperty("gh13")]
  public int TeamGames1
  {
    get
    {
      return this.gameHighTime.teamGames;
    }
    set
    {
      this.gameHighTime.teamGames = value;
    }
  }

  [JsonProperty("rateparty")]
  [Indexed(null)]
  public short Rating2
  {
    get
    {
      return this.gameFun.rating;
    }
    set
    {
      this.gameFun.rating = value;
    }
  }

  [JsonProperty("gi2")]
  public int RatedGamesWon2
  {
    get
    {
      return this.gameFun.ratedGamesWon;
    }
    set
    {
      this.gameFun.ratedGamesWon = value;
    }
  }

  [JsonProperty("gi3")]
  public int TotalRatedGames2
  {
    get
    {
      return this.gameFun.totalRatedGames;
    }
    set
    {
      this.gameFun.totalRatedGames = value;
    }
  }

  [JsonProperty("gi4")]
  public int CurrentWinningStreak2
  {
    get
    {
      return this.gameFun.currentWinningStreak;
    }
    set
    {
      this.gameFun.currentWinningStreak = value;
    }
  }

  [JsonProperty("gi5")]
  public int LongestWinningStreak2
  {
    get
    {
      return this.gameFun.longestWinningStreak;
    }
    set
    {
      this.gameFun.longestWinningStreak = value;
    }
  }

  [JsonProperty("gi6")]
  public long DamageDealt2
  {
    get
    {
      return this.gameFun.damageDealt;
    }
    set
    {
      this.gameFun.damageDealt = value;
    }
  }

  [JsonProperty("gi7")]
  public int GamesSurvived2
  {
    get
    {
      return this.gameFun.gamesSurvived;
    }
    set
    {
      this.gameFun.gamesSurvived = value;
    }
  }

  [JsonProperty("gi8")]
  public int Kills2
  {
    get
    {
      return this.gameFun.kills;
    }
    set
    {
      this.gameFun.kills = value;
    }
  }

  [JsonProperty("gi9")]
  public int GamesWentFirst2
  {
    get
    {
      return this.gameFun.gamesWentFirst;
    }
    set
    {
      this.gameFun.gamesWentFirst = value;
    }
  }

  [JsonProperty("gi10")]
  public int GamesWentFirstWon2
  {
    get
    {
      return this.gameFun.gamesWentFirstWon;
    }
    set
    {
      this.gameFun.gamesWentFirstWon = value;
    }
  }

  [JsonProperty("gi11")]
  public int Draws2
  {
    get
    {
      return this.gameFun.draws;
    }
    set
    {
      this.gameFun.draws = value;
    }
  }

  [JsonProperty("gi12")]
  public long LastGamePlayed2
  {
    get
    {
      return this.gameFun.lastGamePlayed;
    }
    set
    {
      this.gameFun.lastGamePlayed = value;
    }
  }

  [JsonProperty("gi13")]
  public int TeamGames2
  {
    get
    {
      return this.gameFun.teamGames;
    }
    set
    {
      this.gameFun.teamGames = value;
    }
  }

  [JsonProperty("k")]
  public string OLD_GAMES
  {
    get
    {
      return this._oldGames != null ? JsonConvert.SerializeObject((object) this._oldGames) : "";
    }
    set
    {
      this._oldGames = string.IsNullOrEmpty(value) ? (NewGamesPlayed) null : JsonConvert.DeserializeObject<NewGamesPlayed>(value);
    }
  }

  [JsonProperty("j")]
  public string oldName { get; set; } = "";

  [JsonProperty("l")]
  public ExtraStuff extraStuff { get; set; } = new ExtraStuff();

  [JsonProperty("m")]
  public AccountType accountType { get; set; } = AccountType.Muted;

  [JsonProperty("n")]
  public byte experience { get; set; }

  [JsonProperty("o")]
  public byte prestige { get; set; }

  [JsonProperty("p")]
  [Indexed(null)]
  public ulong discord { get; set; }

  [JsonProperty("q")]
  public int displayedIcon { get; set; }

  [JsonProperty("r")]
  public byte displayClanPrefix { get; set; }

  [JsonProperty("s")]
  public int points { get; set; }

  [JsonProperty("t")]
  public long lastLogin { get; set; }

  [JsonProperty("u")]
  public int dust { get; set; }

  [JsonProperty("ap")]
  public int poll { get; set; }

  [JsonIgnore]
  public int DisplayedBadge
  {
    get
    {
      return this.displayedIcon - 256;
    }
  }

  [JsonIgnore]
  public Location location { get; set; }

  [JsonIgnore]
  public ulong p
  {
    get
    {
      return this.discord;
    }
  }

  [JsonIgnore]
  public string g
  {
    get
    {
      return this.steamKey;
    }
  }

  [JsonIgnore]
  public bool OnAnotherServer
  {
    get
    {
      return this.server > 0 && this.server != Server.ID;
    }
  }

  [JsonProperty("x")]
  public short version { get; set; } = 10032;

  [JsonProperty("y")]
  public BitBools tutorials { get; set; } = new BitBools();

  [JsonProperty("z")]
  public int wands { get; set; }

  [JsonProperty("aa")]
  public int totalWands { get; set; }

  [JsonProperty("ab")]
  public ChatSetting lobbyChat { get; set; }

  [JsonProperty("ac")]
  public ChatSetting gameChat { get; set; }

  [JsonProperty("ad")]
  public ChatSetting friendChat { get; set; }

  [JsonProperty("ae")]
  public ChatSetting inviteChat { get; set; }

  [JsonProperty("af")]
  public ChatSetting spectatorChat { get; set; }

  [JsonProperty("ag")]
  public ChatSetting clanChat { get; set; }

  [JsonProperty("ah")]
  public ChatSetting teamChat { get; set; }

  [JsonProperty("ai")]
  public ChatSetting miniGameChat { get; set; }

  [JsonProperty("aj")]
  public HashSet<string> friends
  {
    get
    {
      return this._friends;
    }
    set
    {
      this._friends = value != null ? new HashSet<string>((IEnumerable<string>) value, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase) : new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }
  }

  [JsonProperty("ak")]
  public HashSet<string> ignored
  {
    get
    {
      return this._ignored;
    }
    set
    {
      this._ignored = value != null ? new HashSet<string>((IEnumerable<string>) value, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase) : new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }
  }

  [JsonProperty("al")]
  public Cosmetics cosmetics { get; set; } = new Cosmetics();

  [JsonProperty("am")]
  public float bonusExperience { get; set; }

  [JsonProperty("an")]
  public string clan { get; set; } = "";

  [JsonProperty("ao")]
  public Clan.Roles clanRole { get; set; } = Clan.Roles.Member;

  [JsonProperty("aq")]
  public BitBools badges { get; set; } = new BitBools();

  [JsonProperty("ar")]
  public BoughtStoreItems storeItems { get; set; } = new BoughtStoreItems();

  [JsonProperty("as")]
  public SerializedActiveItem activeItems { get; set; } = new SerializedActiveItem();

  public bool AccountLinked()
  {
    return this.discord != 0UL || !string.IsNullOrEmpty(this.steamKey);
  }

  public bool AccountNotLinked()
  {
    return !this.AccountLinked();
  }

  public NewGamesPlayed GetGamesPlayed(ZGame.GameType f)
  {
    int index = (int) f;
    return index < 0 || index > 2 ? this.gameFun : this[index];
  }

  public NewGamesPlayed GetGamesPlayed(GameFacts f)
  {
    if (f.GetStyle().HasStyle(GameStyle.Elementals | GameStyle.Random_Spells))
      return this.gameFun;
    return f.GetTimeInSeconds() >= 30 ? this.gameHighTime : this.gameLowTime;
  }

  public int experienceIndex()
  {
    return (int) this.experience;
  }

  public static string numberplus(int i)
  {
    return i.ToString() + Account.number(i);
  }

  public static string number(int ii)
  {
    if (ii % 100 >= 11 && ii % 100 <= 13)
      return "th";
    switch (ii % 10)
    {
      case 1:
        return "st";
      case 2:
        return "nd";
      case 3:
        return "rd";
      default:
        return "th";
    }
  }

  public void IncreaseExperience(Connection c)
  {
    this.bonusExperience -= (float) this.RequiredPoints();
    if ((double) this.bonusExperience < 0.0)
      this.bonusExperience = 0.0f;
    ++this.experience;
    Server.ReturnServerMsg(c, "You are now level " + this.experienceIndex().ToString() + "!");
    Server.UpdateAccountInfo(this, true);
  }

  public short RequiredRating()
  {
    return (short) ((int) this.experience * 200);
  }

  public int RequiredAchievements()
  {
    return Mathf.Clamp((int) this.experience, 0, 10) * 2500 + 500;
  }

  public int RequiredPoints()
  {
    return ((int) this.experience + 1) * 156;
  }

  public void AddWands(int x)
  {
    this.totalWands += x;
    if (this.totalWands > Prestige.MaxWands(this))
    {
      int num = this.totalWands - Prestige.MaxWands(this);
      this.totalWands -= num;
      x -= num;
    }
    this.wands += x;
  }

  public static string ToRomanNumber(int number)
  {
    StringBuilder stringBuilder = new StringBuilder();
    while (number > 0)
    {
      for (int index = ((IEnumerable<int>) Account.digitsValues).Count<int>() - 1; index >= 0; --index)
      {
        if (number / Account.digitsValues[index] >= 1)
        {
          number -= Account.digitsValues[index];
          stringBuilder.Append(Account.romanDigits[index]);
          break;
        }
      }
    }
    return stringBuilder.ToString();
  }

  public static int RomanSpriteIndex(char c)
  {
    switch (c)
    {
      case 'C':
        return 4;
      case 'I':
        return 0;
      case 'L':
        return 3;
      case 'M':
        return 5;
      case 'V':
        return 1;
      case 'X':
        return 2;
      default:
        return 0;
    }
  }

  public Account()
  {
  }

  public Account(string n)
  {
    this.name = n;
  }

  public void Serialize(myBinaryWriter w, bool includeActiveItems = false)
  {
    w.Write(this.name);
    w.Write(this.Rating);
    w.Write(this.Rating1);
    w.Write(this.Rating2);
    w.Write((int) this.accountType);
    w.Write(this.experience);
    w.Write(this.discord);
    w.Write(this.displayedIcon);
    w.Write(this.displayClanPrefix);
    w.Write(this.clan);
    w.Write((byte) this.clanRole);
    w.Write(this.location.Online() ? (byte) 1 : (byte) 0);
    w.Write(this.prestige);
    w.Write(this.oldName);
    w.Write(this.server);
    w.Write(this.afkTimer);
    if (!includeActiveItems)
      return;
    this.activeItems.Serialize(w);
  }

  public void Deserialize(myBinaryReader r, bool includeActiveItems = false)
  {
    this.name = r.ReadString();
    this.Rating = r.ReadInt16();
    this.Rating1 = r.ReadInt16();
    this.Rating2 = r.ReadInt16();
    this.accountType = (AccountType) r.ReadInt32();
    this.experience = r.ReadByte();
    this.discord = r.ReadUInt64();
    this.displayedIcon = r.ReadInt32();
    this.displayClanPrefix = r.ReadByte();
    this.clan = r.ReadString();
    this.clanRole = (Clan.Roles) r.ReadByte();
    this.location = r.ReadByte() == (byte) 1 ? Location.Ingame : Location.Disconnecting;
    this.prestige = r.ReadByte();
    this.oldName = r.ReadString();
    this.server = r.ReadInt32();
    this.afkTimer = r.ReadInt64();
    if (!includeActiveItems)
      return;
    this.activeItems.Deserialize(r);
  }

  public void CopyClient(Account other)
  {
    this.name = other.name;
    this.Rating = other.Rating;
    this.Rating1 = other.Rating1;
    this.Rating2 = other.Rating2;
    this.accountType = other.accountType;
    this.experience = other.experience;
    this.discord = other.discord;
    this.displayedIcon = other.displayedIcon;
    this.displayClanPrefix = other.displayClanPrefix;
    this.clan = other.clan;
    this.clanRole = other.clanRole;
    this.location = other.location;
    this.prestige = other.prestige;
    this.oldName = other.oldName;
    this.server = other.server;
    this.afkTimer = other.afkTimer;
  }

  public static int MaxNameLength
  {
    get
    {
      return 13;
    }
  }

  public static string ValidName(string s)
  {
    s = s.ToLower();
    if (string.IsNullOrEmpty(s))
      return "Cannot be empty";
    if (s.StartsWith(" "))
      return "Cannot begin with a Space";
    if (s.EndsWith(" "))
      return "Cannot end with a Space";
    if (s.Length > Account.MaxNameLength)
      return "Maximum 13 Characters";
    string str = Account.ContainsInvalidWord(s);
    if (str != null)
      return "Contains invalid Phrase '" + str + "'";
    foreach (char ch in s)
    {
      if ((ch < 'a' || ch > 'z') && (ch < '0' || ch > '9') && ch != ' ')
        return "Only Alphanumeric and Space characters are allowed";
    }
    return (string) null;
  }

  public static string ValidPassword(string s)
  {
    return s.Length < 8 || s.Length > 20 ? "Password must between 8 and 20 Characters" : (string) null;
  }

  private static string ContainsInvalidWord(string source)
  {
    IEnumerable<string> source1 = ((IEnumerable<string>) source.Split()).Select<string, string>((Func<string, string>) (x => x.Trim(Account.punctuation)));
    foreach (string str in Account.InvalidWord)
    {
      if (source1.Contains<string>(str, (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase))
        return str;
    }
    foreach (string fullWord in Account.fullWords)
    {
      if (source.Contains(fullWord))
        return fullWord;
    }
    return (string) null;
  }

  public static void SerializeList(HashSet<string> s, myBinaryWriter w)
  {
    w.Write(s.Count);
    foreach (string str in s)
      w.Write(str);
  }

  public static void DeserializeList(HashSet<string> s, myBinaryReader r)
  {
    s.Clear();
    int num = r.ReadInt32();
    for (int index = 0; index < num; ++index)
      s.Add(r.ReadString());
  }
}
