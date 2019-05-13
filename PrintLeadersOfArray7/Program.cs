using System;

namespace PrintLeadersOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] Arr = { 16, 17, 4, 3, 5, 2 };
            int size = Arr.Length;
            Console.WriteLine("The input Array is : ");
            for (int i = 0; i < size; i++)
                Console.Write("{0}  ",Arr[i]);
            Console.WriteLine();     
            Console.WriteLine("The Leaders of this Arr is: ");
            for (int i=0;i<size;i++)
            {
                int j;
                for (j=i+1;j<size;j++)
                {
                    if (Arr[i] <= Arr[j])
                        break;
                }
                if (j == size)
                    Console.Write("{0}  ",Arr[i]);
            }
            Console.Read();
        }
    }
}
