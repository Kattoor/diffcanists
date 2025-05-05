
using System;
using System.Collections.Generic;

#nullable disable
[Serializable]
public class SpellsOnly
{
  public const byte _version = 2;
  public byte[] spells = new byte[16]
  {
    (byte) 0,
    (byte) 1,
    (byte) 2,
    (byte) 3,
    (byte) 4,
    (byte) 5,
    (byte) 6,
    (byte) 7,
    (byte) 8,
    (byte) 9,
    (byte) 10,
    (byte) 11,
    (byte) 12,
    (byte) 13,
    (byte) 14,
    (byte) 15
  };
  public byte fullBook;
  public int altBooks;

  public BookOf Elemental => (BookOf) ((int) this.fullBook - 1);

  public bool UsingAltBook(BookOf b) => (this.altBooks & 1 << (int) (b & (BookOf) 31) & 1056) != 0;

  public void ToggleAlt(BookOf b, bool v)
  {
    if (v)
      this.altBooks |= 1 << (int) (b & (BookOf) 31);
    else
      this.altBooks &= ~(1 << (int) (b & (BookOf) 31));
  }

  public bool SeasonsIsHoliday
  {
    get => this.UsingAltBook(BookOf.Seasons);
    set => this.ToggleAlt(BookOf.Seasons, value);
  }

  public bool IsAlt(int spellIndex)
  {
    return spellIndex < (int) byte.MaxValue && spellIndex >= 0 && this.UsingAltBook((BookOf) (spellIndex / 12)) && Inert.Instance.altSpells.Length > spellIndex && (UnityEngine.Object) Inert.Instance.altSpells[spellIndex] != (UnityEngine.Object) null;
  }

  public static SpellsOnly Deserialize(myBinaryReader r)
  {
    SpellsOnly spellsOnly = new SpellsOnly();
    spellsOnly.fullBook = r.ReadByte();
    if (r.ReadByte() < (byte) 2)
    {
      byte num = r.ReadByte();
      spellsOnly.altBooks |= ((int) num & 1) != 0 ? 1024 : 0;
    }
    else
      spellsOnly.altBooks = r.ReadInt32();
    for (int index = 0; index < 16; ++index)
      spellsOnly.spells[index] = r.ReadByte();
    return spellsOnly;
  }

  public static SpellsOnly OLDDeserialize(myBinaryReader r)
  {
    SpellsOnly spellsOnly = new SpellsOnly();
    spellsOnly.fullBook = r.ReadByte();
    for (int index = 0; index < 16; ++index)
      spellsOnly.spells[index] = r.ReadByte();
    return spellsOnly;
  }

  public void Serialize(myBinaryWriter w)
  {
    w.Write(this.fullBook);
    w.Write((byte) 2);
    w.Write(this.altBooks);
    for (int index = 0; index < 16; ++index)
      w.Write(this.spells[index]);
  }

  public SpellsOnly Copy(SettingsPlayer b)
  {
    this.fullBook = b.fullBook;
    this.altBooks = b.altBooks;
    for (int index = 0; index < 16; ++index)
      this.spells[index] = b.spells[index];
    return this;
  }

  private void DefaultSpells()
  {
    this.spells = new byte[16]
    {
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 4,
      (byte) 5,
      (byte) 6,
      (byte) 7,
      (byte) 8,
      (byte) 9,
      (byte) 10,
      (byte) 11,
      (byte) 12,
      (byte) 13,
      (byte) 14,
      (byte) 15
    };
  }

  public void VerifySpells()
  {
    HashSet<byte> byteSet = new HashSet<byte>();
    int[] numArray = new int[(int) (RandomExtensions.LastBook() + 1)];
    for (int index1 = 0; index1 < 16; ++index1)
    {
      byte spell = this.spells[index1];
      int index2 = (int) spell / 12;
      if (index2 < 0 || index2 >= numArray.Length)
      {
        this.spells[index1] = byte.MaxValue;
      }
      else
      {
        int num = (int) spell % 12;
        if (num < 10)
        {
          if (num % 2 == 1 && spell >= (byte) 12 && (index1 == 0 || (int) this.spells[index1 - 1] != (int) spell - 1))
          {
            this.DefaultSpells();
            break;
          }
        }
        else if (index2 > 0 && numArray[index2] < 5)
        {
          this.DefaultSpells();
          break;
        }
        if (byteSet.Contains(spell))
        {
          this.DefaultSpells();
          break;
        }
        ++numArray[index2];
        byteSet.Add(spell);
      }
    }
  }
}
