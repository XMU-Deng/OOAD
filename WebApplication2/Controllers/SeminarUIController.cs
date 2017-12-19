using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class SeminarUIController : Controller
    {
        // GET: Seminar
        public ActionResult Seminar()
        {
            return View();
        }

        public ActionResult SeminarFixedGroupNoSelection()
        {
            return View();
        }

        public ActionResult SeminarRandomGroupNoSelection()
        {
            return View();
        }
    }
}