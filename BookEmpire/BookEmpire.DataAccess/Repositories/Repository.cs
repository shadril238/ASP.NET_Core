﻿// shadril238
using BookEmpire.DataAccess.Contexts;
using BookEmpire.DataAccess.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookEmpire.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookEmpireDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(BookEmpireDbContext db)
        {
            this._db = db;
            this.dbSet = _db.Set<T>(); //dbSet == _db.Categories; when T == Category
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
