using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        long [] arr = Array.ConvertAll(arr_temp,long.Parse);
        
        if(!int.Equals(n,arr_temp.Length))
        {
            Console.WriteLine("The array length doesn't match the input parameter value!");
            return;
        }
        Console.WriteLine(arr.Sum());
    }
}
