using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        int p = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < p; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(CheckPrimality(n)) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
    }
    
    static bool CheckPrimality(int inputNumber)
    {
        if(inputNumber > 1 && (inputNumber & 1) != 0)
        {
            int higherLimit = (int)Math.Sqrt(inputNumber);
            for(int x = 3; x <= higherLimit; x += 2)
            {
                if(inputNumber % x == 0) return false;    
            }
            return true;
        }
        else return inputNumber == 2;
        
    }
}
