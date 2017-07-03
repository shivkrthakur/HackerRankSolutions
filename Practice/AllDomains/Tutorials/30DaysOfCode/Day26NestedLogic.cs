/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int[] userReturnDate = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] actualReturnDate = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            if (userReturnDate[2] == actualReturnDate[2])
            {
                if (userReturnDate[1] == actualReturnDate[1])
                {
                    if (userReturnDate[0] > actualReturnDate[0])
                    {
                        int days = userReturnDate[0] - actualReturnDate[0];
                        Console.WriteLine(15 * days);
                        return;
                    }
                }
                else if (userReturnDate[1] > actualReturnDate[1])
                {
                    int monthsLate = userReturnDate[1] - actualReturnDate[1];
                    Console.WriteLine(500 * monthsLate);
                    return;
                }
            }
            else if (userReturnDate[2] > actualReturnDate[2])
            {
                Console.WriteLine("10000");
                return;
            }
            Console.WriteLine("0");
    }
}
