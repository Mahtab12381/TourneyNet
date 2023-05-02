using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StreamRepo : Repo, IRepo<Stream, int, Stream>
    {
        public Stream Create(Stream obj)
        {
            db.Streams.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Streams.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Stream> Read()
        {
            return db.Streams.ToList();
        }

        public Stream Read(int id)
        {
            return db.Streams.Find(id);
        }

        public Stream Update(Stream obj)
        {
            var exp = Read(obj.Stream_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
