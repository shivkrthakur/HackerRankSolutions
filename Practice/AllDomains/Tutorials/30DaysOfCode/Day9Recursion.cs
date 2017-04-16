using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int x = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(Factorial(x));
    }
    
    public static int Factorial(int x)
    {
        if(x == 1) return x;
        return x * Factorial(x-1);
    }
}
