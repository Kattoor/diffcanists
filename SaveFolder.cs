
using System.IO;
using UnityEngine;

public static class SaveFolder
{
  public static string persistentDataPath
  {
    get
    {
      return Directory.Exists(Path.GetFullPath(".") + "/SavedData") ? Path.GetFullPath(".") + "/SavedData" : Application.persistentDataPath;
    }
  }
}
