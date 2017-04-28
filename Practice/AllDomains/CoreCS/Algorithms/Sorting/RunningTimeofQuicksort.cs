using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
	static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        int [] N = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        int [] inArr = new int[n];
        int [] qsArr = new int[n];
        Array.Copy(N, inArr, n);
        Array.Copy(N, qsArr, n);
        int inCount = InsertionSort(inArr);
        int qsCount = QuickSort(qsArr, 0, n -1);
        //Console.WriteLine($"inCount:{inCount} qsCount:{qsCount} diff:{inCount - qsCount}");
        Console.WriteLine(inCount - qsCount);
    }
    
    static int InsertionSort(int [] N)
    {
        int swapCount = 0;
        for(int i = 1; i < N.Length; i++)
        {
            int j = i;
            while(j > 0 && N[j] < N[j-1])
            {
               Swap(N, j, j-1);
               j--;
               swapCount++;
            }
        }
        return swapCount;
    }
    
    static int QuickSort(int [] N, int left, int right)
    {
        int swapCount = 0;
        if(left < right)
        {
            int p = LumotoPartition(N, left, right, ref swapCount);
            swapCount += QuickSort(N, left, p - 1);
            swapCount += QuickSort(N, p + 1, right);
        }
        return swapCount;
    }
    
    static int LumotoPartition(int [] N, int left, int right, ref int swapCount)
    {
        int pivot = N[right];
        int i = left -1;
        while(left < right)
        {
            if(N[left] < pivot)
            {
                i++;
                Swap(N, i, left);
                swapCount++;
            }
            left++;
        }
        Swap(N, i + 1, right);
        swapCount++;
        return i + 1;
    }
    
    static void Swap(int [] N, int i , int j)
    {
        int val = N[i];
        N[i] = N[j];
        N[j] = val;
    }
}