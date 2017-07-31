/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] input = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           input[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }

        int prevResult = Int32.MinValue;
        for(int row = 0; row < input.Length - 2; row++)
        {
            for(int col = 0; col < input[row].Length - 2; col++)
            {
                int rowCounter = 0, result = 0;
                for(int row_i = row; row_i < row + 3 && row_i < input.Length; row_i++)
                {
                    int colCounter = 0;
                    for(int col_i = col; col_i < col + 3 && col_i < input[row].Length; col_i++)
                    {
                        if(rowCounter == 1 & colCounter != 1)
                        {
                            colCounter++;
                        }
                        else
                        {
                            result += input[row_i][col_i];
                            colCounter++;
                        }
                    }
                    rowCounter++;
                }
                if(prevResult < result) prevResult = result;
            }
        }
        Console.WriteLine(prevResult);

    }
}
