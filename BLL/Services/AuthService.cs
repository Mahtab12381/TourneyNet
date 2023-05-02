using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var res= DataAccessFactory.AuthData().Authenticate(username,password);
            var extTokenAvailable = DataAccessFactory.AuthData().HasExtToken(username);

            if (res)
            {
                if (!extTokenAvailable)
                {
                    var token = new Token();
                    token.User_id = username;
                    token.Created_at = DateTime.Now;
                    token.Token_key = Guid.NewGuid().ToString();
                    var ret = DataAccessFactory.TokenData().Create(token);
                    if (ret != null)
                    {
                        var cfg = new MapperConfiguration(c =>
                        {
                            c.CreateMap<Token, TokenDTO>();
                        });
                        var mapper = new Mapper(cfg);
                        var mapped = mapper.Map<TokenDTO>(ret);
                        return mapped;
                    }
                }
                else
                {

                }
              

            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            var extTojen= DataAccessFactory.TokenData().Read(token);
            if(extTojen != null && extTojen.deleted_at == null)
            {
                return true;
            }
            return false;
        }

        public static bool Logout(string token)
        {
            var extTojen = DataAccessFactory.TokenData().Read(token);
            extTojen.deleted_at = DateTime.Now;
            if (DataAccessFactory.TokenData().Update(extTojen) != null)
            {
                return true;
            }
            return false;
        }
    }
}
