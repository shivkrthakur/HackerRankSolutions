/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string [] S = new string[n];//{ "abcdde", "baccd", "eeabg" };
        int gemStones = 0;
        HashSet<char> hs = new HashSet<char>();
        for(int i = 0; i < n; i++)
        {
             S[i] = Console.ReadLine();   
        }
        
        string s = S[0];
        for(int j = 0; j < s.Length; j++)
        {
            int count = 1;
            char c = s[j];
            for(int i = 1; i < n; i++)
            {
                if(S[i].IndexOf(c) > -1) count++;
            }
            if(count >= n && !hs.Contains(c))
            {
                hs.Add(c);
                //Console.WriteLine($"c:{c}");
                gemStones++;
            }
        }
        Console.WriteLine(gemStones);
        
    }
}