namespace ExpenseTrackerWeb.BusinessObjects
{
    public class UserValidation
    {
        public bool IsValidUserName { get; set; }

        public bool IsValidEmail { get; set; }
        public bool IsValidUser
        {
            get
            {
                return IsValidEmail && IsValidUserName;
            }
        }
    }
}
