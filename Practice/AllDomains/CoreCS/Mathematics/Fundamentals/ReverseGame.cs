/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int t = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < t; i++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            if(k * 2 + 1 > n - 1)   Console.WriteLine(n - 1 - ((k * 2 + 1) % n));
            else Console.WriteLine(k * 2 + 1);
        }
    }
}
