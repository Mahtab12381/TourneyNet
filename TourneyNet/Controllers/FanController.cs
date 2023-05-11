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
    public class FanController : ApiController
    {
        [HttpGet]
        [Route("api/fans")]
        public HttpResponseMessage Fans()
        {
            try
            {
                var data = FanService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/fans/{Id}")]
        public HttpResponseMessage SingleFans(int Id)
        {
            try
            {
                var data = FanService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/fans/create")]
        public HttpResponseMessage Create(FanDTO obj)
        {
            try
            {
                var data = FanService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/fans/update")]
        public HttpResponseMessage Update(FanDTO obj)
        {
            try
            {
                var data = FanService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/fans/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = FanService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}
