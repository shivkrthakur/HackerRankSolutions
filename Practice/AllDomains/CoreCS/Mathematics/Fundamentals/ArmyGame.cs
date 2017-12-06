/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        if((n & 1) > 0) n += 1;
        if((m & 1) > 0) m += 1;
        Console.WriteLine((n/2) * (m/2));
    }
}
