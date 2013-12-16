using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chess106
{
    class Rook : Pieces
    {

        public Rook(int y, int x, Team team)
            : base(y, x, team)
        {
            ;
        }

        override public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackRook;
            else
                return chessPieces.WhiteRook;
        }

        override public bool isMovePossible(int toRow, int toColumn)
        {
            return base.getRule().rook(getX(), getY(), toColumn, toRow);    
        }
    }
}
