using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int V = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int [] N = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
        int i = -1;
        while(++i < n && V != N[i]);
        Console.WriteLine(i);
        
    }
}