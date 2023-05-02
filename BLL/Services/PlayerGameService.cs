using AutoMapper;
using BLL.DTOs;
using DAL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PlayerGameService
    {
        public static List<PlayerGameDTO> Get()
        {
            var data = DataAccessFactory.PlayerGameData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlayerGame, PlayerGameDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PlayerGameDTO>>(data);
            return mapped;
        }

        public static PlayerGameDTO Get(int id)
        {
            var data = DataAccessFactory.PlayerGameData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlayerGame, PlayerGameDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PlayerGameDTO>(data);
            return mapped;
        }

        public static PlayerGameDTO Create(PlayerGameDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlayerGame, PlayerGameDTO>();
                c.CreateMap<PlayerGameDTO, PlayerGame>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PlayerGame>(obj);
            var data = DataAccessFactory.PlayerGameData().Create(mapped);
            var mapped2 = mapper.Map<PlayerGameDTO>(data);
            return mapped2;
        }

        public static PlayerGameDTO Update(PlayerGameDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlayerGame, PlayerGameDTO>();
                c.CreateMap<PlayerGameDTO, PlayerGame>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PlayerGame>(obj);
            var data = DataAccessFactory.PlayerGameData().Update(mapped);
            var mapped2 = mapper.Map<PlayerGameDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PlayerGameData().Delete(id); ;
        }
    }
}
