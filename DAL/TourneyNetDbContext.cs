using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourneyNetDbContext:DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
