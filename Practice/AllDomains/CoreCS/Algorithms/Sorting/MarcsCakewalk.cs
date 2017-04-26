using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        string[] calories_temp = Console.ReadLine().Split(' ');
        int[] calories = Array.ConvertAll(calories_temp,Int32.Parse);
        // your code goes here
        //Array.Reverse(calories);
        Array.Sort<int>(calories, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
        long miles = 0;
        for(int i = 0; i < n; i++)
        {
            miles += (calories[i] * (long)Math.Pow(2,i));
            //Console.WriteLine($"miles:{miles} i:{i} calories[i]:{calories[i]}");
        }
        Console.WriteLine(miles);
    }
}
