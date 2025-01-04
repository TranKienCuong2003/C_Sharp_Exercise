using System;

namespace Algorithms
{
    class QuickSort
    {
        public static void Run()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
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
