using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RegistrationRepo : Repo, IRepo<Registration, int, Registration>,IAuth<Token>,IRegi<Registration,string>
    {
        public bool Authenticate(string username, string password)
        {
            var data = (from d in db.Registrations where d.UserName.Equals(username) && d.Password.Equals(password) select d).SingleOrDefault();
            if (data != null) return true;
            return false;
        }
        public Token HasExtToken(string Username)
        {
            var extToken = (from t in db.Tokens where t.User_id.Equals(Username) && t.deleted_at == null select t).SingleOrDefault();
            if (extToken != null) return extToken;
            return null;
        }


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

        public Registration Read(string id)
        {
            var extreg=(from r in db.Registrations where r.UserName.Equals(id) select r).SingleOrDefault();
            return extreg;
        }
    }
}
