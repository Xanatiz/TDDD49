using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    public class Pieces
    {
        public int x {get; set;}
        public int y {get; set;}
        public virtual Team team {get; set;}
        public virtual Rules rule { get; set; }

        public Pieces(int y, int x, Team team, Rules rule)
        {
            this.y = y;
            this.x = x;
            this.team = team;
            this.rule = rule;

        }

        public Pieces() { }
        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public Team getTeam()
        {
            return team;
        }
        
        public Rules getRule()
        {
            return rule;
        }

         virtual public chessPieces getChessPiece()
         {
             return chessPieces.None;
         }

         virtual public bool isMovePossible(int fromX, int fromY)
         {
             return false;
         }
    }
}
