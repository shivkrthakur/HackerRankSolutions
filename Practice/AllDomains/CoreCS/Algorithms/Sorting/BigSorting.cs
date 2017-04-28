using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution 
{
	/*	author:@shivkrthakur  */    
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        String [] S = new String[n];
        for(int i = 0; i < n; i++)  S[i] = Console.ReadLine().Trim();   
        Array.Sort(S, (x,y) => 
        {
            if(x.Length > y.Length) return 1;
            if(x.Length < y.Length) return -1;
            for(int i = 0; i < x.Length; i++)
            {
                if((int)x[i] > (int)y[i]) return 1;
                if((int)x[i] < (int)y[i]) return -1;
            }
            return 0;
        });
        Console.WriteLine(string.Join(Environment.NewLine, S));
    }
}
