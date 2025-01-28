
using Discord;
using Hazel;
using System;
using System.IO;
using UnityEngine;

public class DiscordController : MonoBehaviour
{
  public const long CLIENT_ID = 633505532753346580;

  public void ClickVerify()
  {
    DiscordController.Verify();
  }

  public static void Verify()
  {
    try
    {
      new Discord.Discord(633505532753346580L, 1UL).GetApplicationManager().GetOAuth2Token(new ApplicationManager.GetOAuth2TokenHandler(DiscordController.AuthCallback));
    }
    catch (Exception ex)
    {
      DiscordController._VerifyBrowser();
    }
  }

  private static void AuthCallback(Result result, ref OAuth2Token oauth2Token)
  {
    if (result != Result.Ok)
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 49);
        myBinaryWriter.Write(oauth2Token.AccessToken);
        myBinaryWriter.Write(Client.identifier);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public void VerifyBrowser()
  {
    DiscordController._VerifyBrowser();
  }

  public static void _VerifyBrowser()
  {
    Global.OpenURL("https://discord.com/api/oauth2/authorize?response_type=token&client_id=633505532753346580&redirect_uri=http%3A%2F%2F" + PlayerPrefs.GetString("prefserver", Client.serverIP) + "%3A8080&scope=identify&state=" + Client.Name + Client.identifier);
  }
}
