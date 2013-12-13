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

        public chessPieces getChessPiece(){
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackKing;
            else
                return chessPieces.WhiteKing;
        }
    }
}
