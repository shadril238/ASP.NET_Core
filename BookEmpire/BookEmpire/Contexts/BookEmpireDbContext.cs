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

        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1},
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2},
                new Category { Id = 3, Name = "History", DisplayOrder = 3}
            );
        }

    }
}
