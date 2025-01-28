
using MoonSharp.Interpreter;

namespace Educative
{
  public class Summon
  {
    public Point position = new Point(750.0, 750.0);
    public int team = 1;
    public bool useAI = true;
    public string name = "";
    public bool playSound = true;
    public BookOf elemental = BookOf.Nothing;
    public object spell;
    public bool onPlayersPanel;
    public bool no_AI_still_use_turn;
    public int prestige;
    public Table colors;
    public Table spells;
    public Table outfit;

    public static Summon construct(
      object spell = null,
      Point point = null,
      int team = 1,
      Table colors = null,
      bool playSound = true,
      bool onPlayersPanel = false,
      string name = "",
      Table outfit = null,
      Table spells = null,
      BookOf elemental = BookOf.Nothing,
      int prestige = 0)
    {
      return new Summon()
      {
        spell = spell,
        position = point != (Point) null ? point : new Point(750.0, 750.0),
        team = team,
        colors = colors,
        outfit = outfit,
        spells = spells,
        elemental = elemental,
        playSound = playSound,
        onPlayersPanel = onPlayersPanel,
        name = name,
        prestige = prestige
      };
    }
  }
}
