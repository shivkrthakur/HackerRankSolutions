using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        if((x1 <= x2 && v1 < v2) | (x2 <= x1 && v2 < v1))
        {
            Console.WriteLine("NO");
            return;
        }
        int xdiff = x1 - x2;
        int vdiff = v2 - v1;
        var y = (float)xdiff/vdiff;
        if((y - (int)y) == 0)
    	   Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}
