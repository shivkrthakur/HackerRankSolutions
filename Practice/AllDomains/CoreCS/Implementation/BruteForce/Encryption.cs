using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    /*	author:@shivkrthakur  */
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        int len = s.Length;
        int rows = (int)Math.Floor(Math.Sqrt(len));
        int cols = (int)Math.Ceiling(Math.Sqrt(len));
        int mul = rows * cols;
        if (mul < len)
        {
            rows++;
        }

        string[] op = new string[cols];
        for (int i = 0, j = 0; i < len; i += cols, j++)
        {
            string temp = string.Empty;
            if (i + cols < len)
                temp = s.Substring(i, cols);
            else temp = s.Substring(i, len - i);
            for (int c = 0; c < temp.Length; c++)
            {
                op[c] += temp[c];
            }
        }
        Console.WriteLine($"{string.Join(" ", op)}");
    }
}
