using MyFirstApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyFirstApp.Controllers
{
    public class DoctoreController : Controller
    {
        // GET: Doctore
        public ActionResult CreateDoctoreProfile()
        {
            DoctorProfileRepository oDoctorProfileRepository = new DoctorProfileRepository();
            oDoctorProfileRepository.GetDoctoreQualification();
            return View();
        }
    }
}