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
        int [] inIntArr = new int[n];
        string [] inStrArr = new String[n];
        int [] hArr = new int[101];
        for(int i = 0; i < n; i++) 
        {	
            string S = Console.ReadLine();
            int index = Convert.ToInt32(S.Split()[0].ToString());
            string str = (i < n/2) ? "-" : S.Split()[1].ToString();
            inIntArr[i] = index;
            inStrArr[i] = str;
            hArr[index+1]++;
        }

        for(int i = 1; i < hArr.Length; i++) hArr[i] += hArr[i -1];
        string [] output = new String[n];
        for(int i = 0; i < n; i++) output[hArr[inIntArr[i]]++] = inStrArr[i];
        Console.WriteLine(string.Join(" ", output));
    }
}