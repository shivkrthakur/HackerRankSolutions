/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t < T; t++)
        {
            string s = Console.ReadLine();
            int len = s.Length;
            int deletes = 0;
            if((s.IndexOf('A') == -1) || (s.IndexOf('B') == -1)) { deletes = len - 1; Console.WriteLine(deletes); continue;}
            char prevChar = (char)0;
            for(int i = 0; i < len; i++)
            {
                char curChar = s[i];
                if(curChar == prevChar) { deletes++; }
                prevChar = curChar;
            }
            Console.WriteLine(deletes);
        }
        
    }
}