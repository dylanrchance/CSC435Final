using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using myNotes.Models;

namespace myNotes.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;

            if (_context.User.Count() == 0)
            {
                _context.User.Add(new User { Name = "User1" });
                _context.SaveChanges();
            }
        }
    }
}