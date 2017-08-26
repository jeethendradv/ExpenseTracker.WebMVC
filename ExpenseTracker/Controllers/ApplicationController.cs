using ExpenseTrackerWeb.Business;
using ExpenseTrackerWeb.BusinessObjects;
using ExpenseTrackerWeb.Models;
using System.Web.Mvc;

namespace ExpenseTrackerWeb.Controllers
{
    public class ApplicationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel credentials)
        {
            if (ModelState.IsValid)
            {
                UserCredentials cred = new UserCredentials
                {
                    UserName = credentials.UserName,
                    Password = credentials.Password
                };
                Authentication authentication = new Authentication();
                AuthenticateResult result = authentication.Authenticate(cred);
                if (result.IsAuthenticated)
                {
                    HttpContext.Session.Add("Auth_Token", result.Token);
                    HttpContext.Session.Add("UserId", result.UserId);
                    return RedirectToAction("Index", "Home");
                }
                credentials.InvalidCredentials = true;
            }
            return View(credentials);
        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                Registration registration = new Registration();
                UserValidation validation = registration.ValidateUser(MaptoUserObject(userViewModel));
                if (validation.IsValidUser)
                {
                    User user = new User
                    {
                        FirstName = userViewModel.FirstName,
                        LastName = userViewModel.LastName,
                        UserName = userViewModel.UserName,
                        Email = userViewModel.Email,
                        Password = userViewModel.Password
                    };
                    registration.CreateUser(user);
                    return RedirectToAction("Index");
                }
                else
                {
                    userViewModel.IsValidUserName = false;
                }
            }
            return View(userViewModel);
        }

        private User MaptoUserObject(UserViewModel viewmodel)
        {
            return new User
            {
                FirstName = viewmodel.FirstName,
                LastName = viewmodel.LastName,
                Email = viewmodel.Email,
                UserName = viewmodel.UserName,
                Password = viewmodel.Password
            };
        }
    }
}