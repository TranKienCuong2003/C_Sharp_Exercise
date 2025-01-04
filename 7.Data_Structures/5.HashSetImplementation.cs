using System;
using System.Collections.Generic;

namespace DataStructures
{
    class HashSetImplementation
    {
        public static void Run()
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(2);

            Console.WriteLine("HashSet elements:");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
