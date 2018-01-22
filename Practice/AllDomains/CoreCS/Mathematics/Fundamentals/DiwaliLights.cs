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
        int mod = 100000;
        for(int i = 0; i < t; i++){
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine((ModPower(2, n, mod)) - 1);
        }
    }
    
    static long ModPower(long x, long y, int p)
    {
        long res = 1;
        x = x % p;
        while (y > 0)
        {
            // If y is odd, multiply x with result
            if((y & 1) > 0) res = (res*x) % p;

            // y must be even now
            y = y >> 1; // y = y/2
            x = (x * x) % p;  
        }
        return res;
    }
}