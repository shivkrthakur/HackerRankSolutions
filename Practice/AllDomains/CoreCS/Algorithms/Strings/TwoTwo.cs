/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution 
{
    static void Main(String[] args) 
	{
        var t = Convert.ToInt32(Console.ReadLine().Trim());
        Trie trie = new Trie();
        for(var i = 0; i <= 800; i++) 
        {
            string pattern = new BigInteger(Math.Pow(2,i)).ToString();
            trie.InsertWord(pattern);		
        }

        for(int i = 0; i < t; i++){
            var input = Console.ReadLine().Trim();
            TwoTwo(input, trie);
        }
    }
    
    static void TwoTwo(string input, Trie trie)
	{
        int count = 0;
        for(int i = 0; i < input.Length; i++)
        {
            count += trie.SearchPattern(input, i);
        }
        Console.WriteLine(count);
    }
    
    public class TrieNode
    {
        public char Value { get; set; }
        public int Counter { get; set; }
        public bool IsWord { get; set; }
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public TrieNode(){ }
        public TrieNode(char value)
        {
            Value = value;
        }
    }

    public class Trie
    {
        public TrieNode Root = new TrieNode();
	    public Trie() { }
        
        public void InsertWord(string word)
        {
            TrieNode t = Root;
            for(int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                if(t.Children.ContainsKey(c)) 
                {
                    t = t.Children[c];
                    t.Counter++;
                }
                else 
                {
                    var temp = new TrieNode(c);
                    temp.Counter = 1;
                    t.Children.Add(c, temp);
                    t = temp;
                }
            }
            if(t != Root) t.IsWord = true;
        }

        public bool SearchPattern(string pattern)
        {
            var t = Root;
            for(int i = 0; i < pattern.Length; i++)
            {
                var c = pattern[i];
                if(t.Children.ContainsKey(c)) t = t.Children[c];
                else return false;
            }
            return t != Root && t.IsWord;
        }
        
        public bool SearchPattern(string pattern, ref bool isWord)
        {
            var t = Root;
            for(int i = 0; i < pattern.Length; i++)
            {
                var c = pattern[i];
                if(t.Children.ContainsKey(c)) t = t.Children[c];
                else return false;
            }
            isWord = t.IsWord;
            return t != Root;
        }
        
        public int SearchPattern(string pattern, int index)
        {
            var t = Root;
            var count = 0;
            for(int i = index; i < pattern.Length; i++)
            {
                var c = pattern[i];
                if(t.Children.ContainsKey(c)) {
                    t = t.Children[c];
                    if(t.IsWord) count++;
                }
                else break;
            }
            return count;
        }
    }
}