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
    public class PlayerController : ApiController
    {
        [HttpGet]
        [Route("api/players")]
        public HttpResponseMessage Players()
        {
            try
            {
                var data = PlayerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/players/{Id}")]
        public HttpResponseMessage SinglePlayers(int Id)
        {
            try
            {
                var data = PlayerService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/players/create")]
        public HttpResponseMessage Create(PlayerDTO obj)
        {
            try
            {
                var data = PlayerService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/players/update")]
        public HttpResponseMessage Update(PlayerDTO obj)
        {
            try
            {
                var data = PlayerService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/players/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = PlayerService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/players/delete/{Id}")]
        public HttpResponseMessage fghfghfgh(int Id)
        {
            try
            {
                var data = PlayerService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
