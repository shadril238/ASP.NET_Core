//shadril238
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

        public ICollection<Post> GetAll(string title)
        {
            return Get(p=> p.Title.ToLower().Equals(title.ToLower()));
        }

        public Post GetById(int id)
        {
            return GetFirstOrDefault(p=>p.Id== id);
        }

        public ICollection<Post> GetPosts(int page, int pageSize)
        {
            if(page <= 1)
            {
                page = 1;
            }
            int totalNumber=(page-1)*pageSize;
            return GetAll().Skip(totalNumber).Take(pageSize).ToList();
        }

        public ICollection<Post> SearchPost(string text)
        {
            text = text.ToLower();
            return Get(C=> C.Title.ToLower().Contains(text) || C.Description.ToLower().Contains(text));
        }
    }
}
