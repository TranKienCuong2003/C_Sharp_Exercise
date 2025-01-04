using System;

namespace SearchingAlgorithms
{
    class FindMinimum
    {
        public static void Run()
        {
            int[] arr = { 10, 20, 5, 12, 15, 1 };
            int minElement = FindMin(arr);
            Console.WriteLine("The minimum element is: " + minElement);
        }

        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
