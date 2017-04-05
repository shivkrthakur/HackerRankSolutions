using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	/*	author:@shivkrthakur  */
    static void Main(String[] args) {
            int aliceScore = 0, bobScore = 0;

            int[] aliceArr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int[] bobArr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);

            if (!int.Equals(aliceArr.Length,3) || !int.Equals(bobArr.Length,3))
            {
                Console.WriteLine("The rating has to be in triplets.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < aliceArr.Length; i++)
            {

                if (aliceArr[i].CompareTo(bobArr[i]) > 0)
                    aliceScore += 1;
                else if (aliceArr[i].CompareTo(bobArr[i]) < 0)
                    bobScore += 1;
            }

            Console.WriteLine($"{aliceScore} {bobScore}");
    }
}
