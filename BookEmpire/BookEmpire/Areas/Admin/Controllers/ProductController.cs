// shadril238
using BookEmpire.DataAccess.Repositories.IRepository;
using BookEmpire.Models;
using BookEmpire.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookEmpire.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var objProductList = _unitOfWork.Product.GetAll().ToList();
            return View(objProductList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            // Projection
            IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category
                .GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                });
            //ViewBag.CategoryList = CategoryList;
            ProductVM productVM = new()
            {
                CategoryList= CategoryList,
                Product=new Product()
            };
            return View(productVM);
        }
        [HttpPost]
        public IActionResult Create(ProductVM obj)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.Product.Add(obj.Product);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? productFromDb = _unitOfWork.Product.Get(p => p.Id == id);

            if (productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(product);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully";
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
            Product? productFromDb = _unitOfWork.Product.Get(p => p.Id == id);

            if (productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteProduct(int? id)
        {
            Product? product = _unitOfWork.Product.Get(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
