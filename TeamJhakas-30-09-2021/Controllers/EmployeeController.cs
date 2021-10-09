using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamJhakas_30_09_2021.Models;

namespace TeamJhakas_30_09_2021.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
       public int EmployeeId()
        {
            return 1211;
        }

        public string EmployeName()
        {
            return "Prakash1";
        }

        public int Age(int age)
        {
            return age;
        }

        public string Multiplevalues()
        {
            return "My Name is "+Request.QueryString["name"]+" and My age is "+Request.QueryString["age"]+" Address "+Request.QueryString["address"];
        }

        public ActionResult senddata()
        {

            ViewBag.Name ="Jack";
            return View();
        }
        public ActionResult senddata2()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            ViewBag.info = obj;

            return View();
        }

        public ActionResult senddata3()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            EmployeeModel obj1 = new EmployeeModel();
            obj1 = null;
            //obj1.EmpId = 2;
            //obj1.EmpName = "Rupesh";
            //obj1.EmpSalary = 9999;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Sushma";
            obj2.EmpSalary = 39999;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            ViewBag.info = listObj;


            return View();
        }

        public ActionResult getmeview()
        {
            ViewBag.Name = "hello";
            return View("~/Views/New/index.cshtml");
        }

        public ActionResult jumpingBall()
        {
            return RedirectToAction("index1", "New",new {id=1211});
        }

        public ActionResult jumpingModel()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();


            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            EmployeeModel obj1 = new EmployeeModel();

            obj1.EmpId = 2;
            obj1.EmpName = "Rupesh";
            obj1.EmpSalary = 9999;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Sushma";
            obj2.EmpSalary = 39999;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);



            return RedirectToAction("index2", "New", listObj);
        }

        public ActionResult sendDatausingModel()
        {
            string a = "asdfasd";
            String b = "asdfa";

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            return View(obj);
        }

        public ActionResult sendDatausingMultipleModel()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();


            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            EmployeeModel obj1 = new EmployeeModel();

            obj1.EmpId = 2;
            obj1.EmpName = "Rupesh";
            obj1.EmpSalary = 9999;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Sushma";
            obj2.EmpSalary = 39999;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return View(listObj);
        }

        public ActionResult sendMixModel()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();


            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            EmployeeModel obj1 = new EmployeeModel();

            obj1.EmpId = 2;
            obj1.EmpName = "Rupesh";
            obj1.EmpSalary = 9999;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Sushma";
            obj2.EmpSalary = 39999;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            List<DepartmentModel> deptList = new List<DepartmentModel>();

            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Mechanical";

            deptList.Add(dept);
            deptList.Add(dept1);

            EmpDept eobj = new EmpDept();
            eobj.emp = listObj;
            eobj.dept = deptList;

            return View(eobj);
        }
    }
}