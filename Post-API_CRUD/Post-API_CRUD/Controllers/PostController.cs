using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Post_API_CRUD.Context;
using Post_API_CRUD.Interfaces.Manager;
using Post_API_CRUD.Manager;
using Post_API_CRUD.Models;
using System.Net;

namespace Post_API_CRUD.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //public class PostController : ControllerBase
    public class PostController : BaseController
    {
        //PostDbContext db;
        //PostManager postManager;
        //public PostController(PostDbContext db) 
        //{
        //    this.db = db;
        //    postManager= new PostManager(db);
        //}

        IPostManager postManager;
        public PostController(IPostManager postManager)
        {
            this.postManager = postManager;
        }

        [HttpGet]
        //public ActionResult<List<Post>> Get()
        public IActionResult GetAll()
        {
            try
            {
                //return db.Posts.ToList();
                var posts = postManager.GetAll().OrderBy(p=> p.CreatedDate).ThenBy(p=> p.Title).ToList();
                return CustomResult("Data loaded successfully", posts);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);  
            }
        }

        [HttpGet]
        public IActionResult GetAllDesc()
        {
            try
            {
                var posts = postManager.GetAll().OrderByDescending(p => p.CreatedDate).ThenByDescending(p=> p.Title).ToList();
                return CustomResult("Data loaded successfully", posts);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpGet("id")]
        //public ActionResult<Post> GetById(int id)
        public IActionResult GetById(int id)
        {
            try
            {
                var post = postManager.GetById(id);
                if (post == null)
                {
                    return CustomResult("Data not found", HttpStatusCode.NotFound);
                }
                return CustomResult("Data Found", post);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        //public ActionResult<Post> Add(Post post)
        public IActionResult Add(Post post)
        {
            try
            {
                //post.CreatedDate= DateTime.Now;
                //db.Posts.Add(post);
                //if (db.SaveChanges() > 0)
                //{
                //    return post;
                //}
                //return null;

                var isSaved = postManager.Add(post);
                if (isSaved)
                {
                    //return Created("", post);
                    return CustomResult("Post Created", post);
                }
                return CustomResult("Post save failed", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        public IActionResult Edit(Post post)
        {
            try
            {
                if (post.Id == 0)
                {
                    return CustomResult("Id is missing", HttpStatusCode.BadRequest);
                }

                var isUpdate = postManager.Update(post);
                if (isUpdate)
                {
                    return CustomResult("Post updated successfully", post);
                }
                return CustomResult("Post updated failed", HttpStatusCode.BadRequest) ;
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                var post = postManager.GetById(id);
                if (post == null)
                {
                    return CustomResult("Data not found", HttpStatusCode.NotFound);
                }
                var isDelete = postManager.Delete(post);
                if (isDelete)
                {
                    return CustomResult("Post has been deleted");
                }
                return CustomResult("Post delete failed", HttpStatusCode.BadRequest);
            }
            catch(Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }
    }
}
