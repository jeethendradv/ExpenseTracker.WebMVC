namespace ExpenseTrackerWeb.BusinessObjects
{
    public class AuthenticateResult
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public bool IsAuthenticated { get; set; }
        public string ErrorMessage { get; set; }
    }
}
