using System;

namespace Algorithms
{
    class SelectionSort
    {
        public static void Run()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            Sort(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                Swap(ref arr[minIdx], ref arr[i]);
            }
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
