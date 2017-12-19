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
    public class CourseController : ApiController
    {

        //获取与当前用户相关联的课程列表
        //GET:/course
        [System.Web.Http.Route("api/course")]
        [System.Web.Http.HttpGet]
        public JsonResult GetCourse()
        {
            var result = new JsonResult();
            var data = new object[]
            {
                new { id = 1, name = "OOAD", numClass = 3, numStudent = 60, startTime = "2017-9-1", endTime = "2018-1-1" },
                new { id = 2, name = "J2EE", numClass = 1, numStudent = 60, startTime = "2017-9-1", endTime = "2018-1-1" },
            };
            result.Data = data;
            return result;
        }

        //创建课程
        //POST:/course
        [System.Web.Http.Route("api/course")]
        [System.Web.Http.HttpPost]
        public JsonResult PostCourse([FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var course = new { id = 23, name = json.name, description = json.description, startTime = json.startTime, endTime = json.endTime, proportions = json.proportions };
            result.Data = course.id;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取课程
        //GET:/course/{courseId}
        [System.Web.Http.Route("api/course/{courseId}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetCourse(int courseId)
        {
            JsonResult result = new JsonResult();
            var data = new { id = 23, name = "OOAD", description = "面向对象分析与设计", teacherName = "邱明", teacherEmail = "mingqiu@xmu.edu.cn" };
            result.Data = data;
            return result;
        }

        //修改课程
        //PUT:/course/{courseId}
        [System.Web.Http.Route("api/course/{courseId}")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage ModifyCourse(int courseId, [FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按Id删除课程
        //DELETE:/course/{courseId}
        [System.Web.Http.Route("api/course/{courseId}")]
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteCourse(int courseId)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按ID获取课程的班级列表
        //GET:/course/{courseId}/class
        [System.Web.Http.Route("api/course/{courseId}/class")]
        [System.Web.Http.HttpGet]
        public JsonResult GetClass(int courseId)
        {
            JsonResult result = new JsonResult();
            var data = new object[] {
                new { id = 45, name = "周三1-2节"},
                new { id = 48, name = "周三3-4节"}
            };
            result.Data = data;
            return result;
        }

        //在指定ID的课程创建班级
        //POST:/course/{courseId}/class
        [System.Web.Http.Route("api/course/{courseId}/class")]
        [System.Web.Http.HttpPost]
        public JsonResult PostClass(int courseId, [FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var Class = new { id = 45 };
            result.Data = Class;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按课程ID获取讨论课详情列表
        //GET: /course/{courseId}/seminar
        [System.Web.Http.Route("api/course/{courseId}/seminar")]
        [System.Web.Http.HttpGet]
        public JsonResult GetSeminar(int courseId, bool embedGrade)
        {
            var result = new JsonResult();
            var data = new object[] {
                new { id = 29, name = "界面原型设计", description = "界面原型设计", groupingMethod = "fixed", startTime = "2017-09-25", endTime = "2017-10-09", grade=4},
                new { id = 32, name = "概要设计", description = "模型层与数据库设计", groupingMethod = "fixed", startTime = "2017-10-10", endTime = "2017-10-24", grade=5}
            };
            result.Data = data;
            return result;
        }

        //在指定ID的课程创建讨论课
        //POST: /course/{courseId}/seminar
        [System.Web.Http.Route("api/course/{courseId}/seminar")]
        [System.Web.Http.HttpPost]
        public JsonResult PostSeminar(int courseId, [FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var Class = new { id = 32 };
            result.Data = Class;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //获取课程正在进行的讨论课
        //GET: /course/{courseId}/seminar/current
        [System.Web.Http.Route("api/course/{courseId}/seminar/current")]
        [System.Web.Http.HttpGet]
        public JsonResult GetSeminar(int courseId)
        {
            var result = new JsonResult();
            var classes = new object[] {
                new { id = 53, name = "周三12" },
                new { id = 57, name = "周三34" }
            };
            var data = new { id = 29, name = "界面原型设计", courseName = "OOAD", groupingMethod = "fixed", startTime = "2017-09-25", endTime = "2017-10-09", classes };
            result.Data = data;
            return result;
        }

        //按课程ID获取学生的所有讨论课成绩
        //GET: /course/{courseId}/grade
        [System.Web.Http.Route("api/course/{courseId}/grade")]
        [System.Web.Http.HttpGet]
        public JsonResult getGrade(int courseId)
        {
            var result = new JsonResult();
            var data = new object[] {
                new { seminarName = "需求分析", groupName = "3A2",leaderName = "张三", presentationGrade = 3, reportGrade = 3,grade = 4 },
                new { seminarName = "界面原型设计", groupName = "3A3",leaderName = "张三", presentationGrade = 4, reportGrade = 4,grade = 4 }
            };
            result.Data = data;
            return result;
        }

    }
}