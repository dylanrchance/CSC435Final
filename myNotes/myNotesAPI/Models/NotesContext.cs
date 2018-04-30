
using Microsoft.EntityFrameworkCore;

namespace myNotesAPI.Models
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options)
              : base(options)
        { }
        public DbSet<Notes> Notes { get; set; }
    }
}
