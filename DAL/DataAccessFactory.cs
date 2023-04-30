﻿using DAL.Interfaces;
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

        public static IRepo<Registration, int, Registration> RegistrationData()
        {
            return new RegistrationRepo();
        }


    }
}
