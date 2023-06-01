using BookEmpire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEmpire.DataAccess.Repositories.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    { 
        void Update(Category category);
        void Save();
    }
}
