using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
	static void insertionSort(int[] N) 
	{
		int i = 0;
		while(++i < N.Length)
		{
			int j = 0;
			while(j < i)
			{
				if(N[i] < N[j])
				{
					int temp = N[i];
					for(int k = i; k > j; k--)
					{
						N[k] = N[k-1];
					}
					N[j] = temp;
					break;
				}
				j++;
			}
			Console.WriteLine(string.Join(" ", N));
		}
	}

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
