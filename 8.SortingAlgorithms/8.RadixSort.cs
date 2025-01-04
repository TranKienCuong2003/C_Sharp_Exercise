using System;

namespace SortingAlgorithms
{
    class RadixSort
    {
        public static void Run()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            RadixSortAlgorithm(arr);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void RadixSortAlgorithm(int[] arr)
        {
            int max = GetMax(arr);
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(arr, exp);
            }
        }

        static void CountSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            Array.Copy(output, 0, arr, 0, n);
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
