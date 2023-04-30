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
    public class TournamentController : ApiController
    {
        [HttpGet]
        [Route("api/Tournaments")]
        public HttpResponseMessage Tournaments()
        {
            try
            {
                var data = TournamentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/Tournaments/{Id}")]
        public HttpResponseMessage SingleTournaments(int Id)
        {
            try
            {
                var data = TournamentService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Tournaments/create")]
        public HttpResponseMessage Create(TournamentDTO obj)
        {
            try
            {
                var data = TournamentService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Tournaments/update")]
        public HttpResponseMessage Update(TournamentDTO obj)
        {
            try
            {
                var data = TournamentService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Tournaments/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = TournamentService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
