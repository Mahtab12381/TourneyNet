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
    public class OrganizerService
    {
        public static List<OrganizerDTO> Get()
        {
            var data = DataAccessFactory.OrganizerData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Organizer, OrganizerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrganizerDTO>>(data);
            return mapped;
        }

        public static OrganizerDTO Get(int id)
        {
            var data = DataAccessFactory.OrganizerData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Organizer, OrganizerDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrganizerDTO>(data);
            return mapped;
        }

        public static OrganizerDTO Create(OrganizerDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Organizer, OrganizerDTO>();
                c.CreateMap<OrganizerDTO, Organizer>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Organizer>(obj);
            var data = DataAccessFactory.OrganizerData().Create(mapped);
            var mapped2 = mapper.Map<OrganizerDTO>(data);
            return mapped2;
        }

        public static OrganizerDTO Update(OrganizerDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Organizer, OrganizerDTO>();
                c.CreateMap<OrganizerDTO, Organizer>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Organizer>(obj);
            var data = DataAccessFactory.OrganizerData().Update(mapped);
            var mapped2 = mapper.Map<OrganizerDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OrganizerData().Delete(id); ;
        }
    }
}
