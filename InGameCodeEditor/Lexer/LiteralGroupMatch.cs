
using System;
using System.Collections.Generic;
using UnityEngine;

namespace InGameCodeEditor.Lexer
{
  [Serializable]
  public sealed class LiteralGroupMatch : MatchLexer
  {
    [Tooltip("Should literals inside quotes be highlghted")]
    public bool highlightLiterals = true;
    [Tooltip("The color that all literal strings will be highglighted with")]
    public Color highlightColor = Color.black;
    [NonSerialized]
    private string htmlColor;

    public bool HasLiteralHighlighting
    {
      get
      {
        return this.highlightLiterals;
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

    public override IEnumerable<char> SpecialStartCharacters
    {
      get
      {
        yield return '"';
        yield return '\'';
      }
    }

    public override IEnumerable<char> SpecialEndCharacters
    {
      get
      {
        yield return '"';
        yield return '\'';
      }
    }

    public override void Invalidate()
    {
      this.htmlColor = (string) null;
    }

    public override bool IsImplicitMatch(ILexer lexer)
    {
      if (!this.highlightLiterals || lexer.ReadNext() != '"')
        return false;
      do
        ;
      while (!this.IsClosingQuoteOrEndFile(lexer, lexer.ReadNext()));
      return true;
    }

    private bool IsClosingQuoteOrEndFile(ILexer lexer, char character)
    {
      return lexer.EndOfStream || character == '"';
    }
  }
}
