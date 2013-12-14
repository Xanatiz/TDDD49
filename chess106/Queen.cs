using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Queen : Pieces
    {
        public Queen(int y, int x, Team team)
            : base(y, x, team)
        {
            ;
        }
        override public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackQueen;
            else
                return chessPieces.WhiteQueen;
        }
        override public bool isMovePossible(int toRow, int toColumn)
        {
            return base.getRule().queen(getX(), getY(), toColumn, toRow);
        }
    }
}
