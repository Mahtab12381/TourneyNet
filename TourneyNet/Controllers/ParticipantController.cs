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
    public class ParticipantController : ApiController
    {
        [HttpGet]
        [Route("api/participants")]
        public HttpResponseMessage Participants()
        {
            try
            {
                var data = ParticipantService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/participants/{Id}")]
        public HttpResponseMessage SingleParticipants(int Id)
        {
            try
            {
                var data = ParticipantService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/participants/create")]
        public HttpResponseMessage Create(ParticipantDTO obj)
        {
            try
            {
                var data = ParticipantService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/participants/update")]
        public HttpResponseMessage Update(ParticipantDTO obj)
        {
            try
            {
                var data = ParticipantService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/participants/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = ParticipantService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
