using System;

namespace FindMissingNumProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 3, 2, 5, 4, 7, 9, 8 };
            int Size = Arr.Length;
            int ExpectedSum = (Size + 1) * (Size + 2) / 2;
            for (int i =0;i<Size;i++)
            {
                ExpectedSum -= Arr[i];
            }

            Console.WriteLine("The missing number is {0}", ExpectedSum);
            Console.Read();
        }
    }
}
