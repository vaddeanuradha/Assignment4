using System;
using System.Linq;

namespace FindKthSmallestElement8
{
    class Program
    {
        public static int partition(int[] arr,
                            int s, int e)
        {
            int x = arr[e], i = s;
            int temp = 0;
            for (int j = s; j <= e - 1; j++)
            {

                if (arr[j] <= x)
                {
                    // Swapping arr[i] and arr[j]  
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                }
            }

            // Swapping arr[i] and arr[r]  
            temp = arr[i];
            arr[i] = arr[e];
            arr[e] = temp;

            return i;
        }
        // This function returns k'th smallest  
        // element in arr[l..r] using QuickSort  
        // based method. ASSUMPTION: ALL ELEMENTS  
        // IN ARR[] ARE DISTINCT  
        public static int kthSmallest(int[] arr, int s,
                                          int e, int k)
        {
            // If k is smaller than number  
            // of elements in array  
            if (k > 0 && k <= e - s + 1)
            {
                // Partition the array around last  
                // element and get position of pivot  
                // element in sorted array  
                int pos = partition(arr, s, e);

                // If position is same as k  
                if (pos - s == k - 1)
                    return arr[pos];

                // If position is more, recur for  
                // left subarray  
                if (pos - s > k - 1)
                    return kthSmallest(arr, s, pos - 1, k);

                // Else recur for right subarray  
                return kthSmallest(arr, pos + 1, r,
                                   k - pos + s - 1);
            }

            // If k is more than number  
            // of elements in array  
            return int.MaxValue;
        }

        static void Main(string[] args)
        {
            int[] Arr = { 7, 10, 4, 3, 20, 15 };
            Console.WriteLine("Enter K Value to find Kth Smallest value in that array");
            int k = int.Parse(Console.ReadLine());

            Console.Write("K'th smallest element is " +
           kthSmallest(Arr, 0, Arr.Length - 1, k));
            Console.Read();



        }
    }
}
