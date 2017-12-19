using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;

namespace ManageSystem.Controllers
{
    public class MeController : ApiController
    {
        public class LoginModel
        {
            public string username { set; get; }
            public string password { set; get; }
        }

        //获取当前用户
        // GET: /me
        [System.Web.Http.Route("api/me")]
        [System.Web.Http.HttpGet]
        public JsonResult GetCurrentUser()
        {
            var me = new object[] {
                new { id = 3486, type = "student", name = "张三", number = "23320152202333", phone = "18911114514", email = "23320152202333@stu.xmu.edu.cn", gender = "male", school = new { id = 32, name = "厦门大学" }, title = "", avatar = "../../images/user.png" },
                new { id = 3486, type = "teacher", name = "邱明", number = "23320142333", phone = "12345678900", email = "23320142333@stu.xmu.edu.cn", gender = "male", school = new { id = 32, name = "厦门大学" }, title = "", avatar = "../../images/user.png" },
            };
            var result = new JsonResult();
            result.Data = me;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //修改当前用户
        // PUT: /me
        [System.Web.Http.Route("api/me")]
        [System.Web.Http.HttpPut]
        public JsonResult PutID([FromBody]dynamic json)
        {
            var result = new JsonResult();
            var school = new { id = 32, name = "厦门大学" };
            var me = new { name = "张三", number = "23320152202333", school };
            result.Data = me;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //.Net手机号密码登录
        // POST: /signin
        [System.Web.Http.Route("api/me/signin")]
        [System.Web.Http.HttpPost]
        public JsonResult PostSignin([FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var student = new { id = 3486, type = "student", name = "张三" };
            var teacher = new { id = 4532, type = "teacher", name = "邱明" };
            var failed = false;
            string a = json.phone_id;
            string b = json.password;
            if (a == "18911114514" && b == "qwer2345!")
                result.Data = student;
            else if (a == "12345678900" && b == "asdf2345!")
                result.Data = teacher;
            else result.Data = failed;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //.Net手机号密码注册
        //POST:/me
        [System.Web.Http.Route("api/me/register")]
        [System.Web.Http.HttpPost]
        public JsonResult PostRegister([FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var data = new { id = 3486, type = "unbind", name = "" };
            var failed = false;
            string a = json.password;
            string b = json.password_confirm;
            string c = json.phnoe_no;
            if (a == "qwer2345!" && c == "18911114514")
                result.Data = data;
            else
                result.Data = failed;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

    }
}
