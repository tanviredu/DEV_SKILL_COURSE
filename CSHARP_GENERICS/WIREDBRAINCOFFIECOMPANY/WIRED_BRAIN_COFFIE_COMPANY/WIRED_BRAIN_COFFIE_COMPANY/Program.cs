using System;
using System.Collections.Generic;

namespace WIRED_BRAIN_COFFIE_COMPANY
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackDouble();
            //StackString();
            //StackGeneric();
            CollectionGenericStackClass();
            Console.ReadLine();
            
        }

        private static void CollectionGenericStackClass()
        {
            
            //.net generic stack class
            var stack = new Stack<Double>();
            stack.Push(1.2);
            stack.Push(2.2);
            stack.Push(3.2);

            while (stack.Count > 0) {

                Console.WriteLine($"Item : {stack.Pop()}");
            }
        }

        private static void StackGeneric()
        {
            var stack = new GenericSimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.2);
            stack.Push(3.2);
            stack.Push(4.2);

            while (stack.Count > 0) {

                Console.WriteLine(stack.Pop());
            
            }

            var stringStack = new GenericSimpleStack<string>();
            stringStack.Push("Tanvir");
            stringStack.Push("rahman");
            stringStack.Push("Örnob");
            stringStack.Push("string Value");

            while (stringStack.Count > 0) {

                Console.WriteLine(stringStack.Pop());
                
            }

        }

        private static void StackString()
        {
            var stack = new SimpleStackString();
            stack.Push("Wired Brain Coffie");
            stack.Push("Pluralsight");
            while (stack.Count > 0) {

                Console.WriteLine(stack.Pop()); 
            }

        }

        private static void StackDouble()
        {
            var stack = new SimpleStackDouble();
            stack.Push(1.2);
            stack.Push(2.2);
            stack.Push(3.2);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                var item = (double)stack.Pop();
                Console.WriteLine($"ITEM : {item}");
                sum += item;
            }

            Console.WriteLine($"SUM : {sum}");
        }
    }
}
