using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Handlers
{
    public class TransactionHeaderHandler
    {
        public static List<TransactionHeader> getTransactionHeaders()
        {
            return TransactionHeaderRepository.getTransactionHeaders();
        }
        public static int getLatestID()
        {
            return TransactionHeaderRepository.getLatestID();
        }
        public static void insertTransactionHeader(TransactionHeader th)
        {
            TransactionHeaderRepository.addTransaction(th);
        }
        public static List<TransactionHeader> getTransactionHeaderByUserID(int userID)
        {
            return TransactionHeaderRepository.GetTransactionHeadersByUserID(userID);
        }
    }
}