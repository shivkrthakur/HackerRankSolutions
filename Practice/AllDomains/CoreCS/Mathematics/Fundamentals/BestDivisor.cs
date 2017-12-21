/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        var factors = FindAllFactorsOfANumber(n).ToList();
        factors.Sort(delegate(long a, long b){
		var aSum = SumDigitsOfANumber(a);
		var bSum = SumDigitsOfANumber(b);
		if(aSum > bSum) {
			return 1;
		}
		else if(aSum < bSum) 
		{
			return -1;
		}
		else {
			if(a < b) {
				return 1; 
			}
			else {
				return -1;
			}
		}
	   });
       Console.WriteLine(factors.Last()); 
    }
    
    static long SumDigitsOfANumber(long num)
    {
        return num.ToString().ToCharArray().Sum(x => Int32.Parse(x.ToString()));
    }

    static IEnumerable<long> FindAllFactorsOfANumber(long num)
    {
        SortedSet<long> factors = new SortedSet<long>(){ 1, num };
        var tgtFloor = Math.Floor(Math.Sqrt(num));
        for(int i = 2; i <= tgtFloor; i++)
        {
            if((num % i) == 0){
                var quotient = (int)(num/i);
                factors.Add(i);
                factors.Add((int)(num/i));
            }
        }
        return factors;
    }
    
}
