using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Repositories
{
    public class DBSingleton
    {
        static RAisoDBEntities db = null;
        public static RAisoDBEntities getInstance()
        {
            if (db == null)
            {
                db = new RAisoDBEntities();
            }
            return db;
        }
    }
}