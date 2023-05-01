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

        public DbSet<Fan> Fans { get; set; }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<FanPost> FanPosts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Stream> Streams { get; set; }
    }
}
