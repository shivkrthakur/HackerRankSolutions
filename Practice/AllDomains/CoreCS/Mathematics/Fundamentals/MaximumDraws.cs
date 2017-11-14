/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < t; i++)
        {
            var pairs = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine(pairs + 1);
        }
    }
}