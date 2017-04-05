using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        
        for(int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Trim().Split(' ');

            if(!int.Equals(n,a_temp.Length))
            {
                Console.WriteLine("Error");
                Console.ReadKey();
                      return;
            }
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
        int diagonal1Sum = 0, diagonal2Sum = 0;
        
        for(int x = 0; x < a.Length; x++ )
        {
            diagonal1Sum += a[x][x];
            diagonal2Sum += a[x][n - 1 - x];
        }
        
        Console.WriteLine(Math.Abs(diagonal1Sum - diagonal2Sum));
    }
}
