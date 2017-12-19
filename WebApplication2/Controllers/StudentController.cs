using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentRollCallUI()
        {
            return View();
        }

        public ActionResult Score()
        {
            return View();
        }
    }
}