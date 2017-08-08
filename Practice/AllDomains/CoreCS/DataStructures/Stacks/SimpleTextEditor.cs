/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var q = Convert.ToInt32(Console.ReadLine());
        var opStack = new Stack<Tuple<int,string>>();
        var sb = new StringBuilder();
        for(int i = 0; i < q; i++)
        {
            var input = Console.ReadLine().Split();
            var inp = Convert.ToInt32(input[0]);
            switch(inp){
                case 1:
                    var val = input[1];
                    opStack.Push(new Tuple<int,string>(1,val));
                    sb.Append(val);
                    break;
                case 2:
                    int c = Convert.ToInt32(input[1]);
                    int ind = sb.Length - c;
                    var sub = sb.ToString().Substring(ind, c);
                    sb.Remove(ind, c);
                    opStack.Push(new Tuple<int,string>(2,sub));
                    break;
                case 3:
                    int index = Convert.ToInt32(input[1]);
                    Console.WriteLine(sb[index-1]);
                    break;
                case 4:
                    var tup = opStack.Pop();
                    if(tup.Item1 == 1){
                        var len = tup.Item2.Length;
                        var ind4 = sb.Length - len;
                        sb.Remove(ind4, len);
                    }
                    if(tup.Item1 == 2){
                        sb.Append(tup.Item2);
                    }
                    break;
            }
        }
        
    }
}