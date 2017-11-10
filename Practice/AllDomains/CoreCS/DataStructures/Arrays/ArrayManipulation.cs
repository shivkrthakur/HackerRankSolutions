/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int [] nm = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
        int n = nm[0], m = nm[1];
        long [] op = new long[n+1];
        for(int i = 0; i < m; i++)
        {
            int[] abk = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int a = abk[0], b = abk[1], k = abk[2];
            op[a] += k;
            if(b+1 <= n) op[b+1] -= k;
        }
        long sum = 0, max = 0;
        for(int j = 0; j <= n; j++)
        {
            sum += op[j];
            if(max < sum) max = sum;
        }
        Console.WriteLine(max);
    }
}