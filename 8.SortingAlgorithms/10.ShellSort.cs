using System;

namespace SortingAlgorithms
{
    class ShellSort
    {
        public static void Run()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            ShellSortAlgorithm(arr);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void ShellSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
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
