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
        string findTagsExp = @"(<\s*[\w]+\s*>?|<\s*/\s*[\w]+\s*>)";
        string fingTagsStringExp = @"\w+";
        SortedSet<string> set = new SortedSet<string>();
        for(int i = 0; i < n; i++)
        {
            foreach(Match m in Regex.Matches(Console.ReadLine(), findTagsExp))
            {
                set.Add($"{Regex.Match(m.Value,fingTagsStringExp).Value}");
            }
        }
        Console.WriteLine(string.Join(";",set));
    }
}