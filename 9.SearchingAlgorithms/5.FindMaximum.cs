using System;

namespace SearchingAlgorithms
{
    class FindMaximum
    {
        public static void Run()
        {
            int[] arr = { 10, 20, 5, 12, 15, 1 };
            int maxElement = FindMax(arr);
            Console.WriteLine("The maximum element is: " + maxElement);
        }

        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
