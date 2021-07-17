namespace AllDataStructure
{
    public class Queue : IQueue
    {
        private int front, rear, capacity;
        private int[] _queue;

        public Queue(int c)
        {
            front = 0;
            rear = 0;
            capacity = c;
            _queue = new int[capacity];
        }

        public void Enqueue(int data)
        {

            if (capacity == rear)
            {
                System.Console.WriteLine("Queue is Full");
            }
            else
            {
                // insert the element from the rear
                _queue[rear] = data;
                rear++;
            }

        }


        public void Dequeue()
        {

            if (front == rear)
            {
                System.Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                // search from the top
                for (int i = 0; i < rear - 1; i++)
                {
                    _queue[i] = _queue[i + 1];
                    rear--;
                }



            }
        }

        public void queueDisplay()
        {


            if (front == rear)
            {
                System.Console.WriteLine("Queue is empty");
                return;

            }
            else
            {
                for (int i = front; i < rear; i++)
                {

                    System.Console.WriteLine(_queue[i]);
                }
            }
        }
    }
}