using System;

namespace SubArrayLargestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 3, 4, -3, -2, 1, 5, -3 };

            int size = arr.Length;
            int Max = int.MinValue,
                CurrentMax = 0, start=0,end=0,t=0;

            for (int i = 0; i < size; i++)
            {
                CurrentMax = CurrentMax + arr[i];

                if (Max < CurrentMax)
                {
                    Max = CurrentMax;
                    start = t;
                    end = i;
                }
                if (CurrentMax < 0)
                {
                    CurrentMax = 0;
                    t = i + 1;
                }
            }
      
            Console.WriteLine("The Maximum sum of Contiguous SubArray {0}", Max);
            Console.WriteLine("Starting Index {0}", start);
            Console.WriteLine("Ending Index {0}", end);

            Console.ReadLine();
        }
    }
}
