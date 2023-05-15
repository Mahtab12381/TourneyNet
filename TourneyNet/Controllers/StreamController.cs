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
    [EnableCors("*", "*", "*")]
    public class StreamController : ApiController
    {
        [HttpGet]
        [Route("api/streams")]
        public HttpResponseMessage Streams()
        {
            try
            {
                var data = StreamService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/streams/{Stream_id}")]
        public HttpResponseMessage SingleStreams(int Stream_id)
        {
            try
            {
                var data = StreamService.Get(Stream_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/streams/create")]
        public HttpResponseMessage Create(StreamDTO obj)
        {
            try
            {
                var data = StreamService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/streams/update")]
        public HttpResponseMessage Update(StreamDTO obj)
        {
            try
            {
                var data = StreamService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/streams/delete/{Stream_id}")]
        public HttpResponseMessage Delete(int Stream_id)
        {
            try
            {
                var data = StreamService.Delete(Stream_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}
