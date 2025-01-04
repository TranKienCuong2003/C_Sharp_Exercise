using System;

namespace SearchingAlgorithms
{
    class LinkedListSearch
    {
        public static void Run()
        {
            var list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            int target = 20;

            if (Search(list, target))
            {
                Console.WriteLine("Element found in the linked list.");
            }
            else
            {
                Console.WriteLine("Element not found in the linked list.");
            }
        }

        static bool Search(LinkedList<int> list, int target)
        {
            foreach (var item in list)
            {
                if (item == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
