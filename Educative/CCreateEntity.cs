
namespace Educative
{
  public class CCreateEntity : Command
  {
    public int summon = 1;
    public int team = 1;
    public Point point_location = new Point(0.0, 0.0);
    public SettingsPlayer settings = SettingsPlayer.DefaultSettings();
    public bool bool_OnPlayerPanel;
    public bool bool_playSound;

    public CCreateEntity()
    {
      this.type = Command.Type.CreateEntity;
    }
  }
}
