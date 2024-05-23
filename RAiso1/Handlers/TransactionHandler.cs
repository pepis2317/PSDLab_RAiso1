using RAiso1.Models;
using RAiso1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso1.Handlers
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> getTransactions()
        {
            return TransactionHeaderRepository.getTransactionHeaders();
        }
    }
}