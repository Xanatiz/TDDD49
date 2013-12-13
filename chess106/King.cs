using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class King : Pieces
    {
        
        public King(int x, int y, Team team)
            : base(x, y, team)
        {
            ;
        }

        override public chessPieces getChessPiece(){
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackKing;
            else
                return chessPieces.WhiteKing;
        }
        override public bool isMovePossible(int toRow, int toColumn)
        {
            return base.getRule().king(getX(), getY(), toColumn, toRow);
        }
    }
}
