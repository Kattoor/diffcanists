
using Newtonsoft.Json;

public interface IJsonGames
{
  NewGamesPlayed games { get; }

  string name { get; set; }

  [JsonIgnore]
  int rank { get; set; }
}
