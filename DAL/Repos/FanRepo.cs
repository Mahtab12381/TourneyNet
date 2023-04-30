using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FanRepo : Repo, IRepo<Fan, int, Fan>
    {
        public Fan Create(Fan obj)
        {
            db.Fans.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {

            var exp = Read(id);
            db.Fans.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Fan> Read()
        {
            return db.Fans.ToList();
        }

        public Fan Read(int id)
        {
            return db.Fans.Find(id);
        }

        public Fan Update(Fan obj)
        {
            var exp = Read(obj.Id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
