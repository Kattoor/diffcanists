
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class FileUploaderHelper
{
  public static HashSet<string> unnotable = new HashSet<string>()
  {
    "clue_scroll"
  };
  private static Action<string> pathCallback;

  static FileUploaderHelper()
  {
    string name = typeof (FileUploaderHelper).Name;
  }

  public static void RequestFile(Action<string> callback, string extensions = ".jpg, .jpeg, .png")
  {
    FileUploaderHelper.pathCallback = callback;
  }

  public static void SetResult(string path)
  {
    FileUploaderHelper.pathCallback(path);
    FileUploaderHelper.Dispose();
  }

  private static void Dispose()
  {
    FileUploaderHelper.pathCallback = (Action<string>) null;
  }

  private static string MakeSafeForCode(string str)
  {
    str = Regex.Replace(str, "[^a-zA-Z0-9_ ]", "", RegexOptions.Compiled);
    if (char.IsDigit(str[0]))
      str = "_" + str;
    return str;
  }

  private static string RemoveSpaces(string str)
  {
    str = Regex.Replace(str, "[^a-zA-Z0-9_]", "_", RegexOptions.Compiled);
    if (char.IsDigit(str[0]))
      str = "_" + str;
    return str;
  }

  public static void Parse()
  {
  }

  public class noted
  {
    public bool isNoted;
    public int offset;
  }
}
