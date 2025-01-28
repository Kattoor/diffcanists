
using System.IO;
using UnityEngine;

public static class SaveFolder
{
  public static string persistentDataPath
  {
    get
    {
      return Directory.Exists(Application.dataPath + "/SavedData") ? Application.dataPath + "/SavedData" : Application.persistentDataPath;
    }
  }
}
