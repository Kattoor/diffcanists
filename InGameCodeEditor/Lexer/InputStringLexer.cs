
using System;
using System.Collections.Generic;

namespace InGameCodeEditor.Lexer
{
  internal class InputStringLexer : ILexer
  {
    private HashSet<char> specialStartSymbols = new HashSet<char>();
    private HashSet<char> specialEndSymbols = new HashSet<char>();
    private char current = ' ';
    private char previous = ' ';
    private string inputString;
    private MatchLexer[] matchers;
    private int currentIndex;
    private int currentLookaheadIndex;

    public bool EndOfStream
    {
      get
      {
        return this.currentLookaheadIndex >= this.inputString.Length;
      }
    }

    public char Previous
    {
      get
      {
        return this.previous;
      }
    }

    public void UseMatchers(char[] delimiters, MatchLexer[] matchers)
    {
      this.matchers = matchers;
      this.specialStartSymbols.Clear();
      this.specialEndSymbols.Clear();
      if (delimiters != null)
      {
        foreach (char delimiter in delimiters)
        {
          if (!this.specialStartSymbols.Contains(delimiter))
            this.specialStartSymbols.Add(delimiter);
          if (!this.specialEndSymbols.Contains(delimiter))
            this.specialEndSymbols.Add(delimiter);
        }
      }
      if (matchers == null)
        return;
      foreach (MatchLexer matcher in matchers)
      {
        foreach (char specialStartCharacter in matcher.SpecialStartCharacters)
        {
          if (!this.specialStartSymbols.Contains(specialStartCharacter))
            this.specialStartSymbols.Add(specialStartCharacter);
        }
        foreach (char specialEndCharacter in matcher.SpecialEndCharacters)
        {
          if (!this.specialEndSymbols.Contains(specialEndCharacter))
            this.specialEndSymbols.Add(specialEndCharacter);
        }
      }
    }

    public IEnumerable<InputStringMatchInfo> LexInputString(
      string input)
    {
      InputStringLexer inputStringLexer = this;
      if (input == null)
        throw new ArgumentNullException(nameof (input));
      if (inputStringLexer.matchers != null && inputStringLexer.matchers.Length != 0)
      {
        inputStringLexer.inputString = input;
        inputStringLexer.current = ' ';
        inputStringLexer.previous = ' ';
        inputStringLexer.currentIndex = 0;
        inputStringLexer.currentLookaheadIndex = 0;
        while (!__nonvirtual (inputStringLexer.EndOfStream))
        {
          bool didMatchLexer = false;
          inputStringLexer.ReadWhiteSpace();
          foreach (MatchLexer matcher in inputStringLexer.matchers)
          {
            int currentIndex1 = inputStringLexer.currentIndex;
            if (matcher.IsMatch((ILexer) inputStringLexer))
            {
              int currentIndex2 = inputStringLexer.currentIndex;
              didMatchLexer = true;
              yield return new InputStringMatchInfo()
              {
                startIndex = currentIndex1,
                endIndex = currentIndex2,
                htmlColor = matcher.HTMLColor
              };
              break;
            }
          }
          if (!didMatchLexer)
          {
            int num = (int) __nonvirtual (inputStringLexer.ReadNext());
            __nonvirtual (inputStringLexer.Commit());
          }
        }
      }
    }

    public char ReadNext()
    {
      if (this.EndOfStream)
        return char.MinValue;
      this.previous = this.current;
      this.current = this.inputString[this.currentLookaheadIndex];
      ++this.currentLookaheadIndex;
      return this.current;
    }

    public void Rollback(int amount = -1)
    {
      if (amount == -1)
        this.currentLookaheadIndex = this.currentIndex;
      else if (this.currentLookaheadIndex > this.currentIndex)
        this.currentLookaheadIndex -= amount;
      int index = this.currentLookaheadIndex - 1;
      if (index >= this.inputString.Length)
        this.previous = this.inputString[this.inputString.Length - 1];
      else if (index >= 0)
        this.previous = this.inputString[index];
      else
        this.previous = ' ';
    }

    public void Commit()
    {
      this.currentIndex = this.currentLookaheadIndex;
    }

    public bool IsSpecialSymbol(char character, SpecialCharacterPosition position = SpecialCharacterPosition.Start)
    {
      return position == SpecialCharacterPosition.Start ? this.specialStartSymbols.Contains(character) : this.specialEndSymbols.Contains(character);
    }

    private void ReadWhiteSpace()
    {
      while (char.IsWhiteSpace(this.ReadNext()))
        this.Commit();
      this.Rollback(-1);
    }
  }
}
