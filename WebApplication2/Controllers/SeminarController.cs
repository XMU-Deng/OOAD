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
    public class SeminarController : ApiController
    {
        //按ID获取讨论课
        // GET: /seminar/{seminarId}
        [System.Web.Http.Route("api/seminar/{seminarId}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetSeminarById(int seminarId)
        {
            var seminar = new
            {
                id = 32,
                name = "概要设计",
                description = "模型层与数据库设计",
                groupingMethod = "fixed",
                startTime = "2017-10-10",
                endTime = "2017-10-24",
                topics = new object[] { new { id = 257, name = "领域模型与模块" } }
            };
            var result = new JsonResult();
            result.Data = seminar;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID修改讨论课
        // PUT: /seminar/{seminarId}
        [System.Web.Http.Route("api/seminar/{seminarId}")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage PutSeminarById(int seminarId,[FromBody]dynamic Json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            HttpResponseMessage response2 = new HttpResponseMessage(HttpStatusCode.BadRequest);
            response2.Content = new StringContent("错误的ID格式", Encoding.UTF8);
            HttpResponseMessage response3 = new HttpResponseMessage(HttpStatusCode.NotFound);
            response3.Content = new StringContent("未找到讨论课", Encoding.UTF8);
            return response;
        }

        //按ID删除讨论课
        // DELETE: /seminar/{seminarId}
        [System.Web.Http.Route("api/seminar/{seminarId}")]
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteSeminarById(int seminarId)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            HttpResponseMessage response2 = new HttpResponseMessage(HttpStatusCode.BadRequest);
            response2.Content = new StringContent("错误的ID格式", Encoding.UTF8);
            HttpResponseMessage response3 = new HttpResponseMessage(HttpStatusCode.Forbidden);
            response3.Content = new StringContent("权限不足", Encoding.UTF8);
            HttpResponseMessage response4 = new HttpResponseMessage(HttpStatusCode.NotFound);
            response3.Content = new StringContent("未找到讨论课", Encoding.UTF8);
            return response;
        }

        //按ID获取与学生有关的讨论课信息
        // GET: /seminar/{seminarId}/my
        [System.Web.Http.Route("api/seminar/{seminarId}/my")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetSeminarMy(int seminarId)
        {
            var seminar = new object[] { new { id = 32, name = "概要设计", groupingMethod = "random",
               courseName="OOAD",startTime = "2017-10-10", endTime = "2017-10-24",
                classCalling =23,isLeader=true,areTopicSelected=true } };
            var result = new JsonResult();
            result.Data = seminar;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取讨论课详情
        // GET: /seminar/{seminarId}/detail
        [System.Web.Http.Route("api/seminar/{seminarId}/detail")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetSeminarDetail(int seminarId)
        {
            var seminar = new object[] { new { id = 32, name = "概要设计", groupingMethod = "random",
               courseName="OOAD",startTime = "2017-10-10", endTime = "2017-10-24",
                site="海韵201",teacherName="邱明",teacherEmail="mingqiu@xmu.edu.cn" } };
            var result = new JsonResult();
            result.Data = seminar;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取讨论课的话题
        // GET: /seminar/{seminarId}/topic
        [System.Web.Http.Route("api/seminar/{seminarId}/topic")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetSeminarTopic(int seminarId)
        {
            var seminar = new object[] { new { id= 257,serial="A",name="领域模型与模块",description= "Domain model与模块划分",
            groupLimit= 5,groupMemberLimit= 6,groupLeft=2 }, new { id= 257,serial="B",name="数据库设计",description= "数据库逻辑与物理结构设计",
            groupLimit= 5,groupMemberLimit= 6,groupLeft=1 } , new { id= 257,serial="C",name="概要设计",description= "类图以及模块划分",
            groupLimit= 5,groupMemberLimit= 6,groupLeft=0 }};
            var result = new JsonResult();
            result.Data = seminar;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //在指定ID的讨论课创建话题
        //POST: /seminar/{seminarId}/topic
        [System.Web.Http.Route("api/seminar/{seminarId}/topic")]
        [System.Web.Http.HttpPost]
        public JsonResult PostSeminarTopic(int seminarId,[FromBody]dynamic Json)
        {
            var seminar = new { id= 257} ;
            var result = new JsonResult();
            result.Data = seminar;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按讨论课ID查找小组
        // GET: /seminar/{seminarId}/group
        [System.Web.Http.Route("api/seminar/{seminarId}/group")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetSeminarGroup(int seminarId,Boolean gradeable,int classId)
        {
            var group = new object[] 
            {
                new { id = 28, name = "1A1", topics = new { id = 257, name = "领域模型与模块" } },
                new { id = 29, name = "1A2", topics = new { id = 257, name = "领域模型与模块" } }
            };           
            var result = new JsonResult();
            result.Data = group;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按讨论课ID获取学生所在小组详情
        // GET: /seminar/{seminarId}/group/my
        [System.Web.Http.Route("api/seminar/{seminarId}/group/my")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetSeminarGroupMy(int seminarId)
        {
            var group = new
            {
                id = 28, name = 28, leader=new { id = 8888, name = "张三"} ,
                members = new object[]{new { id = 5354, name = "李四"} },
                topics =new object[] { new { id = 257, name = "领域模型与模块" } }
            } ;
            var result = new JsonResult();
            result.Data = group;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取讨论课班级签到、分组状态
        // GET: /seminar/{seminarId}/class/{classId}/attendance
        [System.Web.Http.Route("api/seminar/{seminarId}/class/{classId}/attendance")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetClassAttendance(int seminarId,int classId)
        {
            var attendance = new { numPresent=40,numStudent=60,status="calling",group="grouping"};
            var result= new JsonResult();
            result.Data = attendance;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取讨论课班级已签到名单
        // GET: /seminar/{seminarId}/class/{classId}/attendance/present
        [System.Web.Http.Route("api/seminar/{seminarId}/class/{classId}/attendance/present")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetClassAttendancePresent(int seminarId,int classId)
        {
            var attendance = new object[] { new { id=2357,name="张三"},new { id=8232,name="李四"} };
            var result = new JsonResult();
            result.Data = attendance;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取讨论课班级迟到签到名单
        // GET: /seminar/{seminarId}/class/{classId}/attendance/late
        [System.Web.Http.Route("api/seminar/{seminarId}/class/{classId}/attendance/late")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetClassAttendanceLate(int seminarId,int classId)
        {
            var attendance = new object[] { new { id = 3412, name = "王五" }, new { id = 5234, name = "王七九" } };
            var result = new JsonResult();
            result.Data = attendance;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //按ID获取讨论课班级缺勤名单
        // GET: /seminar/{seminarId}/class/{classId}/attendance/absent
        [System.Web.Http.Route("api/seminar/{seminarId}/class/{classId}/attendance/absent")]
        [System.Web.Mvc.HttpGet]
        public JsonResult GetClassAttendanceAbsent(int seminarId, int classId)
        {
            var attendance = new object[] { new { id = 34, name = "张六" } };
            var result = new JsonResult();
            result.Data = attendance;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //签到（上传位置信息）
        // PUT: /seminar/{seminarId}/class/{classId}/attendance/{studentId}
        [System.Web.Http.Route("api/seminar/{seminarId}/class/{classId}/attendance/{studentId}")]
        [System.Web.Http.HttpPut]
        public JsonResult CallTheRoll(int seminarId,int classId,string studentId)
        {
            var status =  new { status="late" };
            var result = new JsonResult();
            result.Data =status;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
           
            HttpResponseMessage response2 = new HttpResponseMessage(HttpStatusCode.BadRequest);
            response2.Content = new StringContent("签到失败", Encoding.UTF8);
            HttpResponseMessage response3 = new HttpResponseMessage(HttpStatusCode.Forbidden);
            response3.Content = new StringContent("学生无法为他人签到", Encoding.UTF8);
            HttpResponseMessage response4 = new HttpResponseMessage(HttpStatusCode.NotFound);
            response3.Content = new StringContent("不存在这个学生或班级、讨论课", Encoding.UTF8);
            return result;
        }
    }
}
