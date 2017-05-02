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
        ClosesNumbers(N);
    }
    
    static void ClosesNumbers(int [] N)
    {
        Array.Sort(N);
        int minVal = Int32.MaxValue; 
        List<Tuple<int,int>> valTList = new List<Tuple<int,int>>();
        for(int i =  0; i < N.Length - 1; i++)
        {
            int aD = Math.Abs(N[i] - N[i + 1]);

            if(minVal >= aD)
            {
                if(minVal > aD) { valTList.Clear(); minVal = aD; }
                valTList.Add(new Tuple<int,int>(N[i], N[i+1]));
            }
        }
        foreach(var item in valTList) Console.Write($"{item.Item1} {item.Item2} ");
    }
}