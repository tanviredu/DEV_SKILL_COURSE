using System;

namespace AllDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new SimpleStack<String>();
            //arraystack(stack);
            var myqueue = new Queue(10);
            myqueue.Enqueue(10);
            myqueue.Enqueue(11);
            myqueue.Enqueue(12);
            myqueue.Enqueue(13);
            myqueue.Enqueue(14);
            myqueue.queueDisplay();
            myqueue.Dequeue();
            myqueue.Dequeue();
            myqueue.Dequeue();
            myqueue.queueDisplay();



        }

        private static void arraystack(SimpleStack<string> stack)
        {
            stack.Push("Tanvir Rahman");
            stack.Push("ornob Rahman");
            stack.Push("julia Rahman");
            stack.PrintStack();
            var last_value = stack.Pop();
            Console.WriteLine($"Last Value {last_value}");
            stack.Peek();
            stack.IsEmpty();
        }
    }
}
