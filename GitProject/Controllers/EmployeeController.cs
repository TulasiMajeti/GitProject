using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //Added new controller
        public ActionResult Index()
        {
            return View();
        }
    }
}