using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    /*	author:@shivkrthakur  */
	static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int Q = Convert.ToInt32(Console.ReadLine());
        for(int q = 0; q < Q; q++)
        {	
            int [] nk = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            int n = nk[0], k = nk[1];
            int [] A = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            int [] B = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);
            bool permExists = PermutingTwoArrays(A, B, k);
            Console.WriteLine(permExists ? "YES" : "NO" );
        }
    }
    
    static bool PermutingTwoArrays(int [] A, int [] B, int k)
    {
        Array.Sort(A);
        Array.Sort(B);
        bool yes = true;
        for(int i = 0; i < A.Length; i++)
        {
            int sum = A[i] + B[i];
            if(sum < k) { yes = false; break; }		
        }
        if(yes) return yes;

        yes = true;
        Array.Reverse(B);
        for(int i = 0; i < A.Length; i++)
        {
            int sum = A[i] + B[i];
            if(sum < k) { yes = false; break; }		
        }
        if(yes) return yes;

        yes = true;
        Array.Reverse(A);
        for(int i = 0; i < A.Length; i++)
        {
            int sum = A[i] + B[i];
            if(sum < k) { yes = false; break; }		
        }
        if(yes) return yes;

        yes = true;
        Array.Sort(B);
        for(int i = 0; i < A.Length; i++)
        {
            int sum = A[i] + B[i];
            if(sum < k) { yes = false; break; }		
        }
        if(yes) return yes;

        return false;
    }
}