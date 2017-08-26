namespace ExpenseTrackerWeb.BusinessObjects
{
    public class TransactionReceipt
    {
        public int TransacitonReceiptId { get; set; }
        public int TransactionId { get; set; }
        public byte[] ReceiptImage { get; set; }
        public string ContentType { get; set; }
    }
}
