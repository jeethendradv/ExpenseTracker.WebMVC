using ExpenseTrackerWeb.Business;
using ExpenseTrackerWeb.BusinessObjects;
using ExpenseTrackerWeb.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace ExpenseTrackerWeb.Controllers
{
    public class TransactionController : BaseController
    {
        public ActionResult Create()
        {
            return View(new TransactionViewModel
            {
                TransactionDate = DateTime.Now.Date,
                Categories = GetCategories()
            });
        }

        [HttpPost]
        public ActionResult Create(TransactionViewModel transactionViewModel)
        {
            if (ModelState.IsValid)
            {
                TransactionBuilder transaction = new TransactionBuilder(AuthToken);
                var tran = new Transaction
                {
                    CategoryId = transactionViewModel.CategoryId,
                    TransactionAmount = transactionViewModel.TransactionAmount,
                    TransactionDate = transactionViewModel.TransactionDate,
                    TransactionNote = transactionViewModel.TransactionNote,
                    UserId = UserId
                };
                if (ContainsTransactionReciepts(transactionViewModel))
                {
                    transactionViewModel.TransactionReceipts.ToList()
                        .ForEach(t =>
                        {
                            tran.TransactionReceipts.Add(new TransactionReceipt
                            {
                                ContentType = t.ContentType,
                                ReceiptImage = StreamHelper.ReadToEnd(t.InputStream)
                            });
                        });                    
                }
                transaction.CreateTransaction(tran);
                return RedirectToAction("Index", "Home");
            }
            transactionViewModel.Categories = GetCategories();
            return View(transactionViewModel);
        }

        [HttpPost]
        public void Delete(int transactionId)
        {
            TransactionBuilder transaction = new TransactionBuilder(AuthToken);
            transaction.DeleteTransaction(transactionId);
        }

        [HttpPost]
        public void AddCategory(string name)
        {
            TransactionBuilder transaction = new TransactionBuilder(AuthToken);
            transaction.CreateTransactionCategory(name);
        }

        public List<TransactionCategory> GetTransactionCategories()
        {
            TransactionBuilder transaction = new TransactionBuilder(AuthToken);
            return transaction.GetTransactionCategories();
        }

        public bool ValidateCategory(string name)
        {
            TransactionBuilder transaction = new TransactionBuilder(AuthToken);
            return !transaction.CategoryExists(name);
        }

        public ActionResult FetchCategories()
        {
            return View(new TransactionViewModel
            {
                Categories = GetCategories()
            });
        }

        private List<SelectListItem> GetCategories()
        {
            TransactionBuilder transaction = new TransactionBuilder(AuthToken);
            return transaction.GetTransactionCategories()
                .Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
        }

        private bool ContainsTransactionReciepts(TransactionViewModel viewModel)
        {
            if (viewModel.TransactionReceipts.Count() == 0 ||
                (viewModel.TransactionReceipts.Count() == 1 
                && viewModel.TransactionReceipts.Single() == null))
            {
                return false;
            }
            return true;
        }
    }
}