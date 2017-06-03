using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int [] ND = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        int [] N = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        FradulentActivityNotifications(N, ND);
    }
    
    static void FradulentActivityNotifications(int [] N, int [] ND)
    {
        int n = ND[0], d = ND[1];
        int ncount = 0;
        int [] exp = new int[201];

        int e = 0; 
        while(e < d) exp[N[e++]]++;

        bool isEven = ((d&1) == 0);
        int mVal = isEven ? d/2 : d/2 + 1;

        for(int i = d, a = 0; i < n; i++)
        {
            int val = N[i];
            int med = 0, sum = 0;
            while(sum < mVal) sum += exp[med++];
            if(sum > mVal || !isEven) { med -= 1; med *= 2; }
            else 
            {
                int left = --med;
                while(exp[++med] == 0 && med < n);
                med = left + med;
            }

            if(val >= med) ncount++;

            exp[val]++;
            exp[N[a++]]--;
        }
        Console.WriteLine(ncount);
    }
}