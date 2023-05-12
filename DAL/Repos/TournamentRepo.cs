using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TournamentRepo : Repo, IRepo<Tournament, int, Tournament>
    {
        public Tournament Create(Tournament obj)
        {
            db.Tournaments.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Tournaments.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Tournament> Read()
        {
            return db.Tournaments.ToList();
        }

        public Tournament Read(int id)
        {
            return db.Tournaments.Find(id);
        }

        public Tournament Update(Tournament obj)
        {
            var exp = Read(obj.tournament_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
