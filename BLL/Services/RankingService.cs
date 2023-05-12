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
    public class RankingService
    {
        public static List<RankingDTO> Get()
        {
            var data = DataAccessFactory.RankingData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Ranking, RankingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RankingDTO>>(data);
            return mapped;
        }

        public static RankingDTO Get(int id)
        {
            var data = DataAccessFactory.RankingData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Ranking, RankingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RankingDTO>(data);
            return mapped;
        }

        public static RankingDTO Create(RankingDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Ranking, RankingDTO>();
                c.CreateMap<RankingDTO, Ranking>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Ranking>(obj);
            var data = DataAccessFactory.RankingData().Create(mapped);
            var mapped2 = mapper.Map<RankingDTO>(data);
            return mapped2;
        }

        public static RankingDTO Update(RankingDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Ranking, RankingDTO>();
                c.CreateMap<RankingDTO, Ranking>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Ranking>(obj);
            var data = DataAccessFactory.RankingData().Update(mapped);
            var mapped2 = mapper.Map<RankingDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.RankingData().Delete(id); ;
        }

    }
}
