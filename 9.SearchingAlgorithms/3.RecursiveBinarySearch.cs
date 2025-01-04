using System;

namespace SearchingAlgorithms
{
    class RecursiveBinarySearch
    {
        public static void Run()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int target = 7;

            int result = BinarySearchRecursive(arr, target, 0, arr.Length - 1);

            if (result == -1)
            {
                Console.WriteLine("Element not found.");
            }
            else
            {
                Console.WriteLine("Element found at index: " + result);
            }
        }

        static int BinarySearchRecursive(int[] arr, int target, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                return BinarySearchRecursive(arr, target, mid + 1, high);
            }
            else
            {
                return BinarySearchRecursive(arr, target, low, mid - 1);
            }
        }
    }
}
