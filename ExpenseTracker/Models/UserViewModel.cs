using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerWeb.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            this.IsValidUserName = true;
            this.IsValidEmail = true;
        }

        [Required(ErrorMessage ="First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MinLength(6, ErrorMessage ="User name should be minimum of six characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password should be minimum of six characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re-enter the password.")]
        [Compare("Password", ErrorMessage ="Confirm password does not match.")]
        public string ConfirmPassword { get; set; }

        public bool IsValidUserName { get; set; }
        public bool IsValidEmail { get; set; }
    }
}