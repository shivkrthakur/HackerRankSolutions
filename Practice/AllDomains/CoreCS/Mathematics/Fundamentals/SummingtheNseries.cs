/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        int mod = 1000000007;
        for(int i = 0; i < t; i++){
            long sum = 0;
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            n = ((n % mod) * (n % mod))% mod;
            Console.WriteLine(n);
        }
    }
}