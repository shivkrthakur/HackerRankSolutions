using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < n; a0++){
            int grade = Convert.ToInt32(Console.ReadLine());
            // your code goes here
                if(grade < 38) Console.WriteLine(grade);
                else if(((5 * ((grade/5) + 1)) - grade) < 3) Console.WriteLine(5 * ((grade/5) + 1));
                else Console.WriteLine(grade);
        }
    }
}
