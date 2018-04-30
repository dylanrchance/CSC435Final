using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using myAPI.Models;

namespace myAPI.Controllers
{
    [Route("api/User")]
    //[ApiController]
    public class UserController : ControllerBase
    {
        private readonly NotesContext _context;

        public UserController(NotesContext context)
        {
            _context = context;

            if (_context.User.Count() == 0)
            {
                _context.User.Add(new User { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "alue1", "value2", "value3" };
        }

        public string Get(int ID)
        {
            return "value";
        }

        public void Post(string value)
        {

        }

        public void Put(int ID, string value)
        {

        }

        public void Delete(int ID)
        {

        }

    }
}