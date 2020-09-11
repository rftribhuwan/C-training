using FirstAPIProgram.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPIProgram.Controllers
{
    public class UserController : ApiController
    {
        User[] user = new User[]
        {
            new User { id = 1, name = "Reuben Tribhuwan", email = "email1@mail.com", phone = "0123456789", role = 1},
            new User { id = 2, name = "Francis Tribhuwan", email = "email2@mail.com", phone = "9874561230", role = 2},
            new User { id = 3, name = "Neeraj Kumar", email = "email3@mail.com", phone = "9876543210", role = 3}
        };
        public IEnumerable<User> Get()
        {
            return user;
        }
        public IHttpActionResult Get(int id)
        {
            var userInfo = user.FirstOrDefault((p) => p.id == id);
            if (userInfo == null)
            {
                return NotFound();
            }
            return Ok(userInfo);
        }
    }
        // GET: api/User
       /* public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }*/
    }

