using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
	static void insertionSort(int[] N) 
	{
		int val = N[N.Length-1];
		int i = N.Length-1;
		while(--i >= 0 && val < N[i]) { N[i+1] = N[i]; Console.WriteLine(string.Join(" ", N)); }
		N[i+1] = val;
		Console.WriteLine(string.Join(" ", N));
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
		insertionSort(_ar);
    }
}
