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
        int [] output = new int[100];
        for(int i = 0; i < n; i++) output[Convert.ToInt32(Console.ReadLine().Split()[0].ToString())]++;
        for(int i = 1; i < 100; i++) output[i] += output[i - 1];
        Console.WriteLine($"{string.Join(" ", output)}");
    }
}