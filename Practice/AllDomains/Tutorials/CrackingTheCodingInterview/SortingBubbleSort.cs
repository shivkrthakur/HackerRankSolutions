/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    public static void PrintArray(int[] arr)
    {
        arr.ToList().ForEach(x => {Console.Write($"{x},");});
        Console.WriteLine();
    }
    
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        //PrintArray(a);
        int outerLength = a.Length, innerLength = a.Length-1, noOfSwaps = 0; 
        for(int i = 0; i < outerLength; i++)
        {
            for(int j = 0; j < innerLength; j++)
            {
                if(a[j] > a[j+1])
                {
                    int temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;
                    noOfSwaps++;
                    //outerLength = j;
                }
                //PrintArray(a);
            }
        }
        Console.WriteLine($"Array is sorted in {noOfSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Length-1]}");
    }
}
