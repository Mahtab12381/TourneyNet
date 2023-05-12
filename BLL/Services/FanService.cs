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
    public class FanService
    {
        public static List<FanDTO> Get()
        {
            var data = DataAccessFactory.FanData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fan, FanDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FanDTO>>(data);
            return mapped;
        }

        public static FanDTO Get(int id)
        {
            var data = DataAccessFactory.FanData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fan, FanDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FanDTO>(data);
            return mapped;
        }

        public static FanDTO Create(FanDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fan, FanDTO>();
                c.CreateMap<FanDTO, Fan>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Fan>(obj);
            var data = DataAccessFactory.FanData().Create(mapped);
            var mapped2 = mapper.Map<FanDTO>(data);
            return mapped2;
        }

        public static FanDTO Update(FanDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fan, FanDTO>();
                c.CreateMap<FanDTO, Fan>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Fan>(obj);
            var data = DataAccessFactory.FanData().Update(mapped);
            var mapped2 = mapper.Map<FanDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.FanData().Delete(id); ;
        }




    }
}
