using System;

namespace SortingAlgorithms
{
    class SelectionSort
    {
        public static void Run()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            SelectionSortAlgorithm(arr);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
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
