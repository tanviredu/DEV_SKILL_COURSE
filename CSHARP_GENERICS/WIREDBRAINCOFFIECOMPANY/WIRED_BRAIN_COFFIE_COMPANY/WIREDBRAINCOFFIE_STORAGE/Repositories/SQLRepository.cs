using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WIREDBRAINCOFFIE_STORAGE.Entities;

namespace WIREDBRAINCOFFIE_STORAGE.Repositories
{
    public class SQLRepository<T> : ISQLRepository<T> where T : class, IEntityBase
    {

        protected List<T> _items;
        private DbContext _dbcontext;
        private DbSet<T> _dbSet;

        public T GetByID(int id)
        {

            return _items.Single(item => item.Id == id);
        }
        public SQLRepository(DbContext dbcontext)
        {
            _items = new List<T>();
            _dbcontext = dbcontext;
            _dbSet = _dbcontext.Set<T>();
        }
        public void Add(T item)
        {

            item.Id = _items.Count + 1;
            _items.Add(item);

        }

        public void Remove(T item)
        {

            _items.Remove(item);

        }


        public void Save()
        {
            _dbcontext.SaveChanges();

        }
    }

}

