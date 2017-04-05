using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    /*	author:@shivkrthakur  */
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string input = Console.ReadLine();
        HashSet<char> hashSet = new HashSet<char>(input.ToLower().ToCharArray());
        if (hashSet.Contains(' ') && hashSet.Count == 27)
            Console.WriteLine("pangram");
        else Console.WriteLine("not pangram");
    }
}