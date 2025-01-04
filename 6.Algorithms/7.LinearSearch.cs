using System;

namespace Algorithms
{
    class LinearSearch
    {
        public static void Run()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int target = 10;

            int result = Search(arr, target);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }

        public static int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
