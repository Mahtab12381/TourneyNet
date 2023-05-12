using DAL.Model;
using DAL.Repos;
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
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Stream> Streams { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<SocialMediaSharing> SocialMediaSharings { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<PlayerGame> PlayerGames { get; set; }
        public DbSet<Token> Tokens { get; set; }

        
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamCommunication> TeamCommunications { get; set; }
        public DbSet<Match> Matches { get; set; }

    }
}
