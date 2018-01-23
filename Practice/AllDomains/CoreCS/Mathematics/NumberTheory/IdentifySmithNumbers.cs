/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        long num = Convert.ToInt64(Console.ReadLine().Trim());
        var sumNum = SumDigits(num);
        var sumFactors = 0L;
        PrimeFactors(num)
        .ForEach(x => {
						sumFactors += SumDigits(x);
                      });
        Console.WriteLine(sumNum == sumFactors ? 1 : 0);
    }
    
    static List<long> PrimeFactors(long num)
    {
        var primeFactors= new List<long>();
        while (num % 2 ==0)
        {
            primeFactors.Add(2);
            num /= 2;
        }

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            while (num % i == 0)
            {
                primeFactors.Add(i);
                num /= i;
            }
        }

        if (num > 2) primeFactors.Add(num);

        return primeFactors;
    }

    static long SumDigits(long num)
    {
        return num.ToString().ToCharArray().Sum(x => Convert.ToInt32(x.ToString()));
    }
}