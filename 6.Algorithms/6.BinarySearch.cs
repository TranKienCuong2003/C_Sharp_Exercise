using System;

namespace Algorithms
{
    class BinarySearch
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
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    l = mid + 1;
                else
                    r = mid - 1;
            }
            return -1;
        }
    }
}
