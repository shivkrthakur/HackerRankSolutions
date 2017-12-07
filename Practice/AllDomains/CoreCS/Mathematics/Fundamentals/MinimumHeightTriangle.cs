/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static int lowestTriangle(int @base, int area)
	{
        // Complete this function
        return (int)Math.Ceiling((area * 2.0)/@base);
    }

    static void Main(String[] args) 
	{
        string[] tokens_base = Console.ReadLine().Split(' ');
        int @base = Convert.ToInt32(tokens_base[0]);
        int area = Convert.ToInt32(tokens_base[1]);
        int height = lowestTriangle(@base, area);
        Console.WriteLine(height);
    }
}
