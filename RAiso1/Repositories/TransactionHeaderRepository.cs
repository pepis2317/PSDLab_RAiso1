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
        public static TransactionHeader GetTransactionHeaderByUserID(int userID)
        {
            return (from t in db.TransactionHeaders where t.UserID == userID select t).FirstOrDefault();
        }
        public static void addTransactions(TransactionHeader transactionHeader)
        {
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }
    }
}