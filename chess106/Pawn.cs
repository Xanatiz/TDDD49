using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Pawn : Pieces
    {
        public Pawn(int y, int x, Team team, Rules rule)
            : base(y, x, team, rule)
        {
            ;
        }

        override public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackPawn;
            else
                return chessPieces.WhitePawn;
        }

        override public bool isMovePossible(int toRow, int toColumn)
        {
            return base.getRule().pawn(getX(), getY(), toColumn, toRow, getTeam());
        }
    }
}
