using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        string inputString = Console.ReadLine();
        try
            {
                int x = Convert.ToInt32(inputString);
            Console.WriteLine(x);
        }
        catch
            {
            Console.WriteLine("Bad String");
        }
    }
}