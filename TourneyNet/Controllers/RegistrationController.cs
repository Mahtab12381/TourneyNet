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
    public class RegistrationController : ApiController
    {
        [HttpGet]
        [Route("api/reg")]
        public HttpResponseMessage Registrations()
        {
            try
            {
                var data = RegistrationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/reg/{Id}")]
        public HttpResponseMessage SingleRegistrations(int Id)
        {
            try
            {
                var data = RegistrationService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/reg/create")]
        public HttpResponseMessage Create(RegistrationDTO obj)
        {
            try
            {
                var data = RegistrationService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/reg/update")]
        public HttpResponseMessage Update(RegistrationDTO obj)
        {
            try
            {
                var data = RegistrationService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/reg/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = RegistrationService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
