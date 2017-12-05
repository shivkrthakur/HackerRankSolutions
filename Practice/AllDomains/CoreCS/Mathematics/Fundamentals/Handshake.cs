/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int T = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < T; a0++){
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((N - 1) * (N))/2);
        }
    }
}
