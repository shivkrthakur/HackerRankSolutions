using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string inputStrA = Console.ReadLine().Trim();
        string inputStrB = Console.ReadLine().Trim();
        int countA = 0, countB = 0, counter = 0;
        
        for(int x = 0; x < inputStrA.Length;)
        {
            char curChar = inputStrA[x];
            countA = inputStrA.Count(c => c == curChar);
            countB = inputStrB.Count(c => c == curChar);
            counter += Math.Abs(countA - countB);
            inputStrA = inputStrA.Replace(curChar.ToString(),string.Empty);
            inputStrB = inputStrB.Replace(curChar.ToString(),string.Empty);
        }
        
        counter += inputStrB.Length;
        Console.WriteLine(counter);
    }
}
