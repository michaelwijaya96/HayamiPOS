using CryptSharp;
using PosAsp.Library;
using PosAsp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            return Ok();
        }

        [HttpPost]
        public HttpResponseMessage New([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                using (var context = new Context())
                {
                    context.Users.Add(new User()
                    {
                        UserName = user.UserName.Trim(),
                        UserPassword = Crypter.Blowfish.Crypt(user.UserPassword.Trim()),
                        CreatedAt = DateTime.Today,
                        UpdDate = DateTime.Today,
                        UserToken = RandomAccessToken.RandomString(30)
                    });
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    return Request.CreateResponse(HttpStatusCode.Created, RandomAccessToken.RandomString(30));
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
