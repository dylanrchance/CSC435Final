using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myNotesAPI.Models
{
    public class CategoryContext : DbContext
    {
        public CategoryContext() : base("myNote")
        { }
        public DbSet<Category> Category { get; set; }
    }
}
