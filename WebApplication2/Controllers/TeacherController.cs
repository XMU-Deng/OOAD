using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;


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

        public ActionResult RandomRollStartCallUI()
        {
            return View();
        }

        public ActionResult RandomRollCallUI()
        {
            return View();
        }

        public ActionResult RandomEndRollCallUI()
        {
            return View();
        }

        public ActionResult RollCallListUI()
        {
            return View();
        }

        public ActionResult GroupInfoUI()
        {
            return View();
        }

        public ActionResult FixedRollStartCallUI()
        {
            return View();
        }

        public ActionResult FixedRollCallUI()
        {
            return View();
        }

        public ActionResult FixedRollCallEndUI()
        {
            return View();
        }

        public ActionResult FixedEndRollCallUI()
        {
            return View();
        }

        public ActionResult FixedGroupInfoUI()
        {
            return View();
        }
    }
}