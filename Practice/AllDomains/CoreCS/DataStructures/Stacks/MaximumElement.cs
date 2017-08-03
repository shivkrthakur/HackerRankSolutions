/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        Stack<int> maxStack = new Stack<int>();
        maxStack.Push(0);
        for(int i = 0; i < n; i++){
            string input = Console.ReadLine();
            int query = Convert.ToInt32(input[0].ToString());

            if(query == 1)
            {
                stack.Push(Convert.ToInt32(input.Split()[1]));
                if(stack.Peek() >= maxStack.Peek()) maxStack.Push(stack.Peek());
            }
            else if(query == 2)
            {
                if(maxStack.Peek() == stack.Peek()) maxStack.Pop();
                stack.Pop();
            }
            else Console.WriteLine(maxStack.Peek());
        }
    }
}
