
using System.Collections.Generic;

namespace ChessConsole.Pieces
{
  public class Knight : Piece
  {
    private ChessBoard.Cell[] possibleCells = new ChessBoard.Cell[8];

    public Knight(PlayerColor color)
      : base(color)
    {
      for (int index = 0; index < 8; ++index)
        this.possibleCells[index] = (ChessBoard.Cell) null;
    }

    public Knight(Piece promote)
      : this(promote.Color)
    {
      this.Moved = promote.Moved;
    }

    public override IEnumerable<ChessBoard.Cell> PossibleMoves
    {
      get
      {
        Knight knight = this;
        ChessBoard.Cell[] cellArray = knight.possibleCells;
        for (int index = 0; index < cellArray.Length; ++index)
        {
          ChessBoard.Cell cell = cellArray[index];
          if (cell != null && (cell.Piece == null || cell.Piece.Color != knight.Color))
            yield return cell;
        }
        cellArray = (ChessBoard.Cell[]) null;
      }
    }

    public override void Recalculate()
    {
      this.possibleCells[0] = this.Parent.Open(-1, 2);
      this.possibleCells[1] = this.Parent.Open(-1, -2);
      this.possibleCells[2] = this.Parent.Open(1, 2);
      this.possibleCells[3] = this.Parent.Open(1, -2);
      this.possibleCells[4] = this.Parent.Open(-2, 1);
      this.possibleCells[5] = this.Parent.Open(-2, -1);
      this.possibleCells[6] = this.Parent.Open(2, 1);
      this.possibleCells[7] = this.Parent.Open(2, -1);
      for (int index = 0; index < 8; ++index)
      {
        if (this.possibleCells[index] != null)
          this.possibleCells[index].HitBy.Add((Piece) this);
      }
    }

    public override bool IsBlockedIfMove(
      ChessBoard.Cell from,
      ChessBoard.Cell to,
      ChessBoard.Cell blocked)
    {
      for (int index = 0; index < 8; ++index)
      {
        if (this.possibleCells[index] == blocked)
          return false;
      }
      return true;
    }

    public override ChessPiece Char
    {
      get
      {
        return ChessPiece.Knight;
      }
    }
  }
}
