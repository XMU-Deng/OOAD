using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class GroupUIController : Controller
    {
        // GET: FixedGroup
        public ActionResult GroupChooseTopicUI()
        {
            return View();
        }

        public ActionResult GroupUI()
        {
            return View();
        }
    }
}