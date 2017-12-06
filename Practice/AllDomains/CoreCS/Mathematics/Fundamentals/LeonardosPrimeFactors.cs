/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 0; i < q; i++){
            long n = Convert.ToInt64(Console.ReadLine().Trim());
            int c = 0;
            for(long rm = 2, j = 3; rm > 0 && rm <= n; j += 2){
                if(rm == 2) c = 1;
                if(IsPrime(j)){
                   rm *= j;
                   if(rm > 0 && rm <= n) c++;
                }
            }
            Console.WriteLine(c);
        }
    }
    
    static bool IsPrime(long num){
        if(num > 1 && ((num & 1) > 0)){
            int th = (int)Math.Sqrt(num);
            for(int i = 3; i <= th; i += 2) if((num % i) == 0) return false;
            return true;
        }
        else return num == 2;
    }
}