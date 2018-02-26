using AutoMapper;
using ExpenseTrackerWeb.Business.ExpenseTrackerService;
using ExpenseTrackerWeb.BusinessObjects;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTrackerWeb.Business
{
    public class TransactionBuilder : BaseBuilder
    {
        public TransactionBuilder(string authToken) : base(authToken) { }

        public void CreateTransactionCategory(string name)
        {
            ExpenseTrackerServiceClient client = new ExpenseTrackerServiceClient();
            using (new System.ServiceModel.OperationContextScope(client.InnerChannel))
            {
                AddAuthTokenHeader();
                client.CreateTransactionCategory(name);
            }
        }

        public void CreateTransaction(Transaction transaction)
        {
            ExpenseTrackerServiceClient client = new ExpenseTrackerServiceClient();
            using (new System.ServiceModel.OperationContextScope(client.InnerChannel))
            {
                AddAuthTokenHeader();
                var tran = new TransactionDTO
                {
                    CategoryId = transaction.CategoryId,
                    TransactionAmount = transaction.TransactionAmount,
                    TransactionDate = transaction.TransactionDate,
                    TransactionNote = transaction.TransactionNote,
                    UserId = transaction.UserId
                };
                if (transaction.TransactionReceipts.Any())
                {
                    List<TransactionReceiptDTO> receipts = new List<TransactionReceiptDTO>();
                    transaction.TransactionReceipts.ForEach(t =>
                    {
                        receipts.Add(new TransactionReceiptDTO
                        {
                            ReceiptImage = t.ReceiptImage,
                            ContentType = t.ContentType
                        });
                    });
                    tran.TransactionReceipts = receipts.ToArray();
                }
                client.CreateTransaction(tran);
            }
        }

        public List<TransactionCategory> GetTransactionCategories()
        {
            ExpenseTrackerServiceClient client = new ExpenseTrackerServiceClient();
            using (new System.ServiceModel.OperationContextScope(client.InnerChannel))
            {
                AddAuthTokenHeader();
                return Mapper.Map<List<TransactionCategory>>(client.GetTransactionCategories());
            }
        }

        public bool CategoryExists(string name)
        {
            ExpenseTrackerServiceClient client = new ExpenseTrackerServiceClient();
            using (new System.ServiceModel.OperationContextScope(client.InnerChannel))
            {
                AddAuthTokenHeader();
                return client.CategoryExists(name);
            }
        }

        public void DeleteTransaction(int transactionId)
        {
            ExpenseTrackerServiceClient client = new ExpenseTrackerServiceClient();
            using (new System.ServiceModel.OperationContextScope(client.InnerChannel))
            {
                AddAuthTokenHeader();
                client.DeleteTransaction(transactionId);
            }
        }
    }
}
