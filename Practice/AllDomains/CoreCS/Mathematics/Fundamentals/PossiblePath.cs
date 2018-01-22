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
        for(int i = 0; i < t; i++)
        {
            var input = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
            Console.WriteLine(CalculateGCD(input[0], input[1]) == CalculateGCD(input[2], input[3]) ? "YES" : "NO");
        }
    }
    
    private static long CalculateGCD(long num1, long num2)
    {
        if(num1 == 0 || num2 == 0) return 0;
        if(num1 == num2) return num1;

        if(num1 > num2) return CalculateGCD(num1 - num2, num2);
        else return CalculateGCD(num1, num2 - num1);
    }
}