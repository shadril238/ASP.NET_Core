using BookEmpire.DataAccess.Contexts;
using BookEmpire.DataAccess.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEmpire.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookEmpireDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(BookEmpireDbContext db)
        {
            this._db = db;
            Category = new CategoryRepository(this._db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
