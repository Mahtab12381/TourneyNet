using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TournamentService
    {
        public static List<TournamentDTO> Get()
        {
            var data = DataAccessFactory.TournamentData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tournament, TournamentDTO>();
                c.CreateMap<Registration, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TournamentDTO>>(data);
            return mapped;
        }

        public static TournamentsDetailsDTO Get(int id)
        {
            var data = DataAccessFactory.TournamentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tournament, TournamentDTO>();
                c.CreateMap<Tournament, TournamentsDetailsDTO>();
              c.CreateMap<Registration, UserDTO>();
              c.CreateMap<Participant, ParticipantDTO>();
              c.CreateMap<Match, MatchDTO>();
              c.CreateMap<Ranking, RankingDTO>();

   
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TournamentsDetailsDTO>(data);
            return mapped;
        }

        public static TournamentDTO Create(TournamentDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tournament, TournamentDTO>();
                c.CreateMap<TournamentDTO, Tournament>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Tournament>(obj);
            var data = DataAccessFactory.TournamentData().Create(mapped);
            var mapped2 = mapper.Map<TournamentDTO>(data);
            return mapped2;
        }

        public static TournamentDTO Update(TournamentDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tournament, TournamentDTO>();
                c.CreateMap<TournamentDTO, Tournament>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Tournament>(obj);
            var data = DataAccessFactory.TournamentData().Update(mapped);
            var mapped2 = mapper.Map<TournamentDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TournamentData().Delete(id); ;
        }

    }
}
