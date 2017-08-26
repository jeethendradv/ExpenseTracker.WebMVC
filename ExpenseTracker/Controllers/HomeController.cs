using ExpenseTrackerWeb.Business;
using ExpenseTrackerWeb.BusinessObjects;
using ExpenseTrackerWeb.BusinessObjects.Extensions;
using ExpenseTrackerWeb.Models;
using System;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ExpenseTrackerWeb.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            TransactionSearchCriteria searchCriteria = new TransactionSearchCriteria
            {
                StartDate = DateTime.Now.StartOfWeek(),
                EndDate = DateTime.Now,
                SearchPeriod = SearchPeriod.Weekly
            };
            List<Transaction> transactions = GetTransactions(searchCriteria);
            Chart(transactions);
            return View(new UserTransactionViewModel(transactions, SearchPeriod.Weekly));
        }

        public ActionResult FetchTransactions(TransactionSearchCriteria searchCriteria)
        {
            List<Transaction> transactions = GetTransactions(searchCriteria);
            Chart(transactions);
            return View("Transactions", new UserTransactionViewModel(transactions, SearchPeriod.Weekly));
        }

        private List<Transaction> GetTransactions(TransactionSearchCriteria searchCriteria)
        {
            UserBuilder user = new UserBuilder(AuthToken);
            return user.GetTransactions(searchCriteria);
        }

        private void Chart(List<Transaction> transactions)
        {
            string filePath = Server.MapPath("/_ChartFiles/chart.jpg");
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            ChartViewModel chart = new ChartViewModel(transactions);            
            var image = new Chart(width: 600, height: 400, theme: ChartTheme.Blue)
                .AddLegend()
                .AddSeries(
                    name: "Expense",
                    xValue: chart.xAxisValues,
                    yValues: chart.yAxisValues,
                    chartType: "Pie"
                    );
            image.Save(filePath);
        }
    }
}