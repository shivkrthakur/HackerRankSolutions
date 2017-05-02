using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int [] NK = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        int k = NK[1];
        int [] N = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        MarkAndToys(N, k);
    }
	
    static void MarkAndToys(int [] N, int k)
    {
        int toysCount = 0;
        Array.Sort(N);
        for(int i = 0; i < N.Length; i++)
        {
            k -= N[i];
            if(k >= 0) toysCount++; else break;
        }
        Console.WriteLine(toysCount);
    }
}