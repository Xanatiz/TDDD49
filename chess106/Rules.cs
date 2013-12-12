using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class Rules
    {

        public Boolean bishop(int fromX, int fromY, int toX, int toY)
        {
            int deltaY = Math.Abs(toY - fromY);
            if(Math.Abs(toY - fromY)==0)
                return false;

            return ((Math.Abs(toX - fromX) / Math.Abs(toY - fromY)) == 1);
        }

        public Boolean rook(int fromX, int fromY, int toX, int toY)
        {
            return (Math.Abs(toX - fromX) == 0 || Math.Abs(toY - fromY) == 0);
        }

        public Boolean queen(int fromX, int fromY, int toX, int toY)
        {
            return (rook(fromX, fromY, toX, toY) || bishop(fromX, fromY, toX, toY));
        }

        public Boolean knight(int fromX, int fromY, int toX, int toY)
        {
            int pathX = toX - fromX;
            int pathY = toY - fromY;
            return ((Math.Abs(pathX) == 2 && Math.Abs(pathY) == 1) || (Math.Abs(pathX) == 1 && Math.Abs(pathY) == 2));

        }

        public Boolean king(int fromX, int fromY, int toX, int toY)
        {
            int pathX = toX - fromX;
            int pathY = toY - fromY;
            return ((Math.Abs(pathX) == 1 && (Math.Abs(pathY) == 0 || Math.Abs(pathY) == 1)) || (Math.Abs(pathY) == 1) && (Math.Abs(pathX) == 0 || Math.Abs(pathX) == 1));
        }

        public Boolean pawn(int fromX, int fromY, int toX, int toY, int direction)
        {
            return (toX - fromX == direction && toY - fromY == 0);
        }

        public Boolean pawnRage(int fromX, int fromY, int toX, int toY, int direction)
        {
            return (toX - fromX == direction && Math.Abs(toY - fromY) == 1);
        }

    }
}
