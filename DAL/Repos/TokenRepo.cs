using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, string, Token>
    {
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var exp = Read(id);
            db.Tokens.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<Token> Read()
        {
            return db.Tokens.ToList();
        }

        public Token Read(string id)
        {
            return db.Tokens.FirstOrDefault(t => t.Token_key.Equals(id));
        }

        public Token Update(Token obj)
        {
            var exp = Read(obj.Token_key);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
