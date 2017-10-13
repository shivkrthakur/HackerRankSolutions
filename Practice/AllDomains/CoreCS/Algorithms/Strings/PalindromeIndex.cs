/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t < T; t++)
        {
            string s = Console.ReadLine();
            if(IsPalindrome(s)) Console.WriteLine(-1);
            else 
            {
                int idx = 0; bool flag = false;
                for(int i = 0; i < s.Length/2; i++)
                {
                    int right = s.Length - 1 - i;
                    if(s[i] != s[right])
                    {
                        if(IsPalindrome(new StringBuilder(s).Remove(i,1).ToString())) 
                        {
                            idx = i; flag = true; break;
                        }
                        else if(IsPalindrome(new StringBuilder(s).Remove(right,1).ToString()))
                        {
                            idx = right; flag = true; break;
                        }
                    }
                }
                if(flag) Console.WriteLine(idx); else Console.WriteLine(-1);
            }
        }
    }
      
    static bool IsPalindrome(string s1)
    {
        for(int i = 0; i < s1.Length/2; i++)
        {
            if(s1[i] != s1[s1.Length - 1 -i]) return false;    
        }
        return true;
    }

    static bool IsPalindromeRecursive(string s1)
    {
        string s1R = Reverse(s1, 0);
        //Console.WriteLine($"s1:{s1} s1R:{s1R}");
        if(s1 == s1R) return true;
        return false;
    }

    static string Reverse(string s1, int index)
    {
        if(index == s1.Length) return string.Empty;
        return Reverse(s1, index + 1) + s1[index++].ToString();
    }
}