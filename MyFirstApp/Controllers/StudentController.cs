using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudentDeatils()
        {
            ViewBag.EmployeeName = "saransh";//data send to controller
            ViewBag.Email = "saransh@gmail.com";
            ViewBag.Age = 30;
            ViewBag.Salary = 100000;
            ViewBag.Work = "active";
            return View();
        }
    }
}