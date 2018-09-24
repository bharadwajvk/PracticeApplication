using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Entity;

namespace WepAPI.Controllers
{
    public class UserController : ApiController
    {
        public static List<User> userlist = new List<User>();
        // GET api/values
        public List<User> Get()
        {
            User u = new User { Id = 1, FirstName = "shawn", LastName = "mendis", Address = "1640 5th street", country =  CountryEnum.UnitedStates, Email = "shawn@mendis.com", PhoneNumber = "2121212121" };
            userlist.Add(u);
            return userlist;
        }

        // GET api/values/5
        public User Get(int id)
        {
            return userlist.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        public void Post([FromBody]User user)
        {
            userlist.Add(user);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            User u =userlist.Where(x => x.Id == id).FirstOrDefault();
            userlist.Remove(u);
        }
    }
}
