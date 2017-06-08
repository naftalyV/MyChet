using MyChet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyChat.Controllers
{
    public class ChatServerController : ApiController
    {
        List<User> ListUser = new List<User>()
          {
            new User { Id = 1, Name = "Moshe", Status= Stat.OnLine  },
            new User { Id = 2, Name = "David" },
            new User { Id = 3, Name = "Pini" }
          };

        [HttpGet]
        // GET: api/ChatServer
        public IHttpActionResult GetOnLineUsers()
        {
           // var Users = ListUser.Where(u => u.Status == Stat.OnLine);
            var Users = ListUser.ToList();
            if (Users == null)
            {
                return NotFound();
            }
            return Ok(Users);


        }
        [HttpGet]
        // GET: api/ChatServer/5
        public IHttpActionResult Get(int id)
        {
            var User = ListUser.FirstOrDefault(u => u.Id == id);
            if (User == null)
            {
                return NotFound();
            }
            return Ok(User);
        }
        [HttpPost]
        // POST: api/ChatServer
        public void LogIn([FromBody]User user)
        {
            user.Status = Stat.OnLine;
            ListUser.Add(user);
        }

      

        [HttpDelete]
        // DELETE: api/ChatServer/5
        public void LogOut([FromBody]User user)
        {
            var DeleteUser = ListUser.FirstOrDefault(x => x.Id == user.Id);
            ListUser.Remove(DeleteUser);
           // DeleteUser.Status = Stat.NotOnLine;
        }
    }
}
