using System;

namespace DataStructures
{
    class LinkedListImplementation
    {
        public static void Run()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine("Linked List elements:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.RemoveFirst();
            Console.WriteLine("Linked List after removing the first element:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
