using System;

namespace SearchingAlgorithms
{
    class LinearSearch
    {
        public static void Run()
        {
            int[] arr = { 2, 5, 8, 12, 7, 6, 10 };
            int target = 12;

            int result = LinearSearchAlgorithm(arr, target);

            if (result == -1)
            {
                Console.WriteLine("Element not found.");
            }
            else
            {
                Console.WriteLine("Element found at index: " + result);
            }
        }

        static int LinearSearchAlgorithm(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
