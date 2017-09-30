/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        string s = Console.ReadLine();
        string sos = "SOS";
        int count = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != sos[i%3]) count++;
        }
        Console.WriteLine(count);
    }
}
