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
    public class RegistrationService
    {
        public static List<RegistrationDTO> Get()
        {
            var data = DataAccessFactory.RegistrationData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Registration, RegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RegistrationDTO>>(data);
            return mapped;
        }

        public static RegistrationDTO Get(int id)
        {
            var data = DataAccessFactory.RegistrationData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Registration, RegistrationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RegistrationDTO>(data);
            return mapped;
        }

        public static RegistrationDTO Create(RegistrationDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Registration, RegistrationDTO>();
                c.CreateMap<RegistrationDTO, Registration>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Registration>(obj);
            var data = DataAccessFactory.RegistrationData().Create(mapped);
            var mapped2 = mapper.Map<RegistrationDTO>(data);
            return mapped2;
        }

        public static RegistrationDTO Update(RegistrationDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Registration, RegistrationDTO>();
                c.CreateMap<RegistrationDTO, Registration>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Registration>(obj);
            var data = DataAccessFactory.RegistrationData().Update(mapped);
            var mapped2 = mapper.Map<RegistrationDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.RegistrationData().Delete(id); ;
        }
    }
}
