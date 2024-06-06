using RAiso1.Factories;
using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Controllers
{
    public class TransactionHeaderController
    {
        public static int insertTransactionHeader(int userID)
        {
            TransactionHeader th = TransactionHeaderFactory.Create(userID);
            TransactionHeaderHandler.insertTransactionHeader(th);
            return th.TransactionID;
        }
        public static List<TransactionHeader> GetTransactionHeadersByUserID(int userID)
        {
            return TransactionHeaderHandler.getTransactionHeaderByUserID(userID);
        }
        
    }
}