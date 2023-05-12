using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeamCommunicationRepo : Repo, IRepo<TeamCommunication, int, TeamCommunication>
    {
        public TeamCommunication Create(TeamCommunication obj)
        {
            db.TeamCommunications.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.TeamCommunications.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<TeamCommunication> Read()
        {
            return db.TeamCommunications.ToList();
        }

        public TeamCommunication Read(int id)
        {
            return db.TeamCommunications.Find(id);
        }

        public TeamCommunication Update(TeamCommunication obj)
        {
            var exp = Read(obj.Communication_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
