using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */	
	static void Main(String[] args) 
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int [] N = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		LomutoPartitionScheme(N, 0, n - 1);
	}

	static void LomutoPartitionScheme(int [] N, int left, int right)
	{
		if(left < right)
		{
			int p = Partition(N, left, right);
			Console.WriteLine(string.Join(" ", N));
			LomutoPartitionScheme(N, left, p - 1);
			LomutoPartitionScheme(N, p + 1, right);
		}
	}

	static int Partition(int [] N, int left, int right)
	{
		int pivot = N[right];
		int i = left - 1;
		while(left < right)
		{
			if(N[left] < pivot)
			{
				i++;
				Swap(N, left, i);
			}
			left++;
		}
		Swap(N, i + 1, right);
		return i + 1;
	}

	static void Swap(int [] arr, int i, int j)
	{
		int temp = arr[i];
		arr[i] = arr[j];
		arr[j] = temp;
	}
}