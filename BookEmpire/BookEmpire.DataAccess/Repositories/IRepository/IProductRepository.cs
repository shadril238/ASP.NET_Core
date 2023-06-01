// shadril238
using BookEmpire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEmpire.DataAccess.Repositories.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);   
    }
}
