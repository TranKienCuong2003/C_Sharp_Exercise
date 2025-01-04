using System;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public static void Run()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            QuickSortAlgorithm(arr, 0, arr.Length - 1);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void QuickSortAlgorithm(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSortAlgorithm(arr, low, pivotIndex - 1);
                QuickSortAlgorithm(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
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
