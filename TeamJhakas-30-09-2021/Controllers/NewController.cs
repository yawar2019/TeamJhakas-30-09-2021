using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamJhakas_30_09_2021.Models;

namespace TeamJhakas_30_09_2021.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public int id()
        {
            return 1211;
        }

        public ActionResult index()
        {
            return Redirect("https://www.google.com/");
        }
        public ActionResult index1(int? id)
        {
            return View();
        }

        public ActionResult index2(List<EmployeeModel> emp)
        {
            return View();
        }


        public ActionResult index3()
        {
            return Content("hello");
        }
    }
}