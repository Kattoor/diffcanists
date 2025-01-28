
using System.Collections.Generic;

namespace ChessConsole.Pieces
{
  public class Queen : Piece
  {
    private Direction[] directions = new Direction[8];

    public Queen(PlayerColor color)
      : base(color)
    {
      for (int index = 0; index < 8; ++index)
        this.directions[index] = (Direction) null;
    }

    public Queen(Piece promote)
      : this(promote.Color)
    {
      this.Moved = promote.Moved;
    }

    public override IEnumerable<ChessBoard.Cell> PossibleMoves
    {
      get
      {
        Direction[] directionArray = this.directions;
        for (int index = 0; index < directionArray.Length; ++index)
        {
          foreach (ChessBoard.Cell possibleMove in directionArray[index].GetPossibleMoves(true))
            yield return possibleMove;
        }
        directionArray = (Direction[]) null;
      }
    }

    public override void Recalculate()
    {
      this.directions[0] = new Direction((Piece) this, 0, 1, 8, true);
      this.directions[1] = new Direction((Piece) this, 0, -1, 8, true);
      this.directions[2] = new Direction((Piece) this, -1, 0, 8, true);
      this.directions[3] = new Direction((Piece) this, 1, 0, 8, true);
      this.directions[4] = new Direction((Piece) this, -1, 1, 8, true);
      this.directions[5] = new Direction((Piece) this, 1, 1, 8, true);
      this.directions[6] = new Direction((Piece) this, -1, -1, 8, true);
      this.directions[7] = new Direction((Piece) this, 1, -1, 8, true);
    }

    public override bool IsBlockedIfMove(
      ChessBoard.Cell from,
      ChessBoard.Cell to,
      ChessBoard.Cell blocked)
    {
      foreach (Direction direction in this.directions)
      {
        if (!direction.IsBlockedIfMove(from, to, blocked))
          return false;
      }
      return true;
    }

    public override ChessPiece Char
    {
      get
      {
        return ChessPiece.Queen;
      }
    }
  }
}
