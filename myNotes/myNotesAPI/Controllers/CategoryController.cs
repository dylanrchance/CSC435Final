using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using myNotesAPI.Models;

namespace myNotesAPI.Controllers
{
    [Route("api/Category")]
    //[ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryContext _context;

        public CategoryController(CategoryContext context)
        {
            _context = context;

            if (_context.Category.Count() == 0)
            {
                _context.Category.Add(new Category { Name = "Cat1" });
                _context.SaveChanges();
            }
        }


        //[HttpGet]
        //public ActionResult<List<Category>> GetAll()
        //{
        //    return _context.Category.ToList();
        //}

        //[HttpGet("{id}", Name = "Category")]
        //public ActionResult<Category> GetById(long id)
        //{
        //    var item = _context.Category.Find(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    return item;
        //}
    }
}