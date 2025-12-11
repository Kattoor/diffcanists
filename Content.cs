
using Educative;
using UnityEngine;

public static class Content
{
  public static object GetContent(myBinaryReader reader, ContentType contentType)
  {
    switch (contentType)
    {
      case ContentType.Outfit:
      case ContentType.SpellBook:
        SettingsPlayer settingsPlayer = new SettingsPlayer();
        settingsPlayer.Deserialize(reader);
        return (object) settingsPlayer;
      case ContentType.ArcTutorial:
        return (object) Tutorial.FromBytes(reader.ReadBytes());
      case ContentType.GameSettings:
        GameSettings gameSettings = new GameSettings();
        gameSettings.Deserialize(reader, (byte) 5);
        return (object) gameSettings;
      case ContentType.ClanInvite:
        return (object) new ClanInvite()
        {
          from = reader.ReadString(),
          clan = reader.ReadString(),
          expire = (Time.realtimeSinceStartup + 29f)
        };
      case ContentType.MiniGameInvite:
        return (object) new MinigameInvite()
        {
          from = reader.ReadString(),
          miniGameType = reader.ReadInt32(),
          spectator = reader.ReadBoolean(),
          minigameID = reader.ReadInt32()
        };
      case ContentType.ColorScheme:
        return (object) ColorScheme.Deserialize(reader);
      case ContentType.RatedSettings:
        return (object) RatedFacts.Deserialize(5, reader);
      case ContentType.RatedContainer:
        return (object) RatedContainer.Deserialize(reader);
      case ContentType.Achievement:
        return (object) reader.ReadInt32();
      default:
        return (object) null;
    }
  }

  public static void ToBytes(myBinaryWriter writer, object d, ContentType contentType)
  {
    switch (contentType)
    {
      case ContentType.Outfit:
      case ContentType.SpellBook:
        ((SettingsPlayer) d).Serialize(writer);
        break;
      case ContentType.ArcTutorial:
        Tutorial tutorial = (Tutorial) d;
        writer.Write(tutorial.ToBytes());
        break;
      case ContentType.GameSettings:
        ((GameSettings) d).Serialize(writer);
        break;
      case ContentType.ClanInvite:
        ClanInvite clanInvite = (ClanInvite) d;
        writer.Write(clanInvite.clan);
        break;
      case ContentType.MiniGameInvite:
        MinigameInvite minigameInvite = (MinigameInvite) d;
        writer.Write(minigameInvite.from);
        writer.Write(minigameInvite.miniGameType);
        writer.Write(minigameInvite.spectator);
        writer.Write(minigameInvite.minigameID);
        break;
      case ContentType.ColorScheme:
        ((ColorScheme) d).Serialize(writer);
        break;
      case ContentType.RatedSettings:
        ((RatedFacts) d).Share(writer);
        break;
      case ContentType.RatedContainer:
        ((RatedContainer) d).Serialize(writer, true);
        break;
      case ContentType.Achievement:
        writer.Write((int) d);
        break;
    }
  }
}
