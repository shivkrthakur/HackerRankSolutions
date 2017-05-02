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
        Tuple<int,int> [] tuples = new Tuple<int,int>[n];
        for(int i = 0; i < n; i++)
        {
            int [] ot = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            tuples[i] = new Tuple<int,int>(ot[0] + ot[1], i + 1);
        }
        
        Array.Sort(tuples, (x, y) => {
            return x.Item1 - y.Item1;
        });
        for(int i = 0; i < tuples.Length; i++) Console.Write($"{tuples[i].Item2} ");
    }
}