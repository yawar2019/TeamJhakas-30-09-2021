using ADODotNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ADODotNetExample.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        UserEntities db = new UserEntities();

        [HttpPost]
        public ActionResult Login(UserDetail user)
        {

            var verifyUser = db.UserDetails.Where(u => u.UserName == user.UserName && u.Password == user.Password).SingleOrDefault();

            if (verifyUser != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Dashboard");
            }

            return View();
        }


        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/login/login");
        }

        [Authorize(Roles="Admin")]
        public ActionResult ContactUsPage()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]

        public ActionResult AboutUsPage()
        {
            return View();
        }
    }
}

