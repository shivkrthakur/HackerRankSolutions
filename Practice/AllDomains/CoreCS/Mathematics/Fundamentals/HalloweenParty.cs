/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < t; i++){
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            long h = n/2;
            long j = n - h;
            long o = h * j;
            Console.WriteLine(o);
        }
    }
}