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
    public class PlayerGameController : ApiController
    {
        [HttpGet]
        [Route("api/playergames")]
        public HttpResponseMessage PlayerGames()
        {
            try
            {
                var data = PlayerGameService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/playergames/{Id}")]
        public HttpResponseMessage SinglePlayerGames(int Id)
        {
            try
            {
                var data = PlayerGameService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/playergames/create")]
        public HttpResponseMessage Create(PlayerGameDTO obj)
        {
            try
            {
                var data = PlayerGameService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/playergames/update")]
        public HttpResponseMessage Update(PlayerGameDTO obj)
        {
            try
            {
                var data = PlayerGameService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/playergames/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = PlayerGameService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
