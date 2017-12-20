/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int queries = Convert.ToInt32(Console.ReadLine().Trim());
        for(int counter = 0; counter < queries; counter++)
        {
            BigInteger[] inputArr = Array.ConvertAll(Console.ReadLine().Trim().Split(), BigInteger.Parse);
            BigInteger aa = inputArr[0];
            BigInteger bb = inputArr[1];
            BigInteger k = inputArr[2];
            long m = (long)inputArr[3];
            aa = aa % m;
            bb = bb % m;
            
            //Console.WriteLine($"a: {a} b: {b} k: {k} m: {m}");
            long resultReal = 1, resultImag = 0, a = (long)aa, b = (long)bb, resultRealTemp = (long)aa, resultImagTemp = (long)bb;
            while (k > 0)
            {
                if (k % 2 != 0)
                {
                    resultRealTemp = resultRealTemp % m;
                    resultImagTemp = resultImagTemp % m;
                    long resultRealTemp1 = (resultReal * resultRealTemp) - (resultImag * resultImagTemp);
                    long resultImagTemp1 = (resultReal * resultImagTemp) + (resultImag * resultRealTemp);
                    resultReal = resultRealTemp1 % m;
                    resultImag = resultImagTemp1 % m;
                }
                k >>= 1;
                a = a % m;
                b = b % m;
                resultImagTemp = 2 * a * b;
                resultRealTemp = (a * a) - (b * b);
                a = resultRealTemp % m;
                b = resultImagTemp % m;
            }
            mod_clip(ref resultReal, m);
            mod_clip(ref resultImag, m);
            Console.WriteLine($"{resultReal} {resultImag}");
        }
    }
    
    public static void mod_clip(ref long v, long mod)
    {
        v = v % mod;
        if(v < 0)
        {
            v = mod + v;
        }
    }
}