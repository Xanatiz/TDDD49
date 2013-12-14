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
        Unit unit = new Unit();
        
        public Boolean bishop(int fromX, int fromY, int toX, int toY)
        {
            return ((Math.Abs(toX - fromX) == Math.Abs(toY - fromY)));
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
            return ((Math.Abs(toX - fromX) == 2 && Math.Abs(toY - fromY) == 1) || (Math.Abs(toX - fromX) == 1 && Math.Abs(toY - fromY) == 2));
        }

        public Boolean king(int fromX, int fromY, int toX, int toY)
        {
            if (!unit.sameTeam(unit.getUnit(fromY, fromX), unit.getUnit(toY, toX)))
                return (((Math.Abs(toX - fromX) + Math.Abs(toY - fromY)) == 2) ||((Math.Abs(toX - fromX) + Math.Abs(toY - fromY)) == 1));
            return false;
        }

        public Boolean pawn(int fromX, int fromY, int toX, int toY, Team team)
        {
            int direction;
            bool startPosition = false;
            if (team == Team.BLACK)
            {
                direction = 1;
                startPosition = (fromY == 1);
            }
            else
            {
                direction = -1;
                startPosition = (fromY == 6);
            }
            if (unit.isOppositeTeam(unit.getUnit(fromY, fromX), unit.getUnit(toY, toX)))
                return pawnRage(fromX, fromY, toX, toY, direction);
            else
            {
                if (startPosition && isFreePath(fromX, fromY, toX, toY))
                    return (toX - fromX == 0 && ((toY - fromY == direction) || toY - fromY == direction * 2));
                return (toX - fromX == 0 && toY - fromY == direction);
            }
        }

        public Boolean pawnRage(int fromX, int fromY, int toX, int toY, int direction)
        {
            return (Math.Abs(toX - fromX) == 1 && toY - fromY == direction);
        }
        
     public Boolean isFreePath(int fromX, int fromY, int toX, int toY)
        {
            int xDirection = (toX - fromX);
            int yDirection = (toY - fromY);
            //var startPiece = unit.getUnit(fromY, fromX);

            for (int i = 0; i <= xDirection; i++)
            {
                if (xDirection != 0)
                    fromX += (xDirection / Math.Abs(xDirection));
                if (yDirection != 0)
                    fromY += (yDirection / Math.Abs(yDirection));
                if (unit.getUnit(fromX, fromY).getTeam() != Team.NONE)
                    return false;
            }
            return true;
               /* while (fromX != toX && fromY != toY)
                {
                    if (xDirection != 0)
                        fromX += (xDirection / Math.Abs(xDirection));
                    if (yDirection != 0)
                        fromY += (yDirection / Math.Abs(yDirection));

                    var testPiece = unit.getUnit(fromX, fromY);


                    if (!(unit.sameTeam(unit.getUnit(fromX, fromY), startPiece)))
                    {
                        return false;
                    }

                }
            return true;*/
        }
    }
}
