/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        string[] genes = Console.ReadLine().Split(' ');
        string[] health_temp = Console.ReadLine().Split(' ');
        int[] healths = Array.ConvertAll(health_temp,Int32.Parse);
        var map = new Dictionary<String, Tuple<List<Tuple<int,long>>, long>>();
        var geneSubstrings = new HashSet<string>();
        int largestGeneSize = 0;
        for (int i = 0; i < n; i++)
        {
            var list = new List<Tuple<int,long>>();
            var t = new Tuple<int,long>(i, healths[i]);
            string gene = genes[i];
            largestGeneSize = Math.Max(gene.Length, largestGeneSize);
            if (map.ContainsKey(gene))
            {
                var tup = map[gene];
                tup.Item1.Add(t);
                map[gene] = Tuple.Create(tup.Item1, tup.Item2 + t.Item2);
            }
            else
            {
                list.Add(t);
                map.Add(gene, new Tuple<List<Tuple<int,long>>, long>(list,t.Item2));
            }

            for (int j = 1; j <= gene.Length && j < 500; j++)
                geneSubstrings.Add(gene.Substring(0, j));
        }
        
        int s = Convert.ToInt32(Console.ReadLine());
        long maxValue = Int64.MinValue;
        long minValue = Int64.MaxValue;

        for(int a0 = 0; a0 < s; a0++){
            string[] tokens_first = Console.ReadLine().Split(' ');
            int start = Convert.ToInt32(tokens_first[0]);
            int end = Convert.ToInt32(tokens_first[1]);
            string geneStrand = tokens_first[2];
            // your code goes here
            bool flag = (end - start + 1) < (n/2) ? true : false;
            long h = 0;
            int len = geneStrand.Length;
            for (int f = 0; f < len; f++)
            {
                for (int j = 1; j <= largestGeneSize && f + j <= len; j++)
                {
                    string str = geneStrand.Substring(f, j);
                    if (!geneSubstrings.Contains(str)) { break; }

                    if (map.ContainsKey(str)) 
                    {
                        var tuples = map[str].Item1;
                        if(flag)
                        {
                            for(int a = 0; a < tuples.Count; a++)
                            {
                                var t = tuples[a];
                                if (t.Item1 >= start && t.Item1 <= end)
                                {
                                    h += t.Item2;
                                }
                            }
                        }
                        else
                        {
                            long diff = 0;
                            int a = 0;
                            for(; a < tuples.Count && tuples[a].Item1 < start; a++)
                                diff += tuples[a].Item2;
                            for(a = tuples.Count - 1; a >= 0 && tuples[a].Item1 > end; a--) 
                                diff += tuples[a].Item2;
                            h += map[str].Item2 - diff;
                        }
                    }
                }
            }
            if (h > maxValue) maxValue = h;
            if (h < minValue) minValue = h;
        }
	   Console.WriteLine($"{minValue} {maxValue}");
    }
}
