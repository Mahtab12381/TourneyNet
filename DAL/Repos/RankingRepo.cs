using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RankingRepo : Repo, IRepo<Ranking, int, Ranking>
    {
        public Ranking Create(Ranking obj)
        {
            db.Rankings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Rankings.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Ranking> Read()
        {
            return db.Rankings.ToList();
        }

        public Ranking Read(int id)
        {
            return db.Rankings.Find(id);
        }

        public Ranking Update(Ranking obj)
        {
            var exp = Read(obj.ranking_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
