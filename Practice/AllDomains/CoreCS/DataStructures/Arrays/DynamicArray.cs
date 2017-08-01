/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int [] NQ = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
        int n = NQ[0], Q = NQ[1];
        int [][] seqList = new int[n][];

        int lastAns = 0;
        for(int i = 0; i < Q; i++)
        {
            int [] qxy = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int q = qxy[0], x = qxy[1], y = qxy[2];
            int index;
            int [] seq;
            switch(q)
            {
                case 1:
                    index = (x ^ lastAns) % n;
                    seq = seqList[index];
                    if(seq == null ) { seq = new int[] { y }; seqList[index] = seq; }
                    else
                    {
                        Array.Resize(ref seq, seq.Length + 1);
                        seq[seq.Length - 1] = y;
                        seqList[index] = seq;
                    }
                    break;

                case 2:
                    index = (x ^ lastAns) % n;
                    seq = seqList[index];
                    lastAns = y % seq.Length;
                    lastAns = seq[lastAns];
                    Console.WriteLine($"{lastAns}");
                    break;
            }
        }
    }
}
