/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int T = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t < T; t++)
        {
            bool Funny = true;
            string s = Console.ReadLine();
            int [] c = s.Select(x => (int)x).ToArray();
            int len = c.Length;
            for(int i = 1, j = len - 2; i < len && j >= 0; i++, j--)
            {
                int eq1 = Math.Abs(c[i] - c[i-1]);
                int eq2 = Math.Abs(c[j] - c[j+1]);
                if(eq1 != eq2) { Funny = false; break; }
            }
            if(Funny) Console.WriteLine(nameof(Funny));
            else Console.WriteLine($"Not {nameof(Funny)}");
        }
    }
}