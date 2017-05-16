using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] coins_temp = Console.ReadLine().Split(' ');
        int[] coins = Array.ConvertAll(coins_temp,Int32.Parse);
        Array.Sort(coins);
        long[,] memoization = new long[n+1,m+1];
        Console.WriteLine(CountChange(coins, n, m, memoization));
    }
    
    public static long CountChange(int[] coins, int totalAmt, int typeOfCoins, long[,] memoization)
    {
        if(totalAmt < 0) return 0;
        if(totalAmt ==0) return 1;
        if(typeOfCoins <= 0) return 0;
        else
        {
           int index = typeOfCoins - 1;
           int count = 0;
           //Console.WriteLine($"TotalAmt:{totalAmt} Index:{index}");
           if(memoization[totalAmt, typeOfCoins] == 0)
           memoization[totalAmt, typeOfCoins] = CountChange(coins, totalAmt, index, memoization) + CountChange(coins, totalAmt - coins[index], typeOfCoins, memoization);
            return memoization[totalAmt, typeOfCoins];
        }
    }
}
