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
    public class ClassController : ApiController
    {
        //获取与当前用户相关的或者符合条件的班级列表
        //GET:/class
        [System.Web.Http.HttpGet]
        public JsonResult GetClass(string course,string courseTeacher)
        {
            var result = new JsonResult();
            var data = new object[]
            {
                new { id = 23, name="周三1-2节", numStudent = 60,time="周三1-2、周五1-2",site="公寓405",courseName="OOAD",courseTeacher = "邱明"},
                new { id = 42, name="一班", numStudent = 60,time="周三34节、周五12节",site="海韵202",courseName=".Net",courseTeacher = "杨律青"}
            };
            result.Data = data;
            return result;
        }

        //按ID获取班级详情
        //GET: /class/{classId}
        [System.Web.Http.Route("api/class/{classId}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetClass(int classId)
       {
            var result = new JsonResult();
            var data = new { id = 23, name="周三1-2节", numStudent = 120,time="周三一二节",site="海韵201",calling=-1,roster="/roster/周三12班.xlsx",proportions=new { report=50,presentation=50,c=20,b=60,a=20} };
            result.Data = data;
            return result;
        }

        //按ID修改班级
        //PUT:/class/{classId}
        [System.Web.Http.Route("api/class/{classId}")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage ModifyClass(int classId, [FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按Id删除班级
        //DELETE:/course/{classId}
        [System.Web.Http.Route("api/class/{classId}")]
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteClass(int classId)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按班级ID查找学生列表（查询学号、姓名开头）
        //GET:/class/{classId}/student
        [System.Web.Http.Route("api/class/{classId}/student")]
        [System.Web.Http.HttpGet]
        public JsonResult GetStudent(int classId,string numBeginWith,string nameBeginWith)
        {
            var result = new JsonResult();
            var data = new object[]
            {
                new { id = 233, name="张三", number="24320152202333"},
                new { id = 245, name="张八", number="24320152202334"}
            };
            result.Data = data;
            return result;
        }

        //学生按ID选择班级
        //POST:/class/{classId}/student
        [System.Web.Http.Route("api/class/{classId}/student")]
        [System.Web.Http.HttpPost]
        public JsonResult ChooseClass(int classId, [FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var Class = new { url="/class/34/student/2757" };
            result.Data = Class;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //学生按ID取消选择班级
        //DELETE:/class/{classId}/student/{studentId}
        [System.Web.Http.Route("api/class/{classId}/student/{studentId}")]
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteClass(int classId, string studentId)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按ID获取自身所在班级小组
        //GET:/class/{classId}/classgroup
        [System.Web.Http.Route("api/class/{classId}/classgroup")]
        [System.Web.Http.HttpGet]
        public JsonResult GetClassgroup(int classId)
        {
            var result = new JsonResult();
            var members = new object[]
            {
                new {id=2756, name="李四", number="23320152202443"},
                new {id=2777, name="王五", number="23320152202433"}
            };
            var data = new { leader = new { id = 2757, name = "张三", number = "23320152202333" }, members };
            result.Data = data;
            return result;
        }

        //班级小组组长辞职
        //PUT:/class/{classId}/classgroup/resign
        [System.Web.Http.Route("api/class/{classId}/classgroup/resign")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage ResignLeader([FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //成为班级小组组长
        //PUT:/class/{classId}/classgroup/assign
        [System.Web.Http.Route("api/class/{classId}/classgroup/asssign")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage BecomeLeader([FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //添加班级小组成员
        //PUT:/class/{classId}/classgroup/add
        [System.Web.Http.Route("api/class/{classId}/classgroup/add")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage AddMember([FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //移除成员
        //PUT:/class/{classId}/classgroup/remove
        [System.Web.Http.Route("api/class/{classId}/classgroup/remove")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage RemoveMember([FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }
    }
}