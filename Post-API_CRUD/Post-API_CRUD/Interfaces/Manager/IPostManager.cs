//shadril238
using EF.Core.Repository.Interface.Manager;
using Post_API_CRUD.Models;

namespace Post_API_CRUD.Interfaces.Manager
{
    public interface IPostManager : ICommonManager<Post>
    {
        Post GetById(int id);
        ICollection<Post> GetAll(string title);
        ICollection<Post> SearchPost(string text);
        ICollection<Post> GetPosts(int page, int pageSize);
    }
}
