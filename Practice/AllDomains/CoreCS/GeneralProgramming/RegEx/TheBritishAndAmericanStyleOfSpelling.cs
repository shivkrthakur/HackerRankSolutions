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
        int N = Convert.ToInt32(Console.ReadLine());
        string [] text = new String[N];
        for(int i = 0; i < N; i++)
        {
            text[i] = Console.ReadLine(); 
        }
        int T = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t < T; t++)
        {
            string exp = Console.ReadLine();
            exp = exp.Substring(0,exp.Length - 2);
            exp = exp + "[sz]e";
            int count = 0;
            foreach(string str in text)
            {
                count += Regex.Matches(str,exp).Count;
                //Console.WriteLine(matches.Count);
            }
            Console.WriteLine(count);
        }
    }
}