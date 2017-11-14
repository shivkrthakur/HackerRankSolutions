/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var n = Convert.ToInt32(Console.ReadLine().Trim());
        for(var i = 0; i < n; i++){
            var arr = Console.ReadLine().Split();
            var px = Convert.ToInt32(arr[0]);
            var py = Convert.ToInt32(arr[1]);
            var qx = Convert.ToInt32(arr[2]);
            var qy = Convert.ToInt32(arr[3]);
            Console.WriteLine($"{2 * qx - px} {2 * qy - py}");
        }
    }
}