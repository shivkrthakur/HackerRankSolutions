using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int positiveNumCount = 0, negativeNumCount = 0, zeroNumCount = 0;
        
        if(!int.Equals(n, arr.Length))
        {
            Console.WriteLine("Array Length not equal to the length entered.");
            return;
        }

        for(int i = 0; i < arr.Length; i++)
        {
            if(int.Equals(0, arr[i]))
            {
                zeroNumCount++;
            }
            else if(arr[i] > 0)
            {
                positiveNumCount++;
            }
            else
            {
                negativeNumCount++;
            }
        }
            
            Console.WriteLine("{0:N6}", (double)positiveNumCount/arr.Length);
            Console.WriteLine("{0:N6}", (double)negativeNumCount/arr.Length);
            Console.WriteLine("{0:N6}", (double)zeroNumCount/arr.Length);
        }
}
