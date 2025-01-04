using System;

namespace SearchingAlgorithms
{
    class Search2DArray
    {
        public static void Run()
        {
            int[,] arr = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int target = 5;
            var result = SearchElement(arr, target);

            if (result == null)
            {
                Console.WriteLine("Element not found.");
            }
            else
            {
                Console.WriteLine("Element found at row " + result.Value.Item1 + " and column " + result.Value.Item2);
            }
        }

        static (int, int)? SearchElement(int[,] arr, int target)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == target)
                    {
                        return (i, j);
                    }
                }
            }
            return null;
        }
    }
}
