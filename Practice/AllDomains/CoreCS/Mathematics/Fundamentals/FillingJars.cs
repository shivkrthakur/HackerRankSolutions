/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var nm = Console.ReadLine().Trim().Split().Select(Int64.Parse).ToArray();
        long n = nm[0], m = nm[1], sum = 0;
        for(int i = 0; i < m; i++){
            var abk = Console.ReadLine().Trim().Split().Select(Int64.Parse).ToArray();
            long a = abk[0], b = abk[1], k = abk[2];
            sum += (b - a + 1) * k;
        }
        Console.WriteLine(Math.Floor((sum * 1.0)/n));
    }
}