﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NegativeSumEqualsExpected4
{
    class Program
    {
        public static void subArraySum(int[] arr, int n, int sum)
        {
            //cur_sum to keep track of cummulative sum till that point  
            int cur_sum = 0;
            int start = 0;
            int end = -1;
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                cur_sum = cur_sum + arr[i];
                //check whether cur_sum - sum = 0, if 0 it means  
                //the sub array is starting from index 0- so stop  
                if (cur_sum - sum == 0)
                {
                    start = 0;
                    end = i;
                    PrintArr(arr, start, end);
                    cur_sum = 0;
                    continue;

                    //break;
                }
                //if hashMap already has the value, means we already   
                // have subarray with the sum - so stop  
                if (hashMap.ContainsKey(cur_sum - sum))
                {
                    start = hashMap[cur_sum - sum] + 1;
                    end = i;
                    PrintArr(arr, start, end);
                    Console.Read();
                    //break;
                }
                //if value is not present then add to hashmap  
                hashMap[cur_sum] = i;

            }
            // if end is -1 : means we have reached end without the sum  
            if (end == -1)
            {
                Console.WriteLine("No subarray with given sum exists");
                Console.Read();
            }

        }

        public static void PrintArr(int[] arr, int index, int length)
        {
            Console.WriteLine("The interval is " + index + " to " + length);
            StringBuilder sb = new StringBuilder();

            for (int k = index; k <= length; k++)
            {
                sb.Append(String.Format("{0}  ", arr[k]));
            }
            Console.WriteLine(sb.ToString());

        }


        // Driver code  
        public static void Main(string[] args)
        {
            int[] arr = { 3, 4, -7, 1, 3, 3, 1, -4 };
            int n = arr.Length;
            int sum =7;
            subArraySum(arr, n, sum);

        }

    }
}
