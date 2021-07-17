using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WIREDBRAINCOFFIE_STORAGE.Entities;

namespace WIREDBRAINCOFFIE_STORAGE.Repositories
{
    public class ListRepository<T> where T:IEntityBase
    {

        protected List<T> _items;
        public T GetByID(int id) {

            return _items.Single(item => item.Id == id);
        }
        public ListRepository()
        {
            _items = new List<T>();
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

            foreach (var item in _items)
            {

                Console.WriteLine(item);
            }

        }
    }

}

