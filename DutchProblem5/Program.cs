using System;
using System.Collections.Generic;


namespace DutchProblem5
{
    class Program
    {
        public static void Main()
        {
            int[] Arr = { 0, 1, 2, 0, 1, 2, 0, 1, 2, 1 };
            //int count = 0;

            Dictionary<int, int> d = new Dictionary<int, int>();

            //i am adding keys and their count as value in my dictionary 
            // if there is key i am going to increase value 
            //there is no key i am going to add that key and assign the value is 1

            for (int i = 0; i < Arr.Length; i++)
            {
                if (!d.ContainsKey(Arr[i]))
                {
                    d.Add(Arr[i], 1);
                }

                else
                    d[Arr[i]]++;
            }
           // getting count of 0's , 1's and 2's 
            int count0 = d[0], count1 = d[1], count2 = d[2];
             //assign 0's according to their count into my existing array   
             //0's are going to assign from starting index to till 0's count
            for (int i = 0; i < count0; i++)
                Arr[i] = 0;
            //assign 1's according to their count into my existing array  
            //1's are going to assign after 0's count to till 0's and 1's count
            
            for (int i = count0; i < count0 + count1; i++)
                Arr[i] = 1;
            //assign 2's according to their count into my existing array  
            //1's are going to assign after 0's and 1's count to till array length
            for (int i = count0 + count1; i < Arr.Length; i++)
                Arr[i] = 2;
            for (int i = 0; i < Arr.Length; i++)
                Console.Write(" " + Arr[i]);
            Console.WriteLine();

            //Console.WriteLine("The count of 0's is:" + count0);
            Console.Read();

        }

    }
}
