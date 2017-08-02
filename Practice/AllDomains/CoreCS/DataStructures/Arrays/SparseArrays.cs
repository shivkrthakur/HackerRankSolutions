/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string [] strings = new string[n];
        for(int i = 0; i < n; i++)
        {
            strings[i] = Console.ReadLine().Trim();
        }
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        string [] queries = new string[q];
        for(int i = 0; i < q; i++)
        {
            queries[i] = Console.ReadLine().Trim();
        }

        for(int j = 0; j < q; j++)
        {
            int counter = 0;
            string query = queries[j];
            for(int i = 0; i < n; i++)
            {
                if(strings[i] == query) counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
