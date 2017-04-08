using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution 
{
    /*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
	    string exp = @"^[_.]\d+([a-zA-Z]*)_?$";
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string text = Console.ReadLine();
            if(Regex.Match(text,exp).Success) Console.WriteLine("VALID");    
            else Console.WriteLine("INVALID");    
        }
    }
}