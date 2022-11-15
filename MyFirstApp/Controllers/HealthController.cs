using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HealthController : Controller
    {
        // GET: Health
        public ActionResult Index()
        {//in this health package form
            return View();
        }
    }
}