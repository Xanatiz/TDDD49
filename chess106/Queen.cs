using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Queen : Pieces
    {
        public Queen(int x, int y, Team team)
            : base(x, y, team)
        {
            ;
        }
        public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackQueen;
            else
                return chessPieces.WhiteQueen;
        }
    }
}
