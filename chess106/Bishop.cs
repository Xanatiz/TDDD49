using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Bishop : Pieces
    { 
        public Bishop(int y, int x, Team team)
            : base(y, x, team)
        {
            ;
        }

        override public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackBishop;
            else
                return chessPieces.WhiteBishop;
        }

        override public bool isMovePossible(int toRow, int toColumn)
        {

            return base.getRule().bishop(getX(), getY(), toColumn, toRow);
        }
    }
}
