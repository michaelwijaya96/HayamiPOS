using PosAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PosAsp.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult All()
        {
            //using (var context = new Context())
            //{
            //    context.Users.Add(new User()
            //    {
            //        UserName = "Alvin Oktavianus",
            //        CreatedAt = DateTime.Today
            //    });
            //}
            return Ok();
        }

    }
}
