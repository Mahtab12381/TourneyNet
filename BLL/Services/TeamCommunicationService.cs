using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Model;

namespace BLL.Services
{
    public class TeamCommunicationService
    {
        public static List<TeamCommunicationDTO> Get()
        {
            var data = DataAccessFactory.TeamCommunicationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TeamCommunication, TeamCommunicationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TeamCommunicationDTO>>(data);
            return mapped;
        }
        public static TeamCommunicationDTO Get(int id)
        {
            var data = DataAccessFactory.TeamCommunicationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TeamCommunication, TeamCommunicationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeamCommunicationDTO>(data);
            return mapped;
        }

        public static TeamCommunicationDTO Create(TeamCommunicationDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TeamCommunication, TeamCommunicationDTO>();
                c.CreateMap<TeamCommunicationDTO, TeamCommunication>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeamCommunication>(obj);
            var data = DataAccessFactory.TeamCommunicationData().Create(mapped);
            var mapped2 = mapper.Map<TeamCommunicationDTO>(data);
            return mapped2;
        }

        public static TeamCommunicationDTO Update(TeamCommunicationDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TeamCommunication, TeamCommunicationDTO>();
                c.CreateMap<TeamCommunicationDTO, TeamCommunication>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeamCommunication>(obj);
            var data = DataAccessFactory.TeamCommunicationData().Update(mapped);
            var mapped2 = mapper.Map<TeamCommunicationDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TeamCommunicationData().Delete(id); ;
        }


    }
}
