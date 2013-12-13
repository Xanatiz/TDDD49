using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess106
{
    class BlackTeam
    {
        King king;
        public BlackTeam()
        {
            this.king = new King(0, 4, Team.BLACK);
        }
    }
}
