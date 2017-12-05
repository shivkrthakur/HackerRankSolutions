/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int mod = 1234567;
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < t; i++){
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var arr = Console.ReadLine().Trim().Split().Select(Int32.Parse).ToArray();
            int output = 1;
            for(int j = 0; j < arr.Length; j++){
                output = ((output % mod) * (arr[j] % mod)) % mod;
            }
            Console.WriteLine($"{output}");
        }
    }
}