/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int testCasesCount = Convert.ToInt32(Console.ReadLine());
        int[] testCases = new int[testCasesCount];

        for(int i = 0; i < testCasesCount; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            testCases[i] = number;
        }

        for(int i = 0; i < testCasesCount; i++)
        {
            if(IsPrime(testCases[i]))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
    }

    static bool IsPrime(int number)
    {
        if(number <= 0 || number == 1)
            return false;

        int nSqrt = Convert.ToInt32(Math.Sqrt(number));

        for(int x=2; x <= nSqrt; x++ )
        {
            if(IsPrime(x))
            {
                if((number % x) == 0)
                    return false;
            }
        }
        return true;
    }
}
