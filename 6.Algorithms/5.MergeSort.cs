using System;

namespace Algorithms
{
    class MergeSort
    {
        public static void Run()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }

        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (int i = 0; i < n2; i++)
                R[i] = arr[m + 1 + i];

            int j = 0, k = 0, l1 = l;
            while (j < n1 && k < n2)
            {
                if (L[j] <= R[k])
                {
                    arr[l1] = L[j];
                    j++;
                }
                else
                {
                    arr[l1] = R[k];
                    k++;
                }
                l1++;
            }

            while (j < n1)
            {
                arr[l1] = L[j];
                j++;
                l1++;
            }

            while (k < n2)
            {
                arr[l1] = R[k];
                k++;
                l1++;
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
