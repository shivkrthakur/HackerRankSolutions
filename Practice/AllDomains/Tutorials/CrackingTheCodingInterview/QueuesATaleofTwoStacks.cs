/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        
        for(int x = 0; x < n; x++)
        {
            int [] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(),Int32.Parse);
            int queryType = arr[0];
            if(queryType == 1)//ENQUEUE
            {
                int pushVal = arr[1];
                stack1.Push(pushVal);
                //Console.WriteLine("Query Type is 1, Pushed: " + pushVal + " Stack1 Count is : " + stack1.Count);
            }
            else if(queryType == 2)//DEQUEUE
            {
                int popVal = 0;
                if(stack2.Count == 0)
                {
                    while(stack1.Count > 0)
                    {
                        int val = stack1.Pop();
                        stack2.Push(val);
                    }
                }
                
                if(stack2.Count > 0) popVal = stack2.Pop();
                //Console.WriteLine("Query Type is 2, Poped: " + popVal + " Stack2 Count is : " + stack2.Count);
            }
            else if(queryType == 3)//PEEK
            {
                int peekVal = 0;
                if(stack2.Count == 0)
                {
                    while(stack1.Count > 0)
                    {
                        int val = stack1.Pop();
                        stack2.Push(val);
                    }
                }
                
                if(stack2.Count > 0) peekVal = stack2.Peek();  
                //Console.WriteLine("Query Type is 3, Peeked: " + peekVal + " Stack2 Count is : " + stack2.Count);
                Console.WriteLine(peekVal);
            }
        }
    }
}