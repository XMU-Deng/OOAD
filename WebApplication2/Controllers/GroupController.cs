using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Text;

namespace test.Controllers
{
    public class GroupController : ApiController
    {
        //按小组ID获取小组详情
        //GET:/group/{groupId}
        [System.Web.Http.Route("api/group/{groupId}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetGroupInfo(int groupId, Boolean embedTopics, Boolean embedGrade)
        {
            int id = 13;
            var result = new JsonResult();
            var members = new object[] { new { id = "5324", name = "李四" }, new { id = "5678", name = "王五" } };
            var leader = new { id = "8888", name = "张三" };
            string report = "";
            var topics = new { id = "", name = "领域模型与模块" };
            var data = new { id, leader, members, report, topics };
            result.Data = data;
            return result;
        }

        //组长辞职
        //PUT:/group/{groupId}/resign
        [System.Web.Http.Route("api/group/{groupId}/resign")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage LeaderResign(int groupId, string id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //成为组长
        //PUT:/group/{groupId}/assign
        [System.Web.Http.Route("api/group/{groupId}/assign")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage BecomeLeader(int groupId, string id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //添加成员
        //PUT:/group/{groupId}/add
        [System.Web.Http.Route("api/group/{groupId}/add")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage AddMember(int groupId, string id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //移除成员
        //PUT:/group/{groupId}/remove
        [System.Web.Http.Route("api/group/{groupId}/remove")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage RemoveMember(int groupId, string id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //小组按ID选择话题
        //POST:/group/{groupId}/topic
        [System.Web.Http.Route("api/group/{groupId}/topic")]
        [System.Web.Http.HttpPost]
        public JsonResult ChooseTopic(int groupId, [FromBody]dynamic json)
        {
            JsonResult result = new JsonResult();
            var Topic = new { url = "/group/27/topic/23" };
            result.Data = Topic;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        //小组按ID取消话题
        //DELETE:/group/{groupId}/topic/{topicId}
        [System.Web.Http.Route("api/group/{groupId}/topic/{topicId}")]
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteTopic(int groupId, int topicId)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按小组ID获取小组的讨论课成绩
        //GET:/group/{groupId}/grade
        [System.Web.Http.Route("api/group/{groupId}/grade")]
        [System.Web.Http.HttpGet]
        public JsonResult GetGroupGrade(int groupId)
        {
            var result = new JsonResult();
            var presentationGrade = new object[] { new { topicId = "257", grade = "4" }, new { topicId = "258", grade = "5" } };
            int reportGrade = 3;
            int grade = 4;
            var data = new { presentationGrade, reportGrade, grade };
            result.Data = data;
            return result;
        }

        //按ID设置小组的报告分数
        //PUT:/group/{groupId}/grade/report
        [System.Web.Http.Route("api/group/{groupId}/grade/report")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage GradeReport(int groupId, int reportGrade)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //提交对其他小组的打分
        //PUT:/group/{groupId}/grade/presentation/{studentId}
        [System.Web.Http.Route("api/group/{groupId}/grade/presentation/{studentId}")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage SubmitPresentationGrade(int groupId, string studentId,[FromBody]dynamic presentation)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功",Encoding.UTF8);
            return response;
        }
    }
}
