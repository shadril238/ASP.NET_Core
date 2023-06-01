using BookEmpire.DataAccess.Contexts;
using BookEmpire.DataAccess.Repositories.IRepository;
using BookEmpire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookEmpire.DataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly BookEmpireDbContext _db;
        public CategoryRepository(BookEmpireDbContext db) : base(db)
        {
            this._db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
