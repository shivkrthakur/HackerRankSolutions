/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    public static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < t; i++)
        {
            var input = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
            int length = input[0], width = input[1];
            Console.WriteLine((length * width)/Math.Pow(HighestCommonFactor(length, width),2));
        }
    }

    // Define other methods and classes here
    static IEnumerable<long> FindAllFactorsOfANumber(long num)
    {
        SortedSet<long> factors = new SortedSet<long>(){ 1, num };
        var tgtFloor = Math.Floor(Math.Sqrt(num));
        for(int i = 2; i <= tgtFloor; i++)
        {
            if((num % i) == 0){
                var quotient = (int)(num/i);
                factors.Add(i);
                factors.Add((int)(num/i));
            }
        }
        return factors;
    }

    static long HighestCommonFactor(long num1, long num2)
    {
        var factors1 = (SortedSet<long>)FindAllFactorsOfANumber(num1);
        var factors2 = (SortedSet<long>)FindAllFactorsOfANumber(num2);
        factors1.IntersectWith(factors2);
        return factors1.Max();
    }
}