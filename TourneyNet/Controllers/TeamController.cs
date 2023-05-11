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
    public class TeamController : ApiController
    {
        [HttpGet]
        [Route("api/teams")]
        public HttpResponseMessage Teams()
        {
            try
            {
                var data = TeamService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/teams/{Team_id}")]
        public HttpResponseMessage SingleTeams(int Team_id)
        {
            try
            {
                var data = TeamService.Get(Team_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/teams/create")]
        public HttpResponseMessage Create(TeamDTO obj)
        {
            try
            {
                var data = TeamService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/teams/update")]
        public HttpResponseMessage Update(TeamDTO obj)
        {
            try
            {
                var data = TeamService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/teams/delete/{Team_id}")]
        public HttpResponseMessage Delete(int Team_id)
        {
            try
            {
                var data = TeamService.Delete(Team_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }




    }
}
