//shadril238
using BookEmpireRazor_Temp.Contexts;
using BookEmpireRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookEmpireRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly BookEmpireDbContext _db;
        public Category Category { get; set; }

        public EditModel(BookEmpireDbContext db)
        {
            this._db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id > 0)
            {
                Category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            //if (Category.Name == Category.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("Name", "The Display Order can not exactly match the Category Name.");
            //}

            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
