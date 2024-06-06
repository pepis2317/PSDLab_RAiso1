using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Repositories
{
    public class TransactionHeaderRepository
    {
        static RAisoDBEntities db = DBSingleton.getInstance();
        public static List<TransactionHeader> getTransactionHeaders()
        {
            return (from t in db.TransactionHeaders select t).ToList();
        }
        public static TransactionHeader getTransactionHeader(int id)
        {
            return (from t in db.TransactionHeaders where t.TransactionID == id select t).FirstOrDefault();
        }
        public static List<TransactionHeader> GetTransactionHeadersByUserID(int userID)
        {
            return (from t in db.TransactionHeaders where t.UserID == userID select t).ToList();
        }
        public static void addTransaction(TransactionHeader transactionHeader)
        {
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }
        public static int getLatestID()
        {
            return (from s in db.TransactionHeaders orderby s.TransactionID descending select s.TransactionID).FirstOrDefault();
        }
    }
}