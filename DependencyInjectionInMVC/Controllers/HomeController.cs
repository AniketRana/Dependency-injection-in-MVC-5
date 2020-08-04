using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace DependencyInjectionInMVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee = null;
        private IStudent _student = null;

        public HomeController(Employee employee,Student student)
        {
            _employee = employee ;
            _student = student;
        }

        public ActionResult Index()
        {
            int cnt = _employee.Gettotal();
            bool data = _student.IsStudent();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}