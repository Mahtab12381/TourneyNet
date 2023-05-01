using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EventRepo:Repo,IRepo<Event,int,Event>
    {
        public Event Create(Event obj)
        {
            db.Events.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Events.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Event> Read()
        {
            return db.Events.ToList();
        }

        public Event Read(int id)
        {
            return db.Events.Find(id);
        }

        public Event Update(Event obj)
        {
            var exp = Read(obj.event_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
