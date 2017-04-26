using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores_temp = Console.ReadLine().Split(' ');
        int[] lScores = Array.ConvertAll(scores_temp,Int32.Parse);
        int m = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp = Console.ReadLine().Split(' ');
        int[] aScores = Array.ConvertAll(alice_temp,Int32.Parse);
        // your code goes here
        int rank = 1;
        int j = 0;
        int prevNo = 0;;
        int p = m;
        int [] op = new int[m];
        for(int i = m-1; i >= 0; i--)
        {
            for(; j < n;j++)
            {
                //Console.WriteLine($"i:{i} j:{j} aScores[i]:{aScores[i]} lScores[j]:{lScores[j]} prevNo:{prevNo} rank:{rank}");
                if(aScores[i] >= lScores[j]) 
                { 
                    op[--p] = rank; 
                    //Console.WriteLine($"RANK HERE: i:{i} j:{j} aScores[i]:{aScores[i]} lScores[j]:{lScores[j]} rank:{rank}"); 
                    break; 
                }
                if(prevNo != lScores[j]) rank++;
                prevNo = lScores[j];
            }
        }
        while(--p >= 0) 
            op[p] = rank;

        //Console.WriteLine(rank);
        //Console.WriteLine(op);
        Console.WriteLine(string.Join(Environment.NewLine,op));
    }
}
