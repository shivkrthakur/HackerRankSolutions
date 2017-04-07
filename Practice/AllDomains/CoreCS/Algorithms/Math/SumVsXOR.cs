using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    /*	author:@shivkrthakur  */
    static void Main(String[] args) {
        long n = Convert.ToInt64(Console.ReadLine());
        int count = (n == 0) ? 0 : Convert.ToString(n,2).Count(x => x == '0');
        Console.WriteLine(Math.Pow(2,count));
    }
}
