using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*
		author:@shivkrthakur
	*/
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Trim().Split(' ');
        if(int.Equals(n, arr_temp.Length))
        {
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
            Console.WriteLine(arr.Sum());
        }
        else
        {
            Console.WriteLine("The size of the array doesn't match the number of input elements");
        }
    }
}
