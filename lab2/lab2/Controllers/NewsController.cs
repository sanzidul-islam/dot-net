using BLL.BOs;
using BLL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab2.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/news")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = NewsService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/News/create")]
        [HttpPost]
        public HttpResponseMessage Create(NewsModel st)
        {
            var data = NewsService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
