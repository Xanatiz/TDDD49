using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    public class Rules
    {

        static Rules() { ; }
        public Unit unit;


        public Boolean bishop(int fromX, int fromY, int toX, int toY)
        {
            return ((Math.Abs(toX - fromX) == Math.Abs(toY - fromY)));
        }

        public Boolean rook(int fromX, int fromY, int toX, int toY)
        {
            if(!(Math.Abs(toX - fromX) == 0 )|| Math.Abs(toY - fromY) == 0 ) return true;
            if(Math.Abs(toX - fromX) == 0 || !(Math.Abs(toY - fromY) == 0)) return true;
            return false;
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
            int pathX = Math.Abs(toX - fromX);
            int pathY = Math.Abs(toY - fromY);

            Console.WriteLine("X: " + pathX);
            Console.WriteLine("Y: " + pathY);

            if ((pathX == 0) && (pathY == 1)) return true;
            if ((pathX == 1) && (pathY == 0)) return true;
            if ((pathX == 1) && (pathY == 1)) return true;
            return false;
        }

        public Boolean pawn(int fromX, int fromY, int toX, int toY, Team team)
        {
            return true;
            int direction;
            if (team==Team.BLACK)
                direction = 1;
            else
                direction = -1;

            return (toX - fromX == 0 && toY - fromY == direction);
        }

        public Boolean pawnRage(int fromX, int fromY, int toX, int toY, Team team)
        {
            int direction;
            if (team == Team.BLACK)
                direction = 1;
            else
                direction = -1;
            return (toX - fromX == direction && Math.Abs(toY - fromY) == 1);
        }
        
     public Boolean isFreePath(int fromX, int fromY, int toX, int toY)
        {
            int xDirection = (toX - fromX);
            int yDirection = (toY - fromY);
            var startPiece = unit.getUnit(fromY, fromX);


            while (fromX != toX && fromY != toY)
            {
                if (xDirection != 0)  
                    fromX += (xDirection / Math.Abs(xDirection));
                if(yDirection != 0)
                    fromY += (yDirection / Math.Abs(yDirection));

                var testPiece = unit.getUnit(fromX, fromY);


                if( !(unit.sameTeam(unit.getUnit(fromX, fromY), startPiece)))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
