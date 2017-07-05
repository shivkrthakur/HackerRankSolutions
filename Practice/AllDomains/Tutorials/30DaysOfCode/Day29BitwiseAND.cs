/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int previousValue = 0;
            for (int x = 1; x <= n; x++)
            {
                for(int y = x+1; y <= n; y++)
                {
                    int result = x & y;
                    if (result > previousValue && result < k)
                    {
                        previousValue = result;
                    }
                }
            }
            Console.WriteLine(previousValue);
        }

    }
}
