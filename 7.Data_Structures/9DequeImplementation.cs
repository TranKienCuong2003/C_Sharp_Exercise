using System;
using System.Collections.Generic;

namespace DataStructures
{
    class DequeImplementation
    {
        public static void Run()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddFirst(1);
            deque.AddLast(2);
            deque.AddFirst(0);
            deque.AddLast(3);

            Console.WriteLine("Deque elements:");
            foreach (var item in deque)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            deque.RemoveFirst();
            deque.RemoveLast();
            Console.WriteLine("Deque after removing first and last elements:");
            foreach (var item in deque)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public class Deque<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void AddFirst(T value)
        {
            list.AddFirst(value);
        }

        public void AddLast(T value)
        {
            list.AddLast(value);
        }

        public void RemoveFirst()
        {
            if (list.Count > 0)
            {
                list.RemoveFirst();
            }
        }

        public void RemoveLast()
        {
            if (list.Count > 0)
            {
                list.RemoveLast();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
