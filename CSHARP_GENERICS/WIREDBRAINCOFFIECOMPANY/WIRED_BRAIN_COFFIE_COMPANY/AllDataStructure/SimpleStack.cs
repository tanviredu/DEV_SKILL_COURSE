using System;
using System.Collections.Generic;
using System.Text;
namespace AllDataStructure
{
    /// <summary>
    /// implement a basic stack in c#
    /// </summary>
    public class SimpleStack<T> : ISimpleStack<T>
    {
        private int MAX = 1000;
        private int top;
        private T[] _stack;

        public SimpleStack()
        {
            top = -1;
            _stack = new T[MAX];

        }
        public bool IsEmpty()
        {
            return (top < 0);
        }

        public void Peek()
        {
            if (top < 0) {
                Console.WriteLine("stack underflow");
            }
            else
            {
                Console.WriteLine($"TOP is {_stack[top]}");
            }
        }

        public T Pop()
        {
          
            var value = _stack[top--];
            return value;
            
        }

        public void PrintStack()
        {
            for (int i = top; i >= 0; i--) {
                Console.WriteLine(_stack[i]);
            }
        }

        public bool Push(T item)
        {
            _stack[++top] = item;
            return true;
        }
    }
}
