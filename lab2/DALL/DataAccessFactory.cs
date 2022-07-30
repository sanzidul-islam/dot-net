using DALL.EF;
using DALL.interfaces;
using DALL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class DataAccessFactory
    {
        static NewsPortalEntities db = new NewsPortalEntities();
        public static IRepo<News, int> GetNewsDataAccess()
        {
            return new NewsRepo(db);
        }
        //static NewsPortalEntities db = new NewsPortalEntities();
        ////public static IRepo<News, int> GetCataDataAccess()
        ////{
        ////    return new NewsRepo(db);
        ////}
    }
}
