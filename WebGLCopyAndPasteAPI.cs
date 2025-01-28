
using UnityEngine;

public class WebGLCopyAndPasteAPI
{
  public static void Copy(string s)
  {
    GUIUtility.systemCopyBuffer = s;
  }
}
