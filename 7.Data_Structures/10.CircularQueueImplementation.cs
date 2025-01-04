using System;

namespace DataStructures
{
    class CircularQueueImplementation
    {
        public static void Run()
        {
            CircularQueue queue = new CircularQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Queue elements:");
            queue.PrintQueue();

            queue.Dequeue();
            Console.WriteLine("Queue after dequeue:");
            queue.PrintQueue();
        }
    }

    public class CircularQueue
    {
        private int[] arr;
        private int front, rear, size;

        public CircularQueue(int capacity)
        {
            arr = new int[capacity];
            front = rear = -1;
            size = capacity;
        }

        public void Enqueue(int value)
        {
            if ((rear + 1) % size == front)
            {
                Console.WriteLine("Queue is full");
                return;
            }

            if (front == -1)
                front = 0;

            rear = (rear + 1) % size;
            arr[rear] = value;
        }

        public void Dequeue()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % size;
            }
        }

        public void PrintQueue()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            int i = front;
            while (i != rear)
            {
                Console.Write(arr[i] + " ");
                i = (i + 1) % size;
            }
            Console.WriteLine(arr[rear]);
        }
    }
}
