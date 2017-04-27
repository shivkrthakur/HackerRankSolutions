using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void quickSort(int[] ar) 
    {
       PartitionAndSort(ar.ToList());
    }
    
    static List<int> PartitionAndSort(List<int> arr)
    {
        if(arr.Count() <= 1) return arr;
        int pivot = arr[0];
        var output = new List<int>();
        var left = new List<int>();
        var right = new List<int>();
        var equal = new List<int>();
        equal.Add(pivot);
        for(int i = 1; i < arr.Count(); i++)
        {
            int tgtVal = arr[i];
            if(tgtVal < pivot) left.Add(tgtVal);
            else if(tgtVal > pivot) right.Add(tgtVal);
            else equal.Add(tgtVal);
        }
        output.AddRange(PartitionAndSort(left));
        output.AddRange(equal);
        output.AddRange(PartitionAndSort(right));
        Console.WriteLine(string.Join(" ", output));
        return output;
    }
    
    static void Main(String[] args) 
	{
	   int _ar_size = Convert.ToInt32(Console.ReadLine());
	   int [] _ar =new int [_ar_size];
	   String elements = Console.ReadLine();
	   String[] split_elements = elements.Split(' ');
	   for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
	   quickSort(_ar);
    }
}
