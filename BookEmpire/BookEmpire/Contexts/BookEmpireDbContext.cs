using BookEmpire.Models;
using Microsoft.EntityFrameworkCore;

namespace BookEmpire.Contexts
{
    public class BookEmpireDbContext : DbContext
    {
        public BookEmpireDbContext(DbContextOptions<BookEmpireDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
