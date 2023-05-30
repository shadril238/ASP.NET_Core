using BookEmpireRazor_Temp.Contexts;
using BookEmpireRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookEmpireRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly BookEmpireDbContext _db;
        public Category Category { get; set; }

        public DeleteModel(BookEmpireDbContext db)
        {
            this._db = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id > 0)
            {
                Category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            Category? obj = _db.Categories.Find(Category.Id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
