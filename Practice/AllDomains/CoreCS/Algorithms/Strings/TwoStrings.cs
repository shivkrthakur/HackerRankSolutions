/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        char [] allChars = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
        int t = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < t; i++)
        {
            bool yes = false;
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int j = 0;
            while(j < allChars.Length)
            { 
                if(s1.IndexOf(allChars[j]) != -1 && s2.IndexOf(allChars[j]) != -1) { yes = true; break; }
                j++;
            }
            if(yes) Console.WriteLine("YES"); else Console.WriteLine("NO");
        }
    }
}