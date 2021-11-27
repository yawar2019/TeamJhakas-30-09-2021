using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADODotNetExample.Models;
using System.Data.SqlClient;
using Dapper;
namespace ADODotNetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");//User Id=sa;Password=123

        public ActionResult DapperIndex()
        {
            var Emp = con.Query<EmployeeModel>("uspgetEmployeeDetails_10pm",commandType:System.Data.CommandType.StoredProcedure);
            return View(Emp);
        }

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

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            //EmployeeModel emp = db.getEmployeesDataById(id);
            var param = new DynamicParameters();
            param.Add("empid", id);
            var emp = con.QuerySingle<EmployeeModel>("spr_getEmployeeDetailsbyId",param:param ,commandType: System.Data.CommandType.StoredProcedure);

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            //int result = db.UpdateEmployee(emp);
            var param = new DynamicParameters();
            param.Add("@Empid",emp.EmpId);
            param.Add("@EmpName",emp.EmpName);
            param.Add("@EmpSalary",emp.EmpSalary);

            int result = con.Execute("spr_updateEmployeeDetails", param: param, commandType: System.Data.CommandType.StoredProcedure);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeesDataById(id);

            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.getEmployeesDataById(id);
            int result = db.DeleteEmployee(id);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}   