
using UnityEngine;

internal class StandardBoard : IBoard
{
  public void SetText(string str)
  {
    GUIUtility.systemCopyBuffer = str;
  }

  public string GetText()
  {
    return GUIUtility.systemCopyBuffer;
  }
}
