
using System;

public class AccountStatistics
{
  public class PastGames
  {
    public long date;
    public string[] players;
    public int gameModes;
    public int gameModes2;
    public bool winner;

    public void Serialize(myBinaryWriter w)
    {
      w.Write(this.winner);
      w.Write(this.date);
      w.Write(this.gameModes);
      w.Write(this.gameModes2);
      w.Write(this.players.Length);
      for (int index = 0; index < this.players.Length; ++index)
        w.Write(this.players[index]);
    }

    public string GetDate()
    {
      return DateTime.FromBinary(this.date).ToShortDateString();
    }

    public static AccountStatistics.PastGames Deserialize(myBinaryReader r)
    {
      AccountStatistics.PastGames pastGames = new AccountStatistics.PastGames();
      pastGames.winner = r.ReadBoolean();
      pastGames.date = r.ReadInt64();
      pastGames.gameModes = r.ReadInt32();
      pastGames.gameModes2 = r.ReadInt32();
      int length = r.ReadInt32();
      pastGames.players = new string[length];
      for (int index = 0; index < length; ++index)
        pastGames.players[index] = r.ReadString();
      return pastGames;
    }
  }
}
