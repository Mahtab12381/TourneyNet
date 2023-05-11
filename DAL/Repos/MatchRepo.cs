using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MatchRepo : Repo, IRepo<Match, int, Match>
    {
        public Match Create(Match obj)
        {
            db.Matches.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Matches.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Match> Read()
        {
            return db.Matches.ToList();
        }

        public Match Read(int id)
        {
            return db.Matches.Find(id);
        }

        public Match Update(Match obj)
        {
            var exp = Read(obj.Match_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
