using System;

namespace ExpenseTrackerWeb.BusinessObjects
{
    public class TransactionSearchCriteria
    {
        public SearchPeriod SearchPeriod { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PageSize { get; set; }        
        public int PageNumber { get; set; }
    }
}
