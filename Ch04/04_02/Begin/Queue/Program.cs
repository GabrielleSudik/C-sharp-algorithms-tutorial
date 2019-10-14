using static System.Console;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //the code in the main method is written last

            Queue myQueue = new Queue(5); //limit number of items to 5
            myQueue.Insert(30);
            myQueue.Insert(35);
            myQueue.Insert(40);
            myQueue.Insert(45); //prints last because FIFO.
            myQueue.View();

            WriteLine($"Front of the queue is {myQueue.PeekFront()}");

            WriteLine("Remove an item from the queue:");
            myQueue.Remove(); //that method is set to remove item from the front
            WriteLine($"Front of the queue is {myQueue.PeekFront()}");

        }
    }

    //first, create Queue class:
    public class Queue
    {
        private int maxSize;
        private long[] myQueue; //the container -- the queue.
        private int front;
        private int rear;
        private int items;

        //constructor:
        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0; //front is 0 when one element gets in the queue
            rear = -1; //initial end of queue is -1 because no one is in the queue yet.
            items = 0; //initial number of elements in the queue
        }

        public void Insert(long j)
        {
            //first, check if queue is full:
            if (IsFull())
            {
                WriteLine("QUeue is full.");
            }
            else
            {
                //as you add new elements to the queue,
                //keep moving the end of queue "back" a number
                //ie, increase the index of rear from -1 to whatever
                //and put the new element in it
                //then increase the number of items.
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }

        //method to check if the queue is full.
        private bool IsFull()
        {
            return (items == maxSize);
        }

        //method to remove an item from the front:
        public long Remove()
        {
            long temp = myQueue[front];
            front++;
            if (front==maxSize)
            {
                front = 0;
            }

            return temp;
        }

        //method to peek at the front:
        public long PeekFront()
        {
            return myQueue[front];
        }

        //method to check if queue is empty:
        public bool IsEmpty()
        {
            return (items == 0);
        }

        //method to view the content of the queue:
        public void View()
        {
            Write("[");
            for (int i = 0; i < myQueue.Length; i++)
            {
                Write(myQueue[i] + " ");
            }
            WriteLine("]");
        }
    }
}
