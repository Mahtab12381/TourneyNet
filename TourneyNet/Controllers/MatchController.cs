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
    public class MatchController : ApiController
    {
        [HttpGet]
        [Route("api/matches")]
        public HttpResponseMessage Matches()
        {
            try
            {
                var data = MatchService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }


        }


        [HttpGet]
        [Route("api/matches/{Match_id}")]
        public HttpResponseMessage SingleMatches(int Match_id)
        {
            try
            {
                var data = MatchService.Get(Match_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/matches/create")]
        public HttpResponseMessage Create(MatchDTO obj)
        {
            try
            {
                var data = MatchService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/matches/update")]
        public HttpResponseMessage Update(MatchDTO obj)
        {
            try
            {
                var data = MatchService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/matches/delete/{Match_id}")]
        public HttpResponseMessage Delete(int Match_id)
        {
            try
            {
                var data = MatchService.Delete(Match_id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
