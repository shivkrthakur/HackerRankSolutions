/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        List<string> magazine = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
        List<string> ransom = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
        bool yesOrNo = true;
        
        if(n > m) { Console.WriteLine("No"); return; }
        
        ///*
        foreach (string strA in ransom)
        {
            if (!magazine.Remove(strA))
            {
                yesOrNo = false;
                break;
            }
        }//*/

        if (yesOrNo) Console.WriteLine("Yes"); 
        else Console.WriteLine("No");
    }
}
