using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FanPostRepo : Repo, IRepo<FanPost, int, FanPost>
    {
        public FanPost Create(FanPost obj)
        {
            db.FanPosts.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.FanPosts.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<FanPost> Read()
        {
            return db.FanPosts.ToList();
        }

        public FanPost Read(int id)
        {
            return db.FanPosts.Find(id);
        }

        public FanPost Update(FanPost obj)
        {
            var exp = Read(obj.FanPost_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
