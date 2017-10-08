/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        string zeroOnezero = "010";
        int l = s.Length - s.Replace(zeroOnezero, string.Empty).Length;
        Console.WriteLine(l/3);
    }
}
