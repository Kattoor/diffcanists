
namespace ChessConsole
{
  public struct ChessMove
  {
    public byte to;
    public byte combined;
    public float time;

    public int from
    {
      get
      {
        return (int) this.combined & 63;
      }
    }

    public PromoteOptions promotion
    {
      get
      {
        return (PromoteOptions) (((int) this.combined & 192) >> 6);
      }
    }

    public void Serialize(myBinaryWriter w)
    {
      w.Write(this.combined);
      w.Write(this.to);
      w.Write(this.time);
    }

    public static ChessMove Deserialize(myBinaryReader r)
    {
      return new ChessMove()
      {
        combined = r.ReadByte(),
        to = r.ReadByte(),
        time = r.ReadSingle()
      };
    }

    public bool Same(ChessMove b)
    {
      return (int) this.combined == (int) b.combined;
    }
  }
}
