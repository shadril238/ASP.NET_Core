using BookEmpireRazor_Temp.Contexts;
using BookEmpireRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookEmpireRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly BookEmpireDbContext _db;
        public List<Category> CategoryList { get; set; }

        public IndexModel(BookEmpireDbContext db)
        {
            this._db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
