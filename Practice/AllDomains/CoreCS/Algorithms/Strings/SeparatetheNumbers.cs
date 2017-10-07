/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++)
		{
            string s = Console.ReadLine();
            bool yes = false;
            int len = s.Length;
            string tBk = string.Empty;
            for(int j = 0; j < len/2; j++)
            {
                tBk += s[j];
                string temp = tBk;
                int ind = 0, tInd = 0;
                while((ind) > -1 && (tInd == ind) && (ind += temp.Length) < len)
                {
                    tInd = ind;
                    long intVal = Convert.ToInt64(temp);
                    temp = (intVal+1).ToString();
                    ind = s.IndexOf(temp, ind);
                }
                if((ind) >= len) { yes = true; break; }
            }
            if(yes) Console.WriteLine($"YES {tBk}"); 
            else Console.WriteLine("NO");
        }
    }
}
