/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < t; i++)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            if((length & 1) != 0) Console.WriteLine("-1");
            else
            {
                int change = 0;
                string s1 = input.Substring(0, length/2);
                string s2 = input.Substring(length/2, length/2);
            
                Dictionary<char,int> dict = new Dictionary<char,int>();
                int f = -1;
                while(++f < s1.Length) 
                {
                    if(dict.ContainsKey(s1[f]))
                    {
                        dict[s1[f]]++;
                    }
                    else dict.Add(s1[f], 1);	
                }
                f= -1;
                while(++f < s2.Length) 
                {
                    if(dict.ContainsKey(s2[f]))
                    {
                        dict[s2[f]]--;
                        if(dict[s2[f]] == 0) dict.Remove(s2[f]);
                    }
                    else change++;
                }
                Console.WriteLine(change);			
            }
        }
    }
}