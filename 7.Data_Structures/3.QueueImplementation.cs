using System;
using System.Collections.Generic;

namespace DataStructures
{
    class QueueImplementation
    {
        public static void Run()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Queue after enqueuing elements:");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            queue.Dequeue();
            Console.WriteLine("Queue after dequeuing an element:");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
