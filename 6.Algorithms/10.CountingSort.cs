using System;

namespace Algorithms
{
    class CountingSort
    {
        public static void Run()
        {
            int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            Sort(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        public static void Sort(int[] arr)
        {
            int max = GetMax(arr);
            int[] count = new int[max + 1];
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                count[arr[i]]++;

            for (int i = 1; i <= max; i++)
                count[i] += count[i - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            for (int i = 0; i < arr.Length; i++)
                arr[i] = output[i];
        }

        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
