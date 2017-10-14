/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        
        int [] input = s.ToCharArray().Select(x => (int)x).ToArray();
        int a = (int)'a', z = (int)'z', A = (int)'A', Z = (int)'Z';
        //Console.WriteLine($"s:{s} a:{a} z:{z} A:{A} Z:{Z}");
        k = k % 26;
        for(int i = 0; i < n; i++)
        {
           int c = input[i];
           int sum = 0;
           //Console.WriteLine($"{(char)c} c:{c} k:{k} c+k:{c+k} {(char)(c + k)}");
           if(c >= a && c <= z)
           {
              c = (c + k);
              if(c > z){ c = a - 1 + (c % z); }
           }
           if(c >= A && c <= Z)
           {
              c = (c + k);
              if(c > Z) { c = A - 1 + (c % Z); }
           }
           input[i] = c;
        }
        Console.WriteLine(string.Join("", input.Select(x => (char)x).ToArray()));
        
    }
}
