using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TourneyNet.Controllers
{
    [EnableCors("*","*","*")]
    public class FanPostController : ApiController
    {
        [HttpGet]
        [Route("api/FanPosts")]
        public HttpResponseMessage FanPosts()
        {
            try
            {
                var data = FanPostService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/FanPosts/{Id}")]
        public HttpResponseMessage SingleFanPosts(int Id)
        {
            try
            {
                var data = FanPostService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/FanPosts/create")]
        public HttpResponseMessage Create(FanPostDTO obj)
        {
            try
            {
                var data = FanPostService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/FanPosts/update")]
        public HttpResponseMessage Update(FanPostDTO obj)
        {
            try
            {
                var data = FanPostService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/FanPosts/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = FanPostService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
