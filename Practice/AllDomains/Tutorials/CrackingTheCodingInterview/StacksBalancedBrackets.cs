/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

static void Main(String[] args) {
    int t = Convert.ToInt32(Console.ReadLine());
    Stack<char> stack1;

    for(int a0 = 0; a0 < t; a0++){
        string expression = Console.ReadLine();
        int expLen = expression.Length;
        if(expLen % 2 != 0)
        {
            Console.WriteLine("NO");    
        }
        else
        {
            stack1 = new Stack<char>();
            bool yesOrNo = true;
            foreach(char x in expression)
            {
                if(x == '[') stack1.Push(x);
                else if(x == '{') stack1.Push(x);
                else if (x == '(') stack1.Push(x);
                else
                {
                    if(stack1.Count > 0)
                    {
                      if((stack1.Peek() != '(' & x == ')') || (stack1.Peek() != '{' & x == '}') || (stack1.Peek() != '[' & x == ']'))
                      {
                        yesOrNo = false;
                      }
                        stack1.Pop();                    
                    }
                    else
                        yesOrNo = false;
                }
            }

            if(yesOrNo && stack1.Count == 0)
                Console.WriteLine("YES");    
            else
                Console.WriteLine("NO");    
        }
    }
  }
}
