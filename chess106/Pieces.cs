using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    public class Pieces
    {
        private Rules rule = new Rules();
        private int x;
        private int y;
        private Team team;
        private bool alive;
        public Pieces(int x, int y, Team team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
            this.alive = true;
        }
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
        
        public bool isAlive()
        {
            return alive;
        }

        public void kill()
        {
            alive = false;
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
