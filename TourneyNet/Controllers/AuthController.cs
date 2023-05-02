using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using TourneyNet.Model;

namespace TourneyNet.Controllers
{
    public class AuthController : ApiController
    {

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel obj)
        {
            try
            {
                var data = AuthService.Authenticate(obj.username,obj.password);
                if(data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,data);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Massage ="User not found"});
               
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new {Message=ex.Message});
            }
        }

    }
}
