using BookEmpire.Contexts;
using BookEmpire.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookEmpire.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookEmpireDbContext _db;
        public CategoryController(BookEmpireDbContext db) 
        {
            this._db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(); 
        }
    }
}
