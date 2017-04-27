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
	    int [] N = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        int [] op = new int[100];
        for(int i = 0; i < n; i++)
        {
            op[N[i]]++;
        }
        Console.WriteLine(string.Join(" ", op));
    }
}