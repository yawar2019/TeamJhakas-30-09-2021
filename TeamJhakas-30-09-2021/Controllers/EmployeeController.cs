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
       public int EmployeeId(int id)
        {
            return id;
        }
        //[NonAction]
        public string EmployeName(int id)
        {
            return "Prakash";
        }

        public int Age(int age)
        {
            //string Name = EmployeName();
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
        [Route("jungle/tiger")]
        [Route("jungle/elephant")]
        [Route("Employee/sendDatausingMultipleModel")]
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

        public ViewResult sendMixModel(int ?id,string name)
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

        public RedirectResult getGoogleView()
        {
            return Redirect("http://ww.google.com");
        }

        public RedirectResult getsendMixModel()
        {
            return Redirect("~/Employee/sendMixModel?id=1&name=jack");
        }

        public RedirectToRouteResult RedirectTosendMixModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Jack";
            obj.EmpSalary = 99999;

            return RedirectToAction("index1","New", obj);

        }

        public ViewResult ExamplePartialView()
        {
            return View();

        }

        public ViewResult ExamplePartialView2()
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

        public PartialViewResult getpartialView()
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

            return PartialView("_MyEmpPartialView", eobj);
        }

        public JsonResult getjsonData()
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


            return Json(eobj,JsonRequestBehavior.AllowGet);

        }

        public FileResult getFile()
        {
            return File("~/Web.config", "text/plain");
        }
        public FileResult getFile2()
        {
            return File("~/Web.config", "application/xml");
        }
        
        public FileResult getFile3()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
         public FileResult getFile4()
        {
            return File("~/ActionResult.pdf", "application/pdf", "ActionResult.pdf");
        }
        public RedirectToRouteResult gotoGetFile3()
        {
            return RedirectToRoute("Default1");
        }

        public ContentResult getDifferentContent(int? id)
        {
            if (id == 1)
            {
                return Content("hello World");
            }
            else if (id == 2) {
                return Content("<p style=color:red>hello World</p>");
            }
            else
            {
                return Content("<script>alert('hello world')</script>");
            }
        }

        public ActionResult EmailChecker(string EmailId)
        {
            return Content(EmailId);
        }
        [Route("Birthday/holiday")]
        [Route("Festival/holiday")]
        public ActionResult HolidayAttributeExample()
        {
            return Content("Happy Holiday");
        }

    }
}