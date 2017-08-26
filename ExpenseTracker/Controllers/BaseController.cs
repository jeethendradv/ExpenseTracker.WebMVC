using System;
using System.Web.Mvc;

namespace ExpenseTrackerWeb.Controllers
{
    public class BaseController : Controller
    {
        public string AuthToken
        {
            get
            {
                return Convert.ToString(HttpContext.Session["Auth_Token"]);
            }
        }

        public int UserId
        {
            get
            {
                return Convert.ToInt32(HttpContext.Session["UserId"]);
            }
        }
    }
}