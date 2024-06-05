using RAiso1.Handlers;
using RAiso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int userID)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = TransactionHandler.getLatestID() + 1;
            th.TransactionDate = DateTime.Now;
            th.UserID = userID;
            return th;
        }
    }
}