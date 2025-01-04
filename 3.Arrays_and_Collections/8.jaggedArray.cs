using System;

namespace Arrays_and_Collections
{
    class jaggedArray
    {
        public static void Run()
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 1, 2, 3 };
            arr[1] = new int[] { 4, 5, 6 };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}