using BookEmpire.DataAccess.Contexts;
using BookEmpire.DataAccess.Repositories.IRepository;
using BookEmpire.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookEmpire.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository db) 
        {
            _categoryRepo = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var objCategoryList = _categoryRepo.GetAll().ToList();
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
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The Display Order can not exactly match the Category Name.");
            }

            if (ModelState.IsValid)
            {
                _categoryRepo.Add(category);
                _categoryRepo.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(); 
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _categoryRepo.Get(c => c.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(c=> c.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(c=> c.Id == id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The Display Order can not exactly match the Category Name.");
            }

            if (ModelState.IsValid)
            {
                _categoryRepo.Update(category);
                _categoryRepo.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDb = _categoryRepo.Get(c => c.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(c=> c.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(c=> c.Id == id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteCategory(int? id)
        {
            Category? category = _categoryRepo.Get(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            _categoryRepo.Remove(category);
            _categoryRepo.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
