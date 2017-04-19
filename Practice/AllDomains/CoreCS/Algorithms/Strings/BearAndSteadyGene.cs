using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    /*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int n = Convert.ToInt32(Console.ReadLine());
		string s = Console.ReadLine().Trim();
        Dictionary<char,int> di = new Dictionary<char,int>() { 	{ 'A', 0 },	{ 'C', 0 },	{ 'G', 0 },	{ 'T', 0 } };
		int charCount = n / 4;
		int left = 0, right = n - 1, min = Int32.MaxValue;
		while(left < n)
		{
			di[s[left]]++; 
			if(di[s[left]] > charCount)
			{
				di[s[left]]--;
				left--;
				break;
			} 
			left++;
		}
		while(left >= 0 && right >= 0 && left < right)
		{
			di[s[right]]++;
			while((di['A'] > charCount || di['C'] > charCount || di['G'] > charCount || di['T'] > charCount) && left >= 0)
				di[s[left--]]--;
			min = Math.Min(min, Math.Max(0,right - left - 1));
			right--;
		}
		Console.WriteLine(min == Int32.MaxValue ? 0 : min);
    }
}