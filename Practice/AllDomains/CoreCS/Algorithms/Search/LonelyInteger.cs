using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */   
    static int LonelyInteger(int [] N)
    {
        int lonelyInt = 0;
        for(int i = 0; i < N.Length; i++) lonelyInt ^= N[i];
        return lonelyInt;
    }
    
   static void Main(String[] args) {
        int res;
        
        int _a_size = Convert.ToInt32(Console.ReadLine());
        int[] _a = new int [_a_size];
        int _a_item;
        String move = Console.ReadLine();
        String[] move_split = move.Split(' ');
        for(int _a_i = 0; _a_i < move_split.Length; _a_i++) {
            _a_item = Convert.ToInt32(move_split[_a_i]);
            _a[_a_i] = _a_item;
        }
        res = LonelyInteger(_a);
        Console.WriteLine(res);
    }
}
