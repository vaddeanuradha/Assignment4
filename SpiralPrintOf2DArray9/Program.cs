using System;

namespace SpiralPrintOf2DArray
{
    class Program
    {
        static void spiralPrint(int r, int c, int[,] arr)
        {
            int i, rIndex = 0, cIndex = 0;
            while (rIndex < r && cIndex < c)
            {
                for (i = cIndex; i < c; i++)
                {
                    Console.Write(arr[rIndex, i] + " ");

                }
                rIndex++;
                for (i = rIndex; i < r; i++)
                {
                    Console.Write(arr[i, c-1] + " ");
                }
                c--;
                if (rIndex < r)
                {
                    for (i = c-1; i >= cIndex; i--)
                    {
                        Console.Write(arr[r-1, i] + " ");
                    }
                    r--;
                }
                if (cIndex < c)
                {
                    for (i = r-1; i >= rIndex; i--)
                    {
                        Console.Write(arr[i, cIndex] + " ");
                    }
                    cIndex++;
                }

            }
        }

        static void Main(string[] args)
        {
            int[,] arr = { {1, 2, 3, 4, 5, 6},
                    {7, 8, 9, 10, 11, 12},
                    {13, 14, 15, 16, 17, 18}
                    };
            int R = arr.GetLength(0);
            int C = arr.GetLength(1);
            spiralPrint(R, C, arr);
            //Console.WriteLine("{0},{1}", R, C);
            Console.Read();
            
        }
    }
}
