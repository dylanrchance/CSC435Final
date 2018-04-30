using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using myNotesAPI.Models;

namespace myNotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly NotesContext _context;

        public NotesController(NotesContext context)
        {
            _context = context;

            if (_context.Notes.Count() == 0)
            {
                _context.Notes.Add(new Notes { Title = "Note1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Notes>> GetAll()
        {
            return _context.Notes.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<Notes> GetById(int ID)
        {
            var item = _context.Notes.Find(ID);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}