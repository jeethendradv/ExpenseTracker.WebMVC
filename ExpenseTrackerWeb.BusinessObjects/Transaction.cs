using System;
using System.Collections.Generic;

namespace ExpenseTrackerWeb.BusinessObjects
{
    public class Transaction
    {
        public Transaction()
        {
            TransactionReceipts = new List<TransactionReceipt>();
        }
        public int TransactionId { get; set; }

        public double TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionNote { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public bool HasReceipts { get; set; }

        public TransactionCategory TransactionCategory { get; set; }

        public List<TransactionReceipt> TransactionReceipts { get; set; }
    }
}
