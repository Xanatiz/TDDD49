using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Pawn : Pieces
    {
        public Pawn(int x, int y, Team team)
            : base(x, y, team)
        {
            ;
        }
        public chessPieces getChessPiece()
        {
            if (getTeam() == Team.BLACK)
                return chessPieces.BlackPawn;
            else
                return chessPieces.WhitePawn;
        }
    }
}
