
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class LogSpells
{
  public LogSpells.FFATeams ffa = new LogSpells.FFATeams();
  public LogSpells.FFATeams teams = new LogSpells.FFATeams();
  public int totalGames;

  public void Save()
  {
    this.Save("LogSpells.json");
  }

  public void Save(string s)
  {
    File.WriteAllText("LogSpells.json", JsonConvert.SerializeObject((object) this));
  }

  public static LogSpells Load()
  {
    return LogSpells.Load("LogSpells.json");
  }

  public static LogSpells Load(string s)
  {
    return File.Exists(s) ? JsonConvert.DeserializeObject<LogSpells>(File.ReadAllText(s)) : new LogSpells();
  }

  public void OnGameEnded(GameFacts g)
  {
    LogSpells.FFATeams ffaTeams = g.GetTeamMode() ? this.teams : this.ffa;
    if (!g.GetTeamMode() && g.game.players.Count > 2)
      return;
    bool flag1 = true;
    int num1 = 0;
    foreach (ZPerson player in g.game.players)
    {
      if (player.winner)
        flag1 = false;
      num1 += (int) player.startingRating;
    }
    int num2 = num1 / g.game.players.Count;
    LogSpells.RatingBracket ratingBracket = num2 < 1500 ? ffaTeams._1000 : (num2 < 2000 ? ffaTeams._1500 : ffaTeams._2000);
    LogSpells.Ladder ladder = !g.GetStyle().HasStyle(GameStyle.Random_Spells) ? (!g.GetStyle().HasStyle(GameStyle.Elementals) ? (g.settings.customTime >= (ushort) 30 ? ratingBracket.hts : ratingBracket.lts) : ratingBracket.ele) : ratingBracket.rng;
    ++ffaTeams.totalGames;
    ++ratingBracket.totalGames;
    ++ladder.totalGames;
    ++this.totalGames;
    bool flag2 = g.GetStyle().HasStyle(GameStyle.Elementals);
    foreach (ZPerson player in g.game.players)
    {
      foreach (byte spell in player.settingsPlayer.spells)
      {
        if (spell != byte.MaxValue && (int) spell < Inert.Instance._spells.Length)
        {
          ladder.Add((int) Inert.Instance._spells[(int) spell].spellEnum, ladder.taken, 1);
          if (player.winner)
            ladder.Add((int) Inert.Instance._spells[(int) spell].spellEnum, ladder.win, 1);
          else if (!flag1)
            ladder.Add((int) Inert.Instance._spells[(int) spell].spellEnum, ladder.loss, 1);
          if (player.ActivateableFamiliar != BookOf.Nothing)
          {
            ladder.Add((int) player.ElementalFamiliar, ladder.famTaken, 1);
            if (player.winner)
              ladder.Add((int) player.ElementalFamiliar, ladder.famWin, 1);
            else if (!flag1)
              ladder.Add((int) player.ElementalFamiliar, ladder.famLoss, 1);
          }
          if (flag2)
          {
            ladder.Add((int) player.ElementalFamiliar, ladder.eleTaken, 1);
            if (player.winner)
              ladder.Add((int) player.ElementalFamiliar, ladder.eleWin, 1);
            else if (!flag1)
              ladder.Add((int) player.ElementalFamiliar, ladder.eleLoss, 1);
          }
        }
      }
      foreach (KeyValuePair<SpellEnum, SpellsCast> keyValuePair in player.spellsCast)
      {
        ladder.Add((int) keyValuePair.Key, ladder.cast, keyValuePair.Value.count);
        if (player.winner)
          ladder.Add((int) keyValuePair.Key, ladder.castWin, keyValuePair.Value.count);
        else if (!flag1)
          ladder.Add((int) keyValuePair.Key, ladder.castLoss, keyValuePair.Value.count);
      }
    }
    this.Save();
  }

  public class FFATeams
  {
    public LogSpells.RatingBracket _1000 = new LogSpells.RatingBracket();
    public LogSpells.RatingBracket _1500 = new LogSpells.RatingBracket();
    public LogSpells.RatingBracket _2000 = new LogSpells.RatingBracket();
    public int totalGames;
  }

  public class RatingBracket
  {
    public LogSpells.Ladder lts = new LogSpells.Ladder();
    public LogSpells.Ladder hts = new LogSpells.Ladder();
    public LogSpells.Ladder ele = new LogSpells.Ladder();
    public LogSpells.Ladder rng = new LogSpells.Ladder();
    public int totalGames;
  }

  public class Ladder
  {
    public List<int> taken = new List<int>();
    public List<int> cast = new List<int>();
    public List<int> castWin = new List<int>();
    public List<int> castLoss = new List<int>();
    public List<int> win = new List<int>();
    public List<int> loss = new List<int>();
    public List<int> eleTaken = new List<int>();
    public List<int> eleWin = new List<int>();
    public List<int> eleLoss = new List<int>();
    public List<int> famTaken = new List<int>();
    public List<int> famWin = new List<int>();
    public List<int> famLoss = new List<int>();
    public int totalGames;

    public void Add(int index, List<int> list, int count)
    {
      while (list.Count <= index)
        list.Add(0);
      list[index] += count;
    }
  }
}
