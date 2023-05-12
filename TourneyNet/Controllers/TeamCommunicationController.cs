using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TourneyNet.Controllers
{
    public class TeamCommunicationController : ApiController
    {
        [HttpGet]
        [Route("api/teamcommunications")]
        public HttpResponseMessage TeamCommunications()
        {
            try
            {
                var data = TeamCommunicationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/teamcommunicatios/{Communication_id}")]
        public HttpResponseMessage SingleTeamCommunications(int Communication_id)
        {
            try
            {
                var data = TeamCommunicationService.Get(Communication_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/teamcommunications/create")]
        public HttpResponseMessage Create(TeamCommunicationDTO obj)
        {
            try
            {
                var data = TeamCommunicationService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/teamcommunications/update")]
        public HttpResponseMessage Update(TeamCommunicationDTO obj)
        {
            try
            {
                var data = TeamCommunicationService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/teamcommunications/delete/{Communication_id}")]
        public HttpResponseMessage Delete(int Communication_id)
        {
            try
            {
                var data = TeamCommunicationService.Delete(Communication_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}
