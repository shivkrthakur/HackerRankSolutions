using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());
	    int [] input = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
        var map = new Dictionary<int,int>();
        int k = 0; while(k < n) map[input[k]] = k++;
        
        int [] N = new int[n];
        int [] NC = new int[n];
        Array.Copy(input, N, n);
        Array.Copy(input, NC, n);
        Array.Sort(NC);

        int swaps = 0;
        for(int i = 0; i < n; i++)
        {
            int unSortedVal = N[i];
            int sortedVal = NC[i];
            if(unSortedVal != sortedVal) 
            {
                swaps++;
                int sortedValIndex = map[sortedVal];
                N[i] = sortedVal;
                N[sortedValIndex] = unSortedVal;
                map[unSortedVal] = sortedValIndex;
            }
        }
        
        k = 0; while(k < n) map[input[k]] = k++;
        Array.Copy(input, N, n);
        Array.Copy(input, NC, n);
        Array.Sort(NC);
        Array.Reverse(NC);

        int rSwaps = 0;
        for(int i = n - 1; i >= 0; i--)
        {
            int unSortedVal = N[i];
            int sortedVal = NC[i];
            if(unSortedVal != sortedVal) 
            {
                rSwaps++;
                int sortedValIndex = map[sortedVal];
                N[i] = sortedVal;
                N[sortedValIndex] = unSortedVal;
                map[unSortedVal] = sortedValIndex;
            }
        }
        //Console.WriteLine($"swaps:{swaps}    rSwaps:{rSwaps}");
        Console.WriteLine($"{Math.Min(swaps,rSwaps)}");
    }
}