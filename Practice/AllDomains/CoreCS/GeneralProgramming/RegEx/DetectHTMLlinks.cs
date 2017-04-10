using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution 
{
    /*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string exp = @"href=([""'])(.*?)(<\s*/\s*a\s*>)";
        for(int i = 0; i < n; i++)
        {
            string text = Console.ReadLine();
            foreach(Match m in Regex.Matches(text,exp))
            {
                string tgt = m.Groups[2].Value;
                string url = tgt.Substring(0,tgt.IndexOf('"'));
                string name = tgt.Substring(tgt.LastIndexOf('>')+1, tgt.Length - tgt.LastIndexOf('>')-1).Trim();
			    if(string.IsNullOrEmpty(name)) 
                {    
                    tgt = Regex.Match(tgt,@"(>*?)(.*?)(</)").Groups[2].Value;
                    name = tgt.Substring(tgt.LastIndexOf('>')+1, tgt.Length - tgt.LastIndexOf('>')-1).Trim();
                }
                Console.WriteLine($"{url},{name}");
            }
        }
    }
}