using System;

namespace Arrays_and_Collections
{
    class declareAndInitializeArray
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}