using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        int arrLength = 6;
        int[][] arr = new int[arrLength][];
        for(int arr_i = 0; arr_i < arrLength; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        int sum = int.MinValue;
        for(int j = 0; j < arrLength; j++)
        {
            int length = arr[j].Length;
            
            for(int k=0; k < length; k++)
            {
                if((j+2) < arrLength && (k+2) < length)
                {
                        int currentSum = arr[j][k] + arr[j][k + 1] + arr[j][k + 2] + arr[j + 1][k + 1] + arr[j + 2][k] + arr[j + 2][k + 1]+ arr[j + 2][k + 2];
                        if(currentSum > sum) sum = currentSum;
                }
                
            }
        }
        Console.WriteLine(sum);
	}
}
