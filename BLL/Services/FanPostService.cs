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
    public class FanPostService
    {
        public static List<FanPostDTO> Get()
        {
            var data = DataAccessFactory.FanPostData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FanPost, FanPostDTO>();
                c.CreateMap<Registration, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<FanPostDTO>>(data);
            return mapped;
        }

        public static FanPostDTO Get(int id)
        {
            var data = DataAccessFactory.FanPostData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FanPost, FanPostDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FanPostDTO>(data);
            return mapped;
        }

        public static FanPostDTO Create(FanPostDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FanPost, FanPostDTO>();
                c.CreateMap<FanPostDTO, FanPost>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FanPost>(obj);
            var data = DataAccessFactory.FanPostData().Create(mapped);
            var mapped2 = mapper.Map<FanPostDTO>(data);
            return mapped2;
        }

        public static FanPostDTO Update(FanPostDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FanPost, FanPostDTO>();
                c.CreateMap<FanPostDTO, FanPost>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FanPost>(obj);
            var data = DataAccessFactory.FanPostData().Update(mapped);
            var mapped2 = mapper.Map<FanPostDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.FanPostData().Delete(id); ;
        }
    }
}
