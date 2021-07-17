using System;

namespace WIRED_BRAIN_COFFIE_COMPANY
{
    public class SimpleStackDouble
    {
        private double[] _items;
        private int _currentIndex = -1;
        public SimpleStackDouble()=>_items = new double[10];
        

        public void Push(double item)=>_items[++_currentIndex] = item;

        public int Count => _currentIndex + 1;


        public double Pop() => _items[_currentIndex--];
    }

    public class SimpleStackString
    {
        private string[] _items;
        private int _currentIndex = -1;
        public SimpleStackString() => _items = new string[10];


        public void Push(string item) => _items[++_currentIndex] = item;

        public int Count => _currentIndex + 1;


        public string Pop() => _items[_currentIndex--];
    }

    public class SimpleStackInt {
        
        private long[] _items;
        private int _currentIndex = -1;
        public SimpleStackInt()
        {
            _items = new Int64[10];
        }

        public void push(int item) {

            _items[++_currentIndex] = item;
        }

        public int Count => _currentIndex + 1; // always show at the top index
        public long Pop() {
            return _items[_currentIndex--];
        
        }
    }


}