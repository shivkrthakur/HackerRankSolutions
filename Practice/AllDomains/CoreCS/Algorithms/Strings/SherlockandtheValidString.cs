/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	static bool IsValid(string s)
    {
        int [] chars = new int[26];
        for(int i = 0; i < s.Length; i++) chars[s[i] - 'a']++;

        var dict = new Dictionary<int,int>();
        for(int j = 0; j < chars.Length; j++) 
            if(chars[j] > 0)
            if(dict.ContainsKey(chars[j])) dict[chars[j]]++;
			else dict.Add(chars[j], 1);

        if(dict.Count == 1) return true;
        if(dict.Count > 2) return false;
        var arr = dict.ToArray();

        if((arr[0].Value == 1 || arr[1].Value == 1) && (arr[0].Key == 1 || arr[1].Key == 1 || (Math.Abs(arr[0].Key - arr[1].Key) == 1))) return true;
        else return false;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        Console.WriteLine(IsValid(s) ? "YES" : "NO");
    }
}
