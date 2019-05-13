using System;

namespace DutchNationalFlag5A
{
    class Program
    {
        static void printArray(int[] arr, int arr_size)
        {
            int i;

            for (i = 0; i < arr_size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int size = arr.Length;
            int lo = 0;
            int hi = size - 1;
            int mid = 0, temp = 0;

            while (mid <= hi)
            {
                switch (arr[mid])
                {
                    case 0:
                        {
                            temp = arr[lo];
                            arr[lo] = arr[mid];
                            arr[mid] = temp;
                            lo++;
                            mid++;
                            break;
                        }
                    case 1:
                        mid++;
                        break;
                    case 2:
                        {
                            temp = arr[mid];
                            arr[mid] = arr[hi];
                            arr[hi] = temp;
                            hi--;
                            break;
                        }
                }
            }
            Console.Write("Array after seggregation ");
            printArray(arr, size);
            Console.Read();
        }
    }
}
