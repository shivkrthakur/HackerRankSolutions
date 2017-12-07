/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static long solve(long n, long m)
	{
        return (n - 1) + ((m - 1) * n);
    }

    static void Main(String[] args) 
	{
        string[] tokens_n = Console.ReadLine().Split(' ');
        long n = Convert.ToInt64(tokens_n[0]);
        long m = Convert.ToInt64(tokens_n[1]);
        long result = solve(n, m);
        Console.WriteLine(result);
    }
}
