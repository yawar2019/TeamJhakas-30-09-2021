using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        EmployeeContext db = new EmployeeContext();//initialize connection
        // GET: Default
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);
            int i=db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}