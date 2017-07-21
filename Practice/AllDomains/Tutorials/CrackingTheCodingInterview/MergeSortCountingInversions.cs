/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    public static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
            Console.WriteLine(CountInversions(arr));
        }
    }
    
    public static long CountInversions(int[] array)
    {
        int[] auxArray = (int [])array.Clone();
        long invCounter = 0;
        invCounter = MergeSort(array, 0, array.Length - 1, auxArray);
        return invCounter;
    }
    
    public static long MergeSort(int[] array, int p, int r, int [] auxArray)
    {
        if(p >= r) return 0;
        int q = (p + r) /2;
        long counter = 0;
        counter += MergeSort(auxArray, p, q, array);
        counter += MergeSort(auxArray, q + 1, r, array);
        counter += AuxArrayMerge(array, p, q, r, auxArray);
        return counter;
    }
    
    private static long AuxArrayMerge(int[] arr, int lo, int mid, int hi, int[] aux) {
        long count = 0;
        int i = lo, j = mid + 1, k = lo;
        while (i <= mid || j <= hi) {
            if (i > mid) {
                arr[k++] = aux[j++];
            } else if (j > hi) {
                arr[k++] = aux[i++];
            } else if (aux[i] <= aux[j]) {
                arr[k++] = aux[i++];
            } else {
                arr[k++] = aux[j++];
                count += mid + 1 - i;
            }
        }

        return count;
    }
}
