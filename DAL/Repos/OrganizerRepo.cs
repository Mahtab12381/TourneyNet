using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrganizerRepo : Repo, IRepo<Organizer, int, Organizer>
    {
        public Organizer Create(Organizer obj)
        {
            db.Organizers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Organizers.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Organizer> Read()
        {
            return db.Organizers.ToList();
        }

        public Organizer Read(int id)
        {
            return db.Organizers.Find(id);
        }

        public Organizer Update(Organizer obj)
        {
            var exp = Read(obj.Organizer_Id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
