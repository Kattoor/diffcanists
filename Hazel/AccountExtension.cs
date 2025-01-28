
using System;
using System.Text;

namespace Hazel
{
  public static class AccountExtension
  {
    public static AccountType[] _IconOrder = new AccountType[31]
    {
      AccountType.Owner,
      AccountType.Developer,
      AccountType.Game_Director,
      AccountType.Backend_Technical_Director,
      AccountType.Art_Director,
      AccountType.Audio_Director,
      AccountType.Website_Director,
      AccountType.Tournament_Director,
      AccountType.Head_of_Moderation,
      AccountType.Mod,
      AccountType.Perm_Muted,
      AccountType.Muted,
      AccountType.Contributor,
      AccountType.Tournament_Official,
      AccountType.Press_Account,
      AccountType.Asset_Creator,
      AccountType.Audio_Wizard,
      AccountType.Lifetime,
      AccountType.Arch_Donator,
      AccountType.Donator,
      AccountType.Booster,
      AccountType.Arcane_Monster,
      AccountType.Wiki_Staff,
      AccountType.Twitch_Streamer,
      AccountType.Youtube_Creator,
      AccountType.Robotics_Division,
      AccountType.First_Place,
      AccountType.Second_Place,
      AccountType.Third_Place,
      AccountType.Tourny_Participate,
      AccountType.None
    };

    public static byte GetIndex(this AccountType a)
    {
      int num = (int) a;
      for (int index = 0; index < 32; ++index)
      {
        if ((num & 1 << index) != 0)
          return (byte) index;
      }
      return 0;
    }

    public static string ToSpacelessString(this AccountType a)
    {
      return a.ToString().Replace('_', ' ');
    }

    public static string ToExtendedString(this AccountType a)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (AccountType accountType in (AccountType[]) Enum.GetValues(typeof (AccountType)))
      {
        if ((a & accountType) != AccountType.None)
        {
          if (stringBuilder.Length > 0)
            stringBuilder.Append(", ");
          stringBuilder.Append(accountType.ToString());
        }
      }
      return stringBuilder.Length == 0 ? "None" : stringBuilder.ToString();
    }

    public static bool isMod(this AccountType a)
    {
      return (uint) (a & (AccountType.Mod | AccountType.Head_of_Moderation)) > 0U;
    }

    public static bool isDev(this AccountType a)
    {
      return (uint) (a & (AccountType.Developer | AccountType.Game_Director | AccountType.Owner)) > 0U;
    }

    public static bool isDevOrHeadMod(this AccountType a)
    {
      return (uint) (a & (AccountType.Developer | AccountType.Head_of_Moderation | AccountType.Game_Director | AccountType.Owner)) > 0U;
    }

    public static bool IsModPlus(this AccountType a)
    {
      return (uint) (a & (AccountType.Mod | AccountType.Developer | AccountType.Head_of_Moderation | AccountType.Game_Director | AccountType.Owner)) > 0U;
    }

    public static bool IsModPlusTOParticipate(this AccountType a)
    {
      return (uint) (a & (AccountType.Mod | AccountType.Developer | AccountType.Head_of_Moderation | AccountType.Tournament_Official | AccountType.Game_Director | AccountType.Owner | AccountType.Tournament_Director | AccountType.Tourny_Participate)) > 0U;
    }

    public static bool IsModPlusTO(this AccountType a)
    {
      return (uint) (a & (AccountType.Mod | AccountType.Developer | AccountType.Head_of_Moderation | AccountType.Tournament_Official | AccountType.Game_Director | AccountType.Owner | AccountType.Tournament_Director)) > 0U;
    }

    public static bool Heightened(this AccountType a)
    {
      return (uint) (a & (AccountType.Mod | AccountType.Developer | AccountType.Head_of_Moderation | AccountType.Audio_Director | AccountType.Contributor | AccountType.Backend_Technical_Director | AccountType.Wiki_Staff | AccountType.Twitch_Streamer | AccountType.Youtube_Creator | AccountType.Asset_Creator | AccountType.Audio_Wizard | AccountType.Website_Director | AccountType.Game_Director | AccountType.Art_Director | AccountType.Owner | AccountType.Tournament_Director)) > 0U;
    }
  }
}
