using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace ExpenseTrackerWeb.Models
{
    public class TransactionViewModel
    {
        public int TransactionId { get; set; }
        [Required(ErrorMessage ="Please enter the amount.")]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter the amount.")]
        public double TransactionAmount { get; set; }

        [Required(ErrorMessage = "Please enter transaction date.")]
        [DataType(DataType.DateTime, ErrorMessage = "Please enter the correct date.")]
        public DateTime TransactionDate { get; set; }

        public string TransactionNote { get; set; }

        [Required(ErrorMessage ="Select transaction category.")]
        [ScaffoldColumn(false)]
        [Range(1, int.MaxValue, ErrorMessage = "Select transaction category.")]
        public int CategoryId { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public IEnumerable<HttpPostedFileBase> TransactionReceipts { get; set; }
    }
}