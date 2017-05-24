using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        int s = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < s; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Staircases:{n}");

                int[] memoizationArr = new int[n];
                int x = NoOfWaysToClimbStairs(n - 1, memoizationArr) + NoOfWaysToClimbStairs(n - 2, memoizationArr) + NoOfWaysToClimbStairs(n - 3, memoizationArr);
                Console.WriteLine(x);
        }
    }
    
    static int NoOfWaysToClimbStairs(int n, int[] memoizationArr)
    {
       if(n < 0) return 0;
       if(n == 0 || n == 1) return 1;
       if(n == 2) return 2;
       if(n == 3) return 4;
       if(memoizationArr[n] != 0) return memoizationArr[n];
       
       memoizationArr[n] = NoOfWaysToClimbStairs(n - 1, memoizationArr) + NoOfWaysToClimbStairs(n - 2, memoizationArr) + NoOfWaysToClimbStairs(n - 3, memoizationArr);
       return memoizationArr[n];
    }
}
