using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Handlers
{
    public class TransactionDetailsHandler
    {
        public static void insertTransactionDetail(TransactionDetail td)
        {
            TransactionDetailRepository.addTransactionDetail(td);
        }
        public static List<TransactionDetail> getTransactionDetailsByID(int transactionID)
        {
            return TransactionDetailRepository.getTransactionDetailsByID(transactionID);
        }
        public static List<TransactionDetail> getTransactionDetailsByStationeryID(int stationeryID)
        {
            return TransactionDetailRepository.getTransactionDetailsByStationeryID(stationeryID);
        }
    }
}