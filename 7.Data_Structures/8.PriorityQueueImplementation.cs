using System;
using System.Collections.Generic;

namespace DataStructures
{
    class PriorityQueueImplementation
    {
        public static void Run()
        {
            SortedSet<int> pq = new SortedSet<int>();

            pq.Add(10);
            pq.Add(20);
            pq.Add(5);

            Console.WriteLine("Priority Queue elements:");
            foreach (var item in pq)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
