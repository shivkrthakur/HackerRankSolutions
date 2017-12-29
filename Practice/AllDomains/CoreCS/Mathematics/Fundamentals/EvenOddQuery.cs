/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int [] arr = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < t; i++){
            int [] xy = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
		    int x = xy[0], y = xy[1];
            bool isEven = false;
            if(x > y || (x == y && ((arr[x - 1] & 1) == 0)) || (((long)Math.Pow(arr[x - 1], arr[x]) & 1) == 0)){
                isEven = true;
            } 
            Console.WriteLine(isEven ? "Even" : "Odd");
        }
    }
}