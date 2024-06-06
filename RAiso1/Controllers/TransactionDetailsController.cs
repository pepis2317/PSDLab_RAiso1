using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Controllers
{
    public class TransactionDetailsController
    {
        public static void insertTransactionDetail(int transactionID, int statoineryID, int quantity)
        {
            TransactionDetail td = TransactionDetailFactory.Create(transactionID, statoineryID, quantity);
            TransactionDetailsHandler.insertTransactionDetail(td);
        }
        public static List<TransactionDetail> getTransactionDetailsByID(int transactionID)
        {
            return TransactionDetailsHandler.getTransactionDetailsByID(transactionID);
        }
        public static List<TransactionDetail> getTransactionDetailsByStationeryID(int stationeryID)
        {
            return TransactionDetailsHandler.getTransactionDetailsByStationeryID(stationeryID);
        }
    }
}