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
    public class SocialMediaSharingService
    {
        public static List<SocialMediaSharingDTO> Get()
        {
            var data = DataAccessFactory.SocialMediaSharingData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SocialMediaSharing, SocialMediaSharingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SocialMediaSharingDTO>>(data);
            return mapped;
        }

        public static SocialMediaSharingDTO Get(int id)
        {
            var data = DataAccessFactory.SocialMediaSharingData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SocialMediaSharing, SocialMediaSharingDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SocialMediaSharingDTO>(data);
            return mapped;
        }

        public static SocialMediaSharingDTO Create(SocialMediaSharingDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SocialMediaSharing, SocialMediaSharingDTO>();
                c.CreateMap<SocialMediaSharingDTO, SocialMediaSharing>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SocialMediaSharing>(obj);
            var data = DataAccessFactory.SocialMediaSharingData().Create(mapped);
            var mapped2 = mapper.Map<SocialMediaSharingDTO>(data);
            return mapped2;
        }

        public static SocialMediaSharingDTO Update(SocialMediaSharingDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SocialMediaSharing, SocialMediaSharingDTO>();
                c.CreateMap<SocialMediaSharingDTO, SocialMediaSharing>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SocialMediaSharing>(obj);
            var data = DataAccessFactory.SocialMediaSharingData().Update(mapped);
            var mapped2 = mapper.Map<SocialMediaSharingDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.SocialMediaSharingData().Delete(id); ;
        }
    }
}
