﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADODotNetExample.Models;

namespace ADODotNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.getEmployeesData());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int result = db.Save(emp);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}   