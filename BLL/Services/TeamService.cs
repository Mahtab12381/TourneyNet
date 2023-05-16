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
    public class TeamService
    {
        public static List<TeamDTO> Get()
        {
            var data = DataAccessFactory.TeamData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Team, TeamDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TeamDTO>>(data);
            return mapped;
        }
        public static TeamDTO Get(int id)
        {
            var data = DataAccessFactory.TeamData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Team, TeamDTO>();
         
                c.CreateMap<TeamCommunication,TeamCommunicationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeamDTO>(data);
            return mapped;
        }

        public static TeamDTO Create(TeamDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Team, TeamDTO>();
                c.CreateMap<TeamDTO, Team>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Team>(obj);
            var data = DataAccessFactory.TeamData().Create(mapped);
            var mapped2 = mapper.Map<TeamDTO>(data);
            return mapped2;
        }

        public static TeamDTO Update(TeamDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Team, TeamDTO>();
                c.CreateMap<TeamDTO, Team>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Team>(obj);
            var data = DataAccessFactory.TeamData().Update(mapped);
            var mapped2 = mapper.Map<TeamDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TeamData().Delete(id); ;
        }


    }
}
