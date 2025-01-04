using System;

namespace SortingAlgorithms
{
    class MergeSort
    {
        public static void Run()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Array before sorting:");
            PrintArray(arr);

            MergeSortAlgorithm(arr, 0, arr.Length - 1);

            Console.WriteLine("Array after sorting:");
            PrintArray(arr);
        }

        static void MergeSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortAlgorithm(arr, left, mid);
                MergeSortAlgorithm(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            Array.Copy(arr, left, leftArr, 0, n1);
            Array.Copy(arr, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
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
