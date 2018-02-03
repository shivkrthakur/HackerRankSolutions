/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var t = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < t; i++){
            var input = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            int a = input[0], b = input[1], x = input[2];
            if(b < 0 && a > 1) Console.WriteLine("0");
            else
            {
                var pow = Math.Pow(a, b);
                var rem = pow % x;
                if(rem <= (x/2)) Console.WriteLine(pow - rem);    
                else Console.WriteLine(pow + (x - rem));
            }
        }
    }
}