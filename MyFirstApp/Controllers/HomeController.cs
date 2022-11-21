using System;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { // in this enquiry form
            return View();
        }
       

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ViewResult contactUs()
        {
            return View();
        }
        public FileResult GetEmployeePayslip(int empid)
        {
            string file = "~/PaySlip" + empid+".pdf";
            return File(file,"application/pdf");
        }
        public ActionResult GetPayment()
        {
            return Redirect("http://www.facebook.com");
        }

        }
    }




