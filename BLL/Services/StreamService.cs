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
    public class StreamService
    {
        public static List<StreamDTO> Get()
        {
            var data = DataAccessFactory.StreamData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Stream, StreamDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<StreamDTO>>(data);
            return mapped;
        }
        public static StreamDTO Get(int id)
        {
            var data = DataAccessFactory.StreamData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Stream, StreamDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StreamDTO>(data);
            return mapped;
        }

        public static StreamDTO Create(StreamDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Stream, StreamDTO>();
                c.CreateMap<StreamDTO, Stream>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Stream>(obj);
            var data = DataAccessFactory.StreamData().Create(mapped);
            var mapped2 = mapper.Map<StreamDTO>(data);
            return mapped2;
        }

        public static StreamDTO Update(StreamDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Stream, StreamDTO>();
                c.CreateMap<StreamDTO, Stream>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Stream>(obj);
            var data = DataAccessFactory.StreamData().Update(mapped);
            var mapped2 = mapper.Map<StreamDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.StreamData().Delete(id); ;
        }


    }
}
