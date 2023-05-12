using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ParticipantRepo : Repo, IRepo<Participant, int, Participant>
    {
        public Participant Create(Participant obj)
        {
            db.Participants.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Participants.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Participant> Read()
        {
            return db.Participants.ToList();
        }

        public Participant Read(int id)
        {
            return db.Participants.Find(id);
        }

        public Participant Update(Participant obj)
        {
            var exp = Read(obj.participant_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
