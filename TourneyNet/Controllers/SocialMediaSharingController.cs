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
    public class SocialMediaSharingController : ApiController
    {
        [HttpGet]
        [Route("api/smsharings")]
        public HttpResponseMessage SocialMediaSharings()
        {
            try
            {
                var data = SocialMediaSharingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/smsharings/{Id}")]
        public HttpResponseMessage SingleSocialMediaSharings(int Id)
        {
            try
            {
                var data = SocialMediaSharingService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/smsharings/create")]
        public HttpResponseMessage Create(SocialMediaSharingDTO obj)
        {
            try
            {
                var data = SocialMediaSharingService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/smsharings/update")]
        public HttpResponseMessage Update(SocialMediaSharingDTO obj)
        {
            try
            {
                var data = SocialMediaSharingService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/smsharings/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = SocialMediaSharingService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
