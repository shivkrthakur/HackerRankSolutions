/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t < T; t++)
        {
            string inputString = Console.ReadLine();
            int len = inputString.Length;
            int count = 0;
            for(int k = 1; k < len; k++)
            {
                for(int i = 0; i <= len - k; i++)
                {
                    var sub1 = inputString.Substring(i, k).ToCharArray();
                    for(int j = i + 1; j <= len - k; j++)
                    {
                        var sub2 = inputString.Substring(j, k).ToCharArray();
				        if(IsAnagram(sub1, sub2) > 0) count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
    
    static int IsAnagram(char [] a, char []b)
    {
       int [] first = new int[26];
       if(a.Length != b.Length) 
            return 0;
        int c = 0;
        while (c < a.Length) {
            first[a[c]-'a']++;
            first[b[c]-'a']--;
            c++;
        }
        for (c = 0; c < 26; c++) 
           if (first[c]>0  || first[c]<0)
              return 0;
            return 1;
    }
    
}