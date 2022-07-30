using DALL.EF;
using DALL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Repo
{
   public class NewsRepo : IRepo<News, int>
    {
        NewsPortalEntities db;

        public NewsRepo(NewsPortalEntities db)
        {
            this.db = db;
        }
        public bool Create(News obj)
        {
            db.News.Add(obj);
            var re = db.SaveChanges();
            if(re != 0)
            {
                return true;
            }
            return false;



        }

        public bool Delete(int id)
        {
            db.News.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.SingleOrDefault(s => s.id == id);
        }

        public bool Update(News obj)
        {
            throw new NotImplementedException();
        }
    }
}
