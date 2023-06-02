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
           var objFromDb = _db.Products.FirstOrDefault(p => p.Id == product.Id);

            if (objFromDb != null)
            {
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.Author = product.Author;
                
                if(product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
