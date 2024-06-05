using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Controllers
{
    public class TransactionController
    {
        public static int insertTransactionHeader(int userID)
        {
            TransactionHeader th = TransactionHeaderFactory.Create(userID);
            TransactionHandler.insertTransactionHeader(th);
            return th.TransactionID;
        }
        public static void insertTransactionDetail(int transactionID, int statoineryID, int quantity)
        {
            TransactionDetail td = TransactionDetailFactory.Create(transactionID, statoineryID, quantity);
            TransactionHandler.insertTransactionDetail(td);
        }
    }
}