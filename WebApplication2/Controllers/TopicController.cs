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
    public class TopicController : ApiController
    {
        //按ID获取话题
        //GET: /topic/{topicId}
        [System.Web.Http.Route("api/topic/{topicId}")]
        [System.Web.Http.HttpGet]
        public JsonResult GetTopic(int topicId)
        {
            var result = new JsonResult();
            var data = new { id = 257, serial = "A", name = "领域模型与模块", description = "Domain model与模块划分",groupLimit = 5,groupMemberLimit = 6,groupLeft = 2};
            result.Data = data;
            return result;
        }

        //按ID修改话题
        //PUT:/topic/{topicId}
        [System.Web.Http.Route("api/topic/{topicId}")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage ModifyTopic(int topicId, [FromBody]dynamic json)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按Id删除话题
        //DELETE:/topic/{topicId}
        [System.Web.Http.Route("api/topic/{topicId}")]
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteTopic(int topicId)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Content = new StringContent("成功", Encoding.UTF8);
            return response;
        }

        //按话题ID获取选择了该话题的小组
        //GET: /topic/{topicId}/group
        [System.Web.Http.Route("api/topic/{topicId}/group")]
        [System.Web.Http.HttpGet]
        public JsonResult GetGroup(int topicId)
        {
            var result = new JsonResult();
            var data = new object[]
            {
                new {id =23,name ="1A1"},
                new {id =26,name ="2A2"}
            };
            result.Data = data;
            return result;
        }
    }
}
