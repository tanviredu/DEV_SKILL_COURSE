using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WIREDBRAINCOFFIE_STORAGE_APP.Entities;

namespace WIREDBRAINCOFFIE_STORAGE_APP.Repository
{
    public class GenericRepository<T> where T :EntityBase
    {
        protected List<T> _items;

        public GenericRepository()
        {
            // list is initiated in the constructor
            _items = new List<T>();
        }

        public T GetById(int Id) {

            return _items.Single(item => item.Id == Id);
        }

        public void Add(T item) {

            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save() {

            foreach (var item in _items) {

                Console.WriteLine(item);
            
            }
        
        }

    }
}
