/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int x = 0; x < t; x++){
            long tgt = Convert.ToInt64(Console.ReadLine().Trim());
            long fib = 0, prevFib1 = 0, prevFib2 = 1;
            while(fib < tgt)
            {
                fib = prevFib1 + prevFib2;
                prevFib2 = prevFib1;
                prevFib1 = fib;
            }
            if(fib == tgt) Console.WriteLine($"IsFibo");
            else Console.WriteLine($"IsNotFibo");
        }
    }
}