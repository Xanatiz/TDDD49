using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Knight : Pieces
    {
        public Knight(int x, int y, Team team)
            : base(x, y, team)
        {
            ;
        }
        public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackKnight;
            else
                return chessPieces.WhiteKnight;
        }
    }
}
