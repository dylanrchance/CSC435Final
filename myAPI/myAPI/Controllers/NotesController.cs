using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using myAPI.Models;

namespace myAPI.Controllers
{
    [Route("api/Notes")]
    //[ApiController]
    public class NotesController : ControllerBase
    {
        private readonly NotesContext _context;

        public NotesController(NotesContext context)
        {
            _context = context;

            if (_context.Notes.Count() == 0)
            {
                _context.Notes.Add(new Notes{ Title = "Item1" });
                _context.SaveChanges();
            }
        }


        public IEnumerable<string> Get()
        {
            return new string[] { "value","value2", "value3" };
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