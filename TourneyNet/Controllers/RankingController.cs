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
    public class RankingController : ApiController
    {
        [HttpGet]
        [Route("api/Rankings")]
        public HttpResponseMessage Rankings()
        {
            try
            {
                var data = RankingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/Rankings/{Id}")]
        public HttpResponseMessage SingleRankings(int Id)
        {
            try
            {
                var data = RankingService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Rankings/create")]
        public HttpResponseMessage Create(RankingDTO obj)
        {
            try
            {
                var data = RankingService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Rankings/update")]
        public HttpResponseMessage Update(RankingDTO obj)
        {
            try
            {
                var data = RankingService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/Rankings/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = RankingService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
