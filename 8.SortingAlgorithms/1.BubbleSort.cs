using System;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        public static void Run()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            BubbleSortAlgorithm(arr);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
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
