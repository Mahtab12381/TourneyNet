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
    public class ParticipantService
    {
        public static List<ParticipantDTO> Get()
        {
            var data = DataAccessFactory.ParticipantData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Participant, ParticipantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ParticipantDTO>>(data);
            return mapped;
        }

        public static ParticipantDTO Get(int id)
        {
            var data = DataAccessFactory.ParticipantData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Participant, ParticipantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ParticipantDTO>(data);
            return mapped;
        }

        public static ParticipantDTO Create(ParticipantDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Participant, ParticipantDTO>();
                c.CreateMap<ParticipantDTO, Participant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Participant>(obj);
            var data = DataAccessFactory.ParticipantData().Create(mapped);
            var mapped2 = mapper.Map<ParticipantDTO>(data);
            return mapped2;
        }

        public static ParticipantDTO Update(ParticipantDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Participant, ParticipantDTO>();
                c.CreateMap<ParticipantDTO, Participant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Participant>(obj);
            var data = DataAccessFactory.ParticipantData().Update(mapped);
            var mapped2 = mapper.Map<ParticipantDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ParticipantData().Delete(id); ;
        }
    }
}
