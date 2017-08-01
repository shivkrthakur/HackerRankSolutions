/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int [] nd = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
        int n = nd[0], d = nd[1];
        int [] input = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

        int [] output = new int[n];
        for(int i = 0; i < n; i++)
        {
            int t = (i + d) % n;
            output[i] = input[t];
            //Console.WriteLine(t);
        }
        Console.WriteLine(string.Join(" ",output));
    }
}
