using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SocialMediaSharingRepo:Repo,IRepo<SocialMediaSharing,int,SocialMediaSharing>
    {
        public SocialMediaSharing Create(SocialMediaSharing obj)
        {
            db.SocialMediaSharings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exp = Read(id);
            db.SocialMediaSharings.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public List<SocialMediaSharing> Read()
        {
            return db.SocialMediaSharings.ToList();
        }

        public SocialMediaSharing Read(int id)
        {
            return db.SocialMediaSharings.Find(id);
        }

        public SocialMediaSharing Update(SocialMediaSharing obj)
        {
            var exp = Read(obj.share_id);
            db.Entry(exp).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
