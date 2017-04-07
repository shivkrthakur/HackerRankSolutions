using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    /*	author:@shivkrthakur  */
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int numberOfCities = Convert.ToInt32(tokens_n[0]);
            int numberOfRoads = Convert.ToInt32(tokens_n[1]);
            int costOfLib = Convert.ToInt32(tokens_n[2]);
            int costOfRoad = Convert.ToInt32(tokens_n[3]);
            bool [] visited = new bool[numberOfCities + 1];		
            Dictionary<long, List<long>> am = new Dictionary<long, List<long>>();
            for(var i=0; i <= numberOfCities; i++) {
                am.Add(i, new List<long>());
            }
            for(int a1 = 0; a1 < numberOfRoads; a1++){
                string[] tokens_city_1 = Console.ReadLine().Split(' ');
                int city_1 = Convert.ToInt32(tokens_city_1[0]);
                int city_2 = Convert.ToInt32(tokens_city_1[1]);
                am[city_1].Add(city_2);
                am[city_2].Add(city_1);
            }
            
            long roads = 0, libraries = 0;
            for(int k = 1; k < visited.Length; k++)
            {
                if(!visited[k])
                {
                    roads += DFS(k, am, visited).Count - 1;
                    libraries++;
                }
            }
            ulong totalCost = ((ulong)roads * (ulong)costOfRoad) + ((ulong)libraries * (ulong)costOfLib);
            ulong tc = (ulong)costOfLib * (ulong)numberOfCities;
            if (tc < totalCost) totalCost = tc;
            Console.WriteLine(totalCost);
        }
    }
    
    static HashSet<int> DFS(int startNode, Dictionary<long, List<long>> am, bool[] visited)
    {
        HashSet<int> cities = new HashSet<int>();
        Stack<int> stack = new Stack<int>();

        int element = startNode;		
        cities.Add(element);
        //Console.WriteLine("element 1 : " + element + "\t");		
        visited[startNode] = true;		
        stack.Push(startNode);

        while (stack.Count != 0)
        {
            element = stack.Peek();
            int number_of_nodes = am[element].Count;;
            int i = 0;	
            //Console.WriteLine($"number_of_nodes:{number_of_nodes} element:{element}");
            while (i < number_of_nodes)
            {
                int val = (int) am[element][i];
                //Console.WriteLine($"val:{val} visited[val]:{visited[val]}");
                if(!visited[val])
                {
                    stack.Push(val);
                    visited[val] = true;
                    element = val;
                    i = 0;
                    number_of_nodes = am[element].Count;;
                    cities.Add(element);
                    //Console.WriteLine($"element 2:{element} number_of_nodes:{number_of_nodes}");
                    continue;
                }
                i++;
            }
            int popVal = stack.Pop();	
            //Console.WriteLine($"popVal:{popVal} i:{i}");
        }
        return cities;
    }
}
