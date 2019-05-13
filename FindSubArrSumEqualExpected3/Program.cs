using System;

namespace FindSubArrSumEqualExpected
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 4, 20, 3, 10, 5 };
            int Size = Arr.Length;
            int Start = 0, Curr_Sum = 0;
            int Sum = 23;
            for (int i=0;i<Size;i++)
            {
                if(Curr_Sum > Sum)
                {
                    Curr_Sum = Arr[i-1];
                    Start = i-1;
                }
                if (Curr_Sum==Sum && Sum!=0)
                {
                    Console.WriteLine("Sum Found Between  indexes :" + Start + "  And  " + i);
                    Console.ReadLine();
                    break;
                }
                if(i<Size&&Start<=i)
                   Curr_Sum += Arr[i]; 
                if (i==Size-1)
                {
                    Console.WriteLine("No SubArrayFound!");
                    Console.ReadLine();
                }
                    
                
            }
        }
    }
}
