/*	author:@shivkrthakur  */
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        ArrayList names = new ArrayList();

        for(int a0 = 0; a0 < N; a0++){
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];

            if(Regex.IsMatch(emailID,"@gmail"))
            {
                names.Add(firstName);
            }
        }

        names.Sort();
        foreach(var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
