using System;

namespace Algorithms
{
    class HeapSort
    {
        public static void Run()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            Sort(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);

                Heapify(arr, i, 0);
            }
        }

        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);
                Heapify(arr, n, largest);
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
