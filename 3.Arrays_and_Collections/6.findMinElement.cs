using System;

namespace Arrays_and_Collections
{
    class findMinElement
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min element: " + min);
        }
    }
}