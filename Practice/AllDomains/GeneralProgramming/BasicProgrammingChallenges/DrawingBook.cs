using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        // your code goes here
        int mid = n/2;
        if(p <= mid)
        {
            Console.WriteLine(p/2);    
        }
        else
        {
            Console.WriteLine((n-p)/2);
        }
    }
}
