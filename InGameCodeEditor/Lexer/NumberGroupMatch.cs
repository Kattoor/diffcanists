
using System;
using UnityEngine;

namespace InGameCodeEditor.Lexer
{
  [Serializable]
  public sealed class NumberGroupMatch : MatchLexer
  {
    [Tooltip("Should numbers be highlighted")]
    public bool highlightNumbers = true;
    [Tooltip("The color that all numbers will be highlighted with")]
    public Color highlightColor = Color.black;
    [NonSerialized]
    private string htmlColor;

    public bool HasNumberHighlighting
    {
      get
      {
        return this.highlightNumbers;
      }
    }

    public override string HTMLColor
    {
      get
      {
        if (this.htmlColor == null)
          this.htmlColor = "<#" + ColorUtility.ToHtmlStringRGB(this.highlightColor) + ">";
        return this.htmlColor;
      }
    }

    public override void Invalidate()
    {
      this.htmlColor = (string) null;
    }

    public override bool IsImplicitMatch(ILexer lexer)
    {
      if (!this.highlightNumbers || !char.IsWhiteSpace(lexer.Previous) && !lexer.IsSpecialSymbol(lexer.Previous, SpecialCharacterPosition.End))
        return false;
      bool flag = false;
      while (!lexer.EndOfStream)
      {
        if (this.IsNumberOrDecimalPoint(lexer, lexer.ReadNext()))
        {
          flag = true;
          lexer.Commit();
        }
        else
        {
          lexer.Rollback(-1);
          break;
        }
      }
      return flag;
    }

    private bool IsNumberOrDecimalPoint(ILexer lexer, char character)
    {
      return char.IsNumber(character) || character == '.';
    }
  }
}
