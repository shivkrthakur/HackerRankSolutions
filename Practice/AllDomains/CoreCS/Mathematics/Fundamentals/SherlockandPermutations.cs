/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        int mod = (int)Math.Pow(10, 9) + 7;
        for(int i = 0; i < t; i++)
        {
            var arr = Console.ReadLine().Trim().Split().Select(Int64.Parse).ToArray();
            BigInteger biN = new BigInteger(arr[0]);
            BigInteger biM = new BigInteger(arr[1] - 1);
            BigInteger x = BigInteger.Add(biN, biM);
            Console.WriteLine($"{BigInteger.Divide(BigIntegerFactorial(x),BigInteger.Multiply(BigIntegerFactorial(biN),BigIntegerFactorial(biM))) % mod}");
        }
    }
    
    static BigInteger BigIntegerFactorial(BigInteger x)
    {
        if(x.Equals(BigInteger.Zero)) return 1;
        return BigInteger.Multiply(x,(BigIntegerFactorial(BigInteger.Subtract(x, BigInteger.One))));
    }
}