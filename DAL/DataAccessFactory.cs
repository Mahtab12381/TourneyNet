using DAL.Interfaces;
using DAL.Model;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Player,int,Player> PlayerData()
        {
            return new PlayerRepo();
        }


        public static IRepo<Fan, int, Fan> FanData()
        {
            return new FanRepo();
        }

        public static IRepo<FanPost, int, FanPost> FanPostData()
        {
            return new FanPostRepo();
        }

        public static IRepo<Payment, int, Payment> PaymentData()
        {
            return new PaymentRepo();
        }

        public static IRepo<Ranking, int, Ranking> RankingData()
        {
            return new RankingRepo();
        }

        public static IRepo<Tournament, int, Tournament> TournamentData()
        {
            return new TournamentRepo();
        }

        public static IRepo<Registration, int, Registration> RegistrationData()
        {
            return new RegistrationRepo();
        }

        public static IRepo<Organizer, int, Organizer> OrganizerData()
        {
            return new OrganizerRepo();
        }


        public static IRepo<Event, int, Event> EventData()
        {
            return new EventRepo();
        }
        public static IRepo<Participant, int, Participant> ParticipantData()
        {
            return new ParticipantRepo();
        }
        public static IRepo<SocialMediaSharing, int, SocialMediaSharing> SocialMediaSharingData()
        {
            return new SocialMediaSharingRepo();
        }

        public static IRepo<PlayerGame, int, PlayerGame> PlayerGameData()
        {
            return new PlayerGameRepo();
        }

        public static IAuth<Token> AuthData()
        {
            return new RegistrationRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
    }
}
