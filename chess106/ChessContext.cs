using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace chess106
{
    public class ChessContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }
        public DbSet<Pieces> Pieces { get; set; }
    }
}
