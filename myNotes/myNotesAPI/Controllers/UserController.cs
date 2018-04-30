using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using myNotesAPI.Models;

namespace myNotesAPI.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;

            if (_context.User.Count() == 0)
            {
                _context.User.Add(new User { Name = "Usr1" });
                _context.SaveChanges();
            }
        }
    }
}