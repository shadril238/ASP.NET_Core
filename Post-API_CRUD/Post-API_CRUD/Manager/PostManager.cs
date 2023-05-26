using EF.Core.Repository.Interface.Manager;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using Post_API_CRUD.Context;
using Post_API_CRUD.Interfaces.Manager;
using Post_API_CRUD.Models;
using Post_API_CRUD.Repository;

namespace Post_API_CRUD.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(PostDbContext dbContext) : base(new PostRepository(dbContext))
        {
        }

        public Post GetById(int id)
        {
            return GetFirstOrDefault(p=>p.Id== id);
        }
    }
}
