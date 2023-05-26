using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Post_API_CRUD.Context;
using Post_API_CRUD.Interfaces.Repository;
using Post_API_CRUD.Models;

namespace Post_API_CRUD.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(PostDbContext dbContext) : base(dbContext)
        {
        }
    }
}
