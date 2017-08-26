using ExpenseTrackerWeb.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseTrackerWeb.Models
{
    public class ChartViewModel
    {
        public ChartViewModel(List<Transaction> transactions)
        {
            xAxisValues = new List<string>();
            yAxisValues = new List<string>();
            double totalAmount = transactions.Sum(t => t.TransactionAmount);
            var categoryGroup = transactions.GroupBy(t => t.TransactionCategory.CategoryName);
            foreach (var category in categoryGroup)
            {
                string percent = Math.Round((category.Sum(c => c.TransactionAmount) / totalAmount) * 100, 0).ToString();
                xAxisValues.Add(category.Key);
                yAxisValues.Add(percent);
            }
        }

        public List<string> xAxisValues { get; set; }

        public List<string> yAxisValues { get; set; }
    }
}