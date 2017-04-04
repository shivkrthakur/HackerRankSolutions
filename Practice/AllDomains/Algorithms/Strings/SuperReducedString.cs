using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string s = Console.ReadLine();
        List<char> input = s.ToCharArray().ToList();
        int i = 0;
        while(i < input.Count -1) 
        {
            if(input[i] == input[i + 1])
            {
                input.RemoveAt(i + 1);
                input.RemoveAt(i);
                i=0;
            }
            else
            i++;
        }
        if(input.Count > 0)
        Console.WriteLine(string.Join("", input));
        else
            Console.WriteLine("Empty String");

    }
}