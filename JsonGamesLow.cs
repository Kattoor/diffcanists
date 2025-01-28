
using Newtonsoft.Json;

public class JsonGamesLow : IJsonGames
{
  [JsonIgnore]
  public NewGamesPlayed gameLowTime = new NewGamesPlayed();

  public string name { get; set; }

  [JsonIgnore]
  public int rank { get; set; }

  [JsonIgnore]
  public NewGamesPlayed games
  {
    get
    {
      return this.gameLowTime;
    }
    set
    {
      this.gameLowTime = value;
    }
  }

  [JsonProperty("ratelow")]
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
}
