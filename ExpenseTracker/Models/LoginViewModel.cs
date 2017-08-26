using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerWeb.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="User name is required.")]        
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }

        public bool InvalidCredentials { get; set; }
    }
}