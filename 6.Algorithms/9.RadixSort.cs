using System;

namespace Algorithms
{
    class RadixSort
    {
        public static void Run()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            Sort(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        public static void Sort(int[] arr)
        {
            int m = GetMax(arr);
            for (int exp = 1; m / exp > 0; exp *= 10)
            {
                CountSort(arr, exp);
            }
        }

        public static void CountSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];
            for (int i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
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
