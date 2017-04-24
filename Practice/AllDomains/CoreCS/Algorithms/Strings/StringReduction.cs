using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
	/*	author:@shivkrthakur  */
    static int ReduceString(string s, string tgt, string rep)
    {
        var dict = new Dictionary<char,int>() {	{ 'a', 0 },	{ 'b', 0 },	{ 'c', 0 } };
        for(int j = 0; j < s.Length; j++) dict[s[j]]++;
		if((dict['a'] == 0 && dict['b'] == 0) || (dict['b'] == 0 && dict['c'] == 0) || (dict['a'] == 0 && dict['c'] == 0))
			return dict.Single(x => x.Value > 0).Value;
		else
			if(((dict['a'] % 2 == 0) && (dict['b'] % 2 == 0) && (dict['c'] % 2 == 0)) || (((dict['a'] & 1) > 0) && (dict['b'] % 2 > 0) && (dict['c'] % 2 > 0))) return 2;
			else return 1;
    }
    
    static int stringReduction (string a) 
    {
        return ReduceString(a, "ab", "c");
    }
    /* Tail starts here */
    static void Main(String[] args) {
        int res;
        int _t_cases = Convert.ToInt32(Console.ReadLine());
        for (int _t_i=0; _t_i<_t_cases; _t_i++) {
            String _a = Console.ReadLine();
            res=stringReduction(_a);
            Console.WriteLine(res);
        }
    }
}
