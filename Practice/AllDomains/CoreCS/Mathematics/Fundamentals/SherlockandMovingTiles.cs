/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        TextReader reader = Console.In;    
        var input = Array.ConvertAll(reader.ReadLine().Trim().Split(), Int64.Parse);
        long l = input[0], s1 = input[1], s2 = input[2];
        long s = Math.Abs(s1 - s2);
        double d = Math.Sqrt(2) * l;
        long n = Convert.ToInt64(reader.ReadLine().Trim());
        for(int i = 0; i < n; i++)
        {
            long a = Convert.ToInt64(reader.ReadLine().Trim());
            double side = Math.Sqrt(a);
            double d2 = Math.Sqrt(2) * side;
            double e = d - d2;
            Console.WriteLine(e/s);
        }
    }
}