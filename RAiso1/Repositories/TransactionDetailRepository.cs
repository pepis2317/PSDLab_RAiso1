using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Repositories
{
    public class TransactionDetailRepository
    {
        static RAisoDBEntities db = DBSingleton.getInstance();
        public static List<TransactionDetail> getTransactionDetails()
        {
            return (from t in db.TransactionDetails select t).ToList();
        }
        public static TransactionDetail getSpecificTransactionDetail(int transactionID, int stationeryID)
        {
            return (from t in db.TransactionDetails where t.TransactionID == transactionID && t.StationeryID == stationeryID select t).FirstOrDefault();
        }
        public static List<TransactionDetail> getTransactionDetailsByID(int transactionID)
        {
            return (from t in db.TransactionDetails where t.TransactionID == transactionID select t).ToList();
        }
    }
}