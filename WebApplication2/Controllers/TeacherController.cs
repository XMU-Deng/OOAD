using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClassManage()
        {
            return View();
        }

        public ActionResult Random_StartCalling()
        {
            return View();
        }

        public ActionResult Random_InCallingPeriod()
        {
            return View();
        }

        public ActionResult Random_EndCalling()
        {
            return View();
        }

        public ActionResult CallingList()
        {
            return View();
        }

        public ActionResult RandomGroupInfo()
        {
            return View();
        }

        public ActionResult Fixed_StartCalling()
        {
            return View();
        }

        public ActionResult Fixed_InCallingPeriod()
        {
            return View();
        }

        public ActionResult Fixed_EndCalling()
        {
            return View();
        }

        public ActionResult Fixed_EndCallingList()
        {
            return View();
        }

        public ActionResult FixedGroupInfo()
        {
            return View();
        }
    }
}