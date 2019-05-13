using System;

namespace FindEquilibriumIndex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { -7, 1, 5, 2, -4, 3, 0 };
            int size = Arr.Length;
            int leftsum=0, sum=0;
            for (int i = 0; i < size; i++)
                sum += Arr[i];
            for (int j=0;j<size;j++)
            {
                
                sum -= Arr[j];
                if (sum==leftsum)
                {
                    Console.WriteLine("The Equilibrium Index is:  {0}", j);
                    Console.Read();
                    break;
                    
                }
                leftsum += Arr[j];
            }
            Console.WriteLine("No Eqilibrium Index Fount:");
            Console.Read();


        }
    }
}
