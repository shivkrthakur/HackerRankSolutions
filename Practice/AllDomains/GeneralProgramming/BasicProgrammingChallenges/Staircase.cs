using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            for(int j = n-1; j >=0; j--)
            {
                if(j == i || j < i)
                {
                    Console.Write("#");
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
            
        }
    }
}
