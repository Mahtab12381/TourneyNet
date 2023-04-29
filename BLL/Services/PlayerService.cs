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
    public class PlayerService
    {
        public static List<PlayerDTO> Get() {
            var data = DataAccessFactory.PlayerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Player,PlayerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PlayerDTO>>(data);
            return mapped;
        }

        public static PlayerDTO Get(int id) {
            var data = DataAccessFactory.PlayerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Player, PlayerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PlayerDTO>(data);
            return mapped;
        }

        public static PlayerDTO Create(PlayerDTO obj)
        {  
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Player, PlayerDTO>();
                c.CreateMap<PlayerDTO, Player>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Player>(obj);
            var data = DataAccessFactory.PlayerData().Create(mapped);
            var mapped2 = mapper.Map<PlayerDTO>(data);
            return mapped2;
        }

        public static PlayerDTO Update(PlayerDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Player, PlayerDTO>();
                c.CreateMap<PlayerDTO, Player>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Player>(obj);
            var data = DataAccessFactory.PlayerData().Update(mapped);
            var mapped2 = mapper.Map<PlayerDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PlayerData().Delete(id); ;
        }
    }
}
