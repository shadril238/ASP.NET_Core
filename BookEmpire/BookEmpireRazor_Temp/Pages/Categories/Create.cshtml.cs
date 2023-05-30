using BookEmpireRazor_Temp.Contexts;
using BookEmpireRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookEmpireRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly BookEmpireDbContext _db;
        [BindProperty]
        public Category Category { get; set; }

        public CreateModel(BookEmpireDbContext db)
        {
            this._db = db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
