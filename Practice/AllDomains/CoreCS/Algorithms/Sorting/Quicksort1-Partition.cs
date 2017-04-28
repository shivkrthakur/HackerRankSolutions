using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
	static void partition(int[] N) 
	{
		int n = N.Length;
		int p = N[0];
		int i = 0, k = 0, j = n -1;
		int [] O = new int[n];
		while(++i < n)
		{
			if(N[i] < p)
			{
				O[k++] = N[i];
			}
			else if(N[i] > p)
			{
				O[j--] = N[i];
			}
		}
		if(k == j) O[k] = p;
		else if(k < j) { O[k] = p; O[j] = p; }

		//Console.WriteLine($"i:{i} k:{k} j:{j}");
		Console.WriteLine(string.Join(" ", O));
	}
	/* Tail starts here */
    static void Main(String[] args) 
	{
	   int _ar_size;
	   _ar_size = Convert.ToInt32(Console.ReadLine());
	   int [] _ar =new int [_ar_size];
	   String elements = Console.ReadLine();
	   String[] split_elements = elements.Split(' ');
	   for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
			  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
	   }
	   partition(_ar);
    }
}
