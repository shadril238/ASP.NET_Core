//shadril238
using Microsoft.EntityFrameworkCore;
using Post_API_CRUD.Models;

namespace Post_API_CRUD.Context
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
