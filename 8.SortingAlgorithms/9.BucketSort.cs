using System;

namespace SortingAlgorithms
{
    class BucketSort
    {
        public static void Run()
        {
            double[] arr = { 0.42, 0.32, 0.72, 0.58, 0.83, 0.54 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            BucketSortAlgorithm(arr);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void BucketSortAlgorithm(double[] arr)
        {
            int n = arr.Length;
            if (n <= 0) return;

            var bucket = new List<double>[n];

            for (int i = 0; i < n; i++)
            {
                int index = (int)(arr[i] * n);
                if (bucket[index] == null)
                {
                    bucket[index] = new List<double>();
                }
                bucket[index].Add(arr[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (bucket[i] != null)
                {
                    bucket[i].Sort();
                }
            }

            int indexArr = 0;
            for (int i = 0; i < n; i++)
            {
                if (bucket[i] != null)
                {
                    foreach (var num in bucket[i])
                    {
                        arr[indexArr++] = num;
                    }
                }
            }
        }

        static void PrintArray(double[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
