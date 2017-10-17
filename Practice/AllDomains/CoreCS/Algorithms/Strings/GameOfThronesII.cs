/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string s = Console.ReadLine();
        int mod7 = (int)(Math.Pow(10,9) + 7);
        int [] chars = new int[26];
        for(int i = 0; i < s.Length; i++) chars[s[i] - 'a']++;
        long num = s.Length/2, den = 1;
        for(int i = 0; i < chars.Length; i++)
        {
            if(chars[i] > 0)
            {
                int temp = chars[i]/2;
                long fact = Factorial(temp, mod7) % mod7;
                den = ((den % mod7) * (fact % mod7)) % mod7;
            }
        }
        long numFact = Factorial(num, mod7) % mod7;
        long output = DivisionModPrimeUsingFermentsLT(numFact, den, mod7) % mod7;
        Console.WriteLine(output);
    }
    
    static long Factorial(long num, int mod7)
    {
        if(num == 0) return 1;
        long temp = Factorial(num - 1, mod7) % mod7;
        return ((num % mod7) * (temp % mod7)) % mod7;
    }
    
    static long DivisionModPrimeUsingFermentsLT(long num, long den, int mod)
    {
        long answer = num * (ModularExponentiations(den, (mod - 2), mod));
        return answer;
    }

    static long ModularExponentiations(long x, long y, int p)
    {
        long result = 1;
        x = x % p;

        while(y > 0)
        {
            if((y & 1) > 0) result = (result * x) % p;
            y >>= 1;
            x = (x * x) % p;
        }
        return result;
    }
}