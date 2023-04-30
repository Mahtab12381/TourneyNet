using DAL.Interfaces;
using DAL.Model;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Player,int,Player> PlayerData()
        {
            return new PlayerRepo();
        }


        public static IRepo<Fan, int, Fan> FanData()
        {
            return new FanRepo();
        }

<<<<<<< HEAD
        public static IRepo<Registration, int, Registration> RegistrationData()
        {
            return new RegistrationRepo();
=======
        public static IRepo<FanPost, int, FanPost> FanPostData()
        {
            return new FanPostRepo();
>>>>>>> c306a5ddb04bf0e36e8071b942192d7c993a20be
        }


    }
}
