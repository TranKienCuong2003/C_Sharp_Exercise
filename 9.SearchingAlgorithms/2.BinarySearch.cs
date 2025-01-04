using System;

namespace SearchingAlgorithms
{
    class BinarySearch
    {
        public static void Run()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int target = 9;

            int result = BinarySearchAlgorithm(arr, target);

            if (result == -1)
            {
                Console.WriteLine("Element not found.");
            }
            else
            {
                Console.WriteLine("Element found at index: " + result);
            }
        }

        static int BinarySearchAlgorithm(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
