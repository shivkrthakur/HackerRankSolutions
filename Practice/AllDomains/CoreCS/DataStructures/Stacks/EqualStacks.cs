/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        String [][] input = new String[3][];
        input[0] = Console.ReadLine().Split(' ');
        input[1] = Console.ReadLine().Split(' ');
        input[2] = Console.ReadLine().Split(' ');
        Tuple<int, Stack<int>> [] list = new Tuple<int, Stack<int>>[3];
        int index = 0;
        for(int i = 0; i < input.Length; i++){
            var stack = new Stack<int>();
            int [] cy = input[i].Select(x => Int32.Parse(x)).ToArray();
            int sum = 0;
            for(int j = cy.Length - 1; j >= 0; j--){
                stack.Push(cy[j]);
                sum += cy[j];
            }
		   list[index++] = new Tuple<int, Stack<int>>(sum, stack);
	   }

        Array.Sort(list, (x, y) => y.Item1 - x.Item1);
        while(!(list[0].Item1 == list[1].Item1 && list[1].Item1 == list[2].Item1)){
            var tup = list[0];
            list[0] = new Tuple<int, Stack<int>>(tup.Item1 - tup.Item2.Pop(), tup.Item2);
            Array.Sort(list, (x, y) => y.Item1 - x.Item1);
        }
        Console.WriteLine(list[0].Item1);
    }
}
