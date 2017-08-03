/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int T = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < T; a0++){
            string s = Console.ReadLine();
            bool isBalanced = true;
            Stack<char> chars = new Stack<char>();
            for(int i = 0; i < s.Length; i++){
                var c = s[i];
                if(c == '(' || c == '{' || c == '[') chars.Push(c);
                else if(chars.Count > 0){
                    var t = chars.Peek();
                    if( (c == ')' && t == '(') || (c == '}' && t == '{') || (c == ']' && t == '[') ) chars.Pop();
                    else { isBalanced = false; break; }
                }
                else { isBalanced = false; break; }
            }
            Console.WriteLine(isBalanced && chars.Count == 0 ? "YES" : "NO");
        }
    }
}
