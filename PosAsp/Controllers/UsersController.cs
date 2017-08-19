using CryptSharp;
using PosAsp.Library;
using PosAsp.Models;
using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PosAsp.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpPost, Route("login")]
        public IHttpActionResult Login([FromBody] User user)
        {
            //TODO: Need backend validation and refactor

            string email = user.UserEmail.Trim();
            string password = user.UserPassword.Trim();

            using (var context = new Context())
            {
                User userData = context.Users.FirstOrDefault((u) => u.UserEmail == email);
                if (userData != null && Crypter.CheckPassword(password, userData.UserPassword))
                {
                    return Ok(userData.UserToken);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpPost, Route("new")]
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
                        UserEmail = user.UserEmail.Trim(),
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
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
