using AutoMapper;
using ExpenseTrackerWeb.Business.ExpenseTrackerService;
using ExpenseTrackerWeb.BusinessObjects;
using System.Collections.Generic;

namespace ExpenseTrackerWeb.Business
{
    public class UserBuilder : BaseBuilder
    {
        public UserBuilder(string authToken) : base(authToken) { }

        public List<Transaction> GetTransactions(TransactionSearchCriteria searchCriteria)
        {
            ExpenseTrackerServiceClient client = new ExpenseTrackerServiceClient();
            using (new System.ServiceModel.OperationContextScope(client.InnerChannel))
            {
                AddAuthTokenHeader();
                return Mapper.Map<List<Transaction>>(client.GetTransactions(Mapper.Map<TransactionSearchCriteriaDTO>(searchCriteria)));
            }
        }
    }
}
