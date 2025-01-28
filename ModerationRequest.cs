
using System;

[Serializable]
public class ModerationRequest
{
  public string model = "omni-moderation-latest";
  public string input;

  public ModerationRequest(string inputText)
  {
    this.input = inputText;
  }
}
