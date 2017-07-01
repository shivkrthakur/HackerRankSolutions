/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int swapCounter = 0;
        
        for(int i = 0; i < a.Length; i++)
        {
            for(int j = i + 1; j < a.Length; j++)
            {
                if(a[i] > a[j])
                {
                  int x = a[j];
                  a[j] = a[i];
                  a[i] = x;
                  swapCounter++;
                }
            }
        }
        
        Console.WriteLine("Array is sorted in {0} swaps.", swapCounter);
        Console.WriteLine("First Element: {0}", a[0]);
        Console.WriteLine("Last Element: {0}", a[n - 1]);
    }
}
