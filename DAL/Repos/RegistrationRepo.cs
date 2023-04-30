﻿using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RegistrationRepo : Repo, IRepo<Registration, int, Registration>
    {
        public Registration Create(Registration obj)
        {
            db.Registrations.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Registrations.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Registration> Read()
        {
            return db.Registrations.ToList();
        }

        public Registration Read(int id)
        {
            return db.Registrations.Find(id);
        }

        public Registration Update(Registration obj)
        {
            var exp = Read(obj.Id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
