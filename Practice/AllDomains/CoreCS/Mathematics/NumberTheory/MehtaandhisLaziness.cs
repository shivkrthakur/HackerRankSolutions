/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var console = Console.In;
        int t = Convert.ToInt32(console.ReadLine().Trim());
        for(int i = 0; i < t; i++)
        {
            int N = Convert.ToInt32(console.ReadLine().Trim());
            ProperDivisors(N, out int properDivisorCount, out int prefectSquareCount);
            if(prefectSquareCount == 0) Console.WriteLine(prefectSquareCount);
            else  Console.WriteLine($"{prefectSquareCount}/{properDivisorCount}");
        }
    }
    
    static void ProperDivisors(int N, out int properDivisorCount, out int prefectSquareCount)
    {
        var tgt = Math.Floor(Math.Sqrt(N));
        properDivisorCount = 1; prefectSquareCount = 0;
        for(int i = 2; i <= tgt; i++)
        {
            if((N % i) == 0) 
            {
                properDivisorCount++;
                var j = N/i;
                if(j != i) properDivisorCount++;
                if(((i & 1) == 0) && ((Math.Floor(Math.Sqrt(i)) * Math.Floor(Math.Sqrt(i))) == i)) {
                    prefectSquareCount++;
                }
                if((i != j) && ((j & 1) == 0) && ((Math.Floor(Math.Sqrt(j)) * Math.Floor(Math.Sqrt(j))) == j)) 
                {
                    prefectSquareCount++;
                }
            }
        }
        if(properDivisorCount > 0 && prefectSquareCount > 0)
            ReduceFactorToLowest(ref prefectSquareCount, ref properDivisorCount);
    }
    
    static void ReduceFactorToLowest(ref int num, ref int den)
	{
        int i = num > den ? den : num;
        for(; i > 0; i--)
        {
            if(((num % i) == 0) && ((den % i) == 0))
                break;
        }
        num = num / i;
        den = den / i;
    }
}