using System;

namespace ExpenseTrackerWeb.Models
{
    public class TransactionItemViewModel
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionName { get; set; }
        public double TransactionAmount { get; set; }
        public bool HasReceipts { get; set; }
    }
}