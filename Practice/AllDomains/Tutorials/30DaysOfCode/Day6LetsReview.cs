using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int x = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < x; i++)
        {
            string strInput = Console.ReadLine().Trim();
            string evenStrOutput = string.Empty;
            string oddStrOutput = string.Empty;
            
            for(int k = 0; k < strInput.Length; k++)
            {
                if(k % 2 == 0)
                {
                    evenStrOutput += strInput[k];
                }
                else
                {
                    oddStrOutput += strInput[k];
                }
            }
            Console.WriteLine("{0} {1}", evenStrOutput, oddStrOutput);
            
        }
    }
}