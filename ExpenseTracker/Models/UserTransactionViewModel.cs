using ExpenseTrackerWeb.BusinessObjects;
using System.Collections.Generic;

namespace ExpenseTrackerWeb.Models
{
    public class UserTransactionViewModel
    {
        public UserTransactionViewModel(List<Transaction> transactions, SearchPeriod period)
        {
            Transactions = new List<TransactionItemViewModel>();
            double totalExpense = 0;
            if (period == SearchPeriod.Weekly)
            {
                transactions.ForEach(t =>
                {
                    Transactions.Add(new TransactionItemViewModel
                    {
                        TransactionDate = t.TransactionDate,
                        TransactionName = t.TransactionCategory.CategoryName,
                        TransactionAmount = t.TransactionAmount,
                        HasReceipts = t.HasReceipts
                    });
                    totalExpense += t.TransactionAmount;
                });
            }
            TotalExpense = totalExpense;
        }

        public List<TransactionItemViewModel> Transactions { get; set; }

        public double TotalExpense { get; set; }
    }
}