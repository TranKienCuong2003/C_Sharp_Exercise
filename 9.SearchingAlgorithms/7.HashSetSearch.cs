using System;
using System.Collections.Generic;

namespace SearchingAlgorithms
{
    class HashSetSearch
    {
        public static void Run()
        {
            HashSet<int> set = new HashSet<int> { 1, 3, 5, 7, 9 };
            int target = 5;

            if (set.Contains(target))
            {
                Console.WriteLine("Element found in the set.");
            }
            else
            {
                Console.WriteLine("Element not found in the set.");
            }
        }
    }
}
