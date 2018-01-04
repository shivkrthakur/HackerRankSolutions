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
        for(int i = 0; i < t; i++){
            var input = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
            int a = input[0], b = input[1], c = input[2];
            long gcd = HCForGCD(a, b);
            if(c < Math.Max(a,b) && c % gcd == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
    
    static long HCForGCD(long num1, long num2)
	{
        if(num1 == 0 || num2 == 0) return 0;
        if(num1 == num2) return num1;
        if(num1 > num2) return HCForGCD(num1 - num2, num2);
        return HCForGCD(num1, num2 - num1);
    }
}