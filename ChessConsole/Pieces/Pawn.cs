
using System.Collections.Generic;

namespace ChessConsole.Pieces
{
  public class Pawn : Piece
  {
    private ChessBoard.Cell[] hits = new ChessBoard.Cell[2];
    private Direction forward;

    public Pawn(PlayerColor color)
      : base(color)
    {
      this.hits[0] = this.hits[1] = (ChessBoard.Cell) null;
    }

    public override IEnumerable<ChessBoard.Cell> PossibleMoves
    {
      get
      {
        Pawn pawn = this;
        foreach (ChessBoard.Cell possibleMove in pawn.forward.GetPossibleMoves(false))
          yield return possibleMove;
        if (pawn.canHit(pawn.hits[0]))
          yield return pawn.hits[0];
        if (pawn.canHit(pawn.hits[1]))
          yield return pawn.hits[1];
      }
    }

    public override void Recalculate()
    {
      this.forward = new Direction((Piece) this, 0, this.Color == PlayerColor.White ? 1 : -1, this.Moved ? 1 : 2, false);
      this.hits[0] = this.Parent.Open(-1, this.Color == PlayerColor.White ? 1 : -1);
      this.hits[1] = this.Parent.Open(1, this.Color == PlayerColor.White ? 1 : -1);
      if (this.hits[0] != null)
        this.hits[0].HitBy.Add((Piece) this);
      if (this.hits[1] == null)
        return;
      this.hits[1].HitBy.Add((Piece) this);
    }

    public override bool IsBlockedIfMove(
      ChessBoard.Cell from,
      ChessBoard.Cell to,
      ChessBoard.Cell blocked)
    {
      return this.hits[0] != blocked && this.hits[1] != blocked;
    }

    public override ChessPiece Char
    {
      get
      {
        return ChessPiece.Pawn;
      }
    }

    protected override bool canHit(ChessBoard.Cell cell)
    {
      if (base.canHit(cell))
        return true;
      return cell != null && cell == cell.Parent.EnPassant;
    }
  }
}
