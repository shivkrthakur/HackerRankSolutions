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
        //Console.WriteLine($"{string.Join(" ", N)}");
        int median = LomutoQuickSort(N, 0, N.Length-1);
        //Console.WriteLine($"{string.Join(" ", N)}");
        Console.WriteLine(median);
    }
    
    static int LomutoQuickSort(int [] n, int left, int right)
    {
        int output = 0;
        if(left <= right)
        {
            int p = LomutoPartition(n, left, right);
            if(p == n.Length/2) {	return n[p]; }
            if(output == 0)	output = LomutoQuickSort(n, left, p -1); //else LomutoQuickSort(n, left, p -1);
            if(output == 0) output = LomutoQuickSort(n, p + 1, right); //else LomutoQuickSort(n, p + 1, right);
        }
        return output;
    }

    static int LomutoPartition(int [] n, int left, int right)
    {
        int pivot = n[right];
        int i = left - 1;
        while(left < right)
        {
            if(n[left] < pivot) 
            {
                i++;
                Swap(n, i, left);
            }
            left++;
        }
        Swap(n, i + 1, right);
        return i + 1;
    }

    static void Swap(int [] n, int index1, int index2)
    {
        int temp = n[index1];
        n[index1] = n[index2];
        n[index2] = temp;
    }
    
}