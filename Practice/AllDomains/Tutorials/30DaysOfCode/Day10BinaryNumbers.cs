using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        string s = Convert.ToString(Convert.ToInt32(Console.ReadLine()),2);
        int maxOnesCount = 0, onesCount=0;
        for(int i = 0; i < s.Length; i++)
        {
            char digit = s[i];
            if(digit == '0') onesCount = 0;    
            
            if(digit == '1' || (digit == '1' && (i+1) < s.Length && digit == s[i+1]))
            {
                onesCount++;    
            }
            
            if(onesCount > maxOnesCount)
            {
                maxOnesCount = onesCount;
            }
        }
        Console.WriteLine(maxOnesCount);
    }
}
