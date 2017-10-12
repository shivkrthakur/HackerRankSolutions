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
        int n = Convert.ToInt32(Console.ReadLine());
        int [] weights = new int[n];// { 1, 3, 12, 5, 9, 10};
        for(int a0 = 0; a0 < n; a0++){
            int x = Convert.ToInt32(Console.ReadLine());
            weights[a0] = x;
        }
        int len = s.Length;
        HashSet<int> hs = new HashSet<int>();
        int count = 1;
        int prevtCInt = 0;
        for(int i = 0; i < len; i++)
        {
            char c = s[i];
            int cInt = (int)c;
            int tCInt = cInt - 96;
            if(prevtCInt == cInt) count++;
            else { prevtCInt = cInt; count = 1; }
            hs.Add(count * tCInt);
        }
        for(int j = 0; j < weights.Length; j++)
        {
            if(hs.Contains(weights[j])) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        
    }
}
