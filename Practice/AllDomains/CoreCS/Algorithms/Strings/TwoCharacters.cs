/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution 
{
    static void Main(String[] args) 
	{
        int len = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
    	HashSet<char> chars = new HashSet<char>(s);
	    HashSet<string> pairs = new HashSet<string>();
        int max = 0;
        foreach(var c1 in chars)
        {
            foreach(var c2 in chars)
            {
                if(c1 != c2 && !pairs.Contains(c1.ToString() + c2.ToString()) && !pairs.Contains(c2.ToString() + c1.ToString()))
                {	
				    pairs.Add(c1.ToString() + c2.ToString());
                    string os = CreateString(c1,c2,s);				
                    if(Validate(os)) max = Math.Max(max,os.Length);
                }
            }
        }
        Console.WriteLine(max);
    }
    
    static string CreateString(char c1, char c2, string s)
    {
        StringBuilder sb = new StringBuilder(); 
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == c1 || s[i] == c2)
                sb.Append(s[i]);
        }
        return sb.ToString();
    }

    static bool Validate(string s)
    {
        for(int i = 0; i < s.Length - 2; i++)
        {
            if(s[i] == s[i+1] || s[i] != s[i+2]) return false;
        }
        return true;
    }
}
