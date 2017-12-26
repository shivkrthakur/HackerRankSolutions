/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var console = Console.In;
        int t = Convert.ToInt32(console.ReadLine().Trim());
	    for(int i = 0; i < t; i++)
        {
            Console.WriteLine(SherlockAndDivisors(Convert.ToInt32(console.ReadLine().Trim())));
        }
    }
    
    static int SherlockAndDivisors(int num)
    {
        int count = 0;
        var factors = FindAllFactors(num);
        foreach(var factor in factors) if((factor & 1) == 0) count++;
        //Console.WriteLine(factors);
        return count;
    }

    static SortedSet<int> FindAllFactors(int num){
        var sortedSet = new SortedSet<int>(){ num };
        
        int limit = (int)Math.Floor(Math.Sqrt(num));
        for( int i = 2; i <= limit; i++){
            if(num % i == 0) {
                sortedSet.Add(i);
                sortedSet.Add(num/i);
            }
        }
        return sortedSet;
    }
}