using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using myNotesAPI.Models;

namespace myNotesAPI.Controllers
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
                _context.Notes.Add(new Notes { Title = "Note1" });
                _context.SaveChanges();
            }
        }

        //[HttpGet]
        //public ActionResult<List<Notes>> GetAll()
        //{
        //    return _context.Notes.ToList();
        //}

        //[HttpGet("{id}", Name = "Notes")]
        //public ActionResult<Notes> GetById(long ID)
        //{
        //    var item = _context.Notes.Find(ID);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    return item;
        //}

        [HttpPost]
        public IActionResult Create(Notes item)
        {
            _context.Notes.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("Notes", new { id = item.ID }, item);
        }
    }
}