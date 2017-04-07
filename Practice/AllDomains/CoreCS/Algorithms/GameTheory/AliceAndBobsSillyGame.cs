using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    /*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int g = Convert.ToInt32(Console.ReadLine());
	    HashSet<int> primes = new HashSet<int>();
        for(int a0 = 0; a0 < g; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            // your code goes here
            int startValue = primes.Count == 0 ? 0 : primes.Max();
            for(int i = startValue; i <= n; i++)
            {
                if(IsPrime(i)) primes.Add(i);
            }
            if((primes.Count(x => x <= n) % 2) == 0) Console.WriteLine("Bob");
            else Console.WriteLine("Alice");
        }
    }
    
    static bool IsPrime(int candidate)
    {
        if(candidate > 1 && (candidate & 1) != 0)
        {
            int higherEnd = (int)Math.Floor(Math.Sqrt(candidate));
            for(int i = 3; i <= higherEnd; i += 2)
            {
                if((candidate % i) == 0) return false;
            }
            return true;
        }
        else return candidate == 2;
    }
}
