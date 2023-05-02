using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PlayerGameRepo : Repo, IRepo<PlayerGame, int, PlayerGame>
    {
        public PlayerGame Create(PlayerGame obj)
        {
            db.PlayerGames.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.PlayerGames.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<PlayerGame> Read()
        {
            return db.PlayerGames.ToList();
        }

        public PlayerGame Read(int id)
        {
            return db.PlayerGames.Find(id);
        }

        public PlayerGame Update(PlayerGame obj)
        {
            var exp = Read(obj.Player_Game_Id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
