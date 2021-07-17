using System;
using System.Collections.Generic;
using System.Text;

namespace WIRED_BRAIN_COFFIE_COMPANY
{
    public class GenericSimpleStack<T>
    {
        public T[] _items;
        public int currentIndex = -1;
        public GenericSimpleStack()
        {
            _items = new T[10];
        }

        public void Push(T item) {

            _items[++currentIndex] = item;
        }

        public int Count => currentIndex + 1;

        public T Pop() {

            return _items[currentIndex--];
        }

    }
}
