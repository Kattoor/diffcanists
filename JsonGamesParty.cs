
using Newtonsoft.Json;

public class JsonGamesParty : IJsonGames
{
  [JsonIgnore]
  public NewGamesPlayed gameFun = new NewGamesPlayed();

  public string name { get; set; }

  [JsonIgnore]
  public int rank { get; set; }

  [JsonIgnore]
  public NewGamesPlayed games
  {
    get
    {
      return this.gameFun;
    }
    set
    {
      this.gameFun = value;
    }
  }

  [JsonProperty("rateparty")]
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
}
