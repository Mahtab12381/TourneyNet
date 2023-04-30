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
<<<<<<< HEAD

        public DbSet<Registration> Registrations { get; set; }
=======
        public DbSet<FanPost> FanPosts { get; set; }
>>>>>>> c306a5ddb04bf0e36e8071b942192d7c993a20be
    }
}
