using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PlayerRepo : Repo, IRepo<Player, int, Player>
    {
        public Player Create(Player obj)
        {
           db.Players.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.Players.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Player> Read()
        {
            return db.Players.ToList(); 
        }

        public Player Read(int id)
        {
            return db.Players.Find(id);
        }

        public Player Update(Player obj)
        {
            var exp = Read(obj.player_Id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
