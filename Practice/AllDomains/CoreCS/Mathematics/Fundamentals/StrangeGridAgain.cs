/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var input = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int64.Parse);
        long row = input[0], col = input[1];
        long output = 0;
        if(((row - 1) & 1) == 0){ output = ((row - 1)/2) * 10; }
        else output = ((row - 1)/2) * 10 + 1;
        Console.WriteLine(output + (2 * (col - 1)));
    }
}