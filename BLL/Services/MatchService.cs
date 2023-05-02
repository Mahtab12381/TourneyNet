using AutoMapper;
using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace BLL.Services
{
    public class MatchService
    {
        public static List<MatchDTO> Get()
        {
            var data = DataAccessFactory.MatchData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Match, MatchDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MatchDTO>>(data);
            return mapped;
        }
        public static MatchDTO Get(int id)
        {
            var data = DataAccessFactory.MatchData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Match, MatchDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MatchDTO>(data);
            return mapped;
        }

        public static MatchDTO Create(MatchDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Match, MatchDTO>();
                c.CreateMap<MatchDTO, Match>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Match>(obj);
            var data = DataAccessFactory.MatchData().Create(mapped);
            var mapped2 = mapper.Map<MatchDTO>(data);
            return mapped2;
        }

        public static MatchDTO Update(MatchDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Match, MatchDTO>();
                c.CreateMap<MatchDTO, Match>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Match>(obj);
            var data = DataAccessFactory.MatchData().Update(mapped);
            var mapped2 = mapper.Map<MatchDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.MatchData().Delete(id); ;
        }


    }
}
