using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintDecreseFrequency10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };
            int size = arr.Length;
            Dictionary<int, int> d = new Dictionary<int, int>();
            for(int i =0;i<size;i++)
            {
                if (!d.ContainsKey(arr[i]))
                { 
                    d.Add(arr[i], 1);
                }
                else
                    d[arr[i]]++;
            }


            var items = from pair in d
                        orderby pair.Value descending
                        select pair;
            foreach (KeyValuePair<int, int> pair in items)
            {
                for(int i=0;i<pair.Value;i++)
                Console.Write(pair.Key+" ");
            }

            Console.WriteLine();

            //foreach (var item in items)
            //{
            //    Console.Write(item + " ");
            //}
            Console.Read();
        }
    }
}
