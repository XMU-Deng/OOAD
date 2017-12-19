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
    public class SchoolController : ApiController
    {
        //获取学校列表（按照城市查找学校）
        //GET: /school?city={city}
        [System.Web.Http.Route("api/school/city={city}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetSchool(string city)
        {
            var result = new JsonResult();
            var data = new object[]
            {
                new {id=32,name="厦门大学",province="福建",city="厦门"},
                new {id=37,name="厦门软件学院",province="福建",city="厦门"}
            };
            result.Data = data;
            return result;
        }

        //添加学校
        //POST: /school
        [System.Web.Http.Route("api/school")]
        [System.Web.Http.HttpPost]
        public JsonResult PostSeminar([FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var school = new { name = "厦门市人民公园", province = "福建", city = "厦门", id = 38 };
            var failed = false;
            string a = json.schoolname;
            if (a == "厦门大学" || a == "厦门软件学院")
                result.Data = failed;
            else
                result.Data = school.id;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //获取省份列表
        //GET: /school/province
        [System.Web.Http.Route("api/school/province")]
        [System.Web.Http.HttpGet]
        public JsonResult GetProvince([FromBody]dynamic json)
        {
            var result = new JsonResult();
            var province = new object[] { "北京", "天津", "河北省", "福建", "......", "澳门特别行政区" };
            result.Data = province;
            return result;
        }

        //获取城市列表
        //GET: /school/city?province={province}
        [System.Web.Http.Route("api/school/city/province={province}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetCity(string province)
        {
            var result = new JsonResult();
            var data = new object[]
            {
               "福州", "漳州", "厦门", "......", "龙岩"
            };
            result.Data = data;
            return result;
        }
    }
}
