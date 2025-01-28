
using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
  private void Start()
  {
    Global.persistentDataPath = Application.persistentDataPath;
    string[] commandLineArgs = Environment.GetCommandLineArgs();
    if (commandLineArgs.Length > 1 && commandLineArgs[1] == "Server")
    {
      Application.targetFrameRate = 60;
      QualitySettings.vSyncCount = 0;
      SceneManager.LoadScene("ServerLobby");
    }
    else
    {
      Application.targetFrameRate = Mathf.Max(61, Mathf.Min(144, Screen.currentResolution.refreshRate));
      StartUp.CheckDirectorySwitch();
      SceneManager.LoadScene("mainmenu");
    }
  }

  public static void CheckDirectorySwitch()
  {
    try
    {
      string persistentDataPath1 = SaveFolder.persistentDataPath;
      string persistentDataPath2 = Application.persistentDataPath;
      if (Global.GetPrefBool("checkdirswitch3", false) && !string.Equals(persistentDataPath2, persistentDataPath1) && (Directory.GetFiles(persistentDataPath1 + "/SavedSpells").Length < 10 && Directory.GetFiles(persistentDataPath2 + "/SavedSpells").Length != 0))
      {
        StartUp.CopyDirectory(persistentDataPath2, persistentDataPath1);
        Global.SetPrefBool("checkdirswitch3", true);
        Debug.Log((object) "Transferring saved outfits/spells into steam cloud save");
      }
      else
      {
        Global.SetPrefBool("checkdirswitch3", true);
        Debug.Log((object) "Transferring saved outfits/spells into steam cloud save");
        StartUp.CopyDirectory(persistentDataPath2, persistentDataPath1);
      }
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex.ToString());
    }
  }

  private static void CopyDirectory(string sourceDir, string destDir)
  {
    if (sourceDir.Contains("Replay"))
      return;
    if (!Directory.Exists(destDir))
      Directory.CreateDirectory(destDir);
    foreach (string file in Directory.GetFiles(sourceDir))
    {
      string str = Path.Combine(destDir, Path.GetFileName(file));
      if (!File.Exists(str))
        File.Copy(file, str, true);
    }
    foreach (string directory in Directory.GetDirectories(sourceDir))
    {
      string destDir1 = Path.Combine(destDir, Path.GetFileName(directory));
      StartUp.CopyDirectory(directory, destDir1);
    }
  }
}
