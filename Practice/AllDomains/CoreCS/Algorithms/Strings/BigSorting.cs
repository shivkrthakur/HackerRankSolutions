/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution 
{
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        String [] S = new String[n];
        for(int i = 0; i < n; i++)  S[i] = Console.ReadLine().Trim();   
        Array.Sort(S, StringAsIntegerCompare);
        Console.WriteLine(string.Join(Environment.NewLine, S));
    }
    
    void BigSortingUsingInBuiltQuickSortOP()
    {
        int n = Convert.ToInt32("6");
        string [] S = { "2", "1", "3", "10", "3", "5" };
        Console.WriteLine(string.Join(" ", S));
        Array.Sort(S, StringAsIntegerCompare);
        Console.WriteLine(string.Join(" ", S));
    }

    static int StringAsIntegerCompare(String s1, String s2)
    {
        if(s1.Length > s2.Length) return 1;
        if(s1.Length < s2.Length) return -1;
        for(int i = 0; i < s1.Length; i++)
        {
            if((int)s1[i] > (int)s2[i]) return 1;
            if((int)s1[i] < (int)s2[i]) return -1;
        }
        return 0;
    }
}
