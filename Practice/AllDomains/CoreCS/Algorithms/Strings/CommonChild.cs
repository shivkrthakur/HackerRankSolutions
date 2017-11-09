/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string s1 = Console.ReadLine().Trim();
        string s2 = Console.ReadLine().Trim();
        int[,] matrix = new int[s1.Length+1, s2.Length+1];
        int count = FindLongestCommonSubsequence(s1, s2, s1.Length, s2.Length, matrix);
        Console.WriteLine(count);
    }
    
    static int FindLongestCommonSubsequence(string s1, string s2, int n, int m, int [,] matrix)
    {
        if(n == 0 || m == 0) return 0;
        int result = 0;
        if(matrix[n,m] > 0) result = matrix[n,m];
        else
        {
            if(s1[n-1] == s2[m-1]) result = 1 + FindLongestCommonSubsequence(s1, s2, n - 1, m - 1, matrix);
            else result = Math.Max(FindLongestCommonSubsequence(s1, s2, n , m - 1, matrix), FindLongestCommonSubsequence(s1, s2, n - 1, m, matrix));
            matrix[n,m] = result;
        }
        return result;
    }
}