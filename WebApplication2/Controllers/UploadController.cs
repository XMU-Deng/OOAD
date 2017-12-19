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

namespace WebApplication2.Controllers
{
    public class UploadController : ApiController
    {
        //上传头像
        //POST:/upload/avatar
        [System.Web.Http.Route("api/upload/avatar")]
        [System.Web.Http.HttpPost]
        public JsonResult ChooseClass([FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var Class = new { url = "/avator/3486.png" };
            result.Data = Class.url;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }
    }
}
