/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static int Fibonacci(int n) {
        // Write your code here.
        if(n == 0 || n == 1) return n;
        int fibSum = Fibonacci(n - 1) + Fibonacci(n - 2);
        return fibSum;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}
