using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeamRepo : Repo, IRepo<Team, int, Team>
    {
        public Team Create(Team obj)
        {
            db.Teams.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Teams.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Team> Read()
        {
            return db.Teams.ToList();
        }

        public Team Read(int id)
        {
            return db.Teams.Find(id);
        }

        public Team Update(Team obj)
        {
            var exp = Read(obj.Team_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
