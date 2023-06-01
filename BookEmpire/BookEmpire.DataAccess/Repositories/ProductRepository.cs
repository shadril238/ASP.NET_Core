// shadril238
using BookEmpire.DataAccess.Contexts;
using BookEmpire.DataAccess.Repositories.IRepository;
using BookEmpire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEmpire.DataAccess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly BookEmpireDbContext _db;
        public ProductRepository(BookEmpireDbContext db) : base(db)
        {
            this._db = db;
        }
        public void Update(Product product)
        {
            _db.Products.Update(product);
        }
    }
}
