using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Knight : Pieces
    {
        public Knight(int y, int x, Team team)
            : base(y, x, team)
        {
            ;
        }

        override public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackKnight;
            else
                return chessPieces.WhiteKnight;
        }

        override public bool isMovePossible(int toRow, int toColumn)
        {
            return base.getRule().knight(getX(), getY(), toColumn, toRow);
        }
    }
}
