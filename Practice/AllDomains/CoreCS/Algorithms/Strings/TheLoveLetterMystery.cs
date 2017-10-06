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
            string s = Console.ReadLine();//S[t];
            int len = s.Length;
            int count = 0;
            for(int i = 0, j = len-1; i <= len/2 && j >= len/2; i++, j--)
            {
                char left = s[i];
                char right = s[j];
                if(left == right) continue;
                if(left < right) count += right - left;
                else count += left - right;
            }
            Console.WriteLine(count);
        }
        
    }
}