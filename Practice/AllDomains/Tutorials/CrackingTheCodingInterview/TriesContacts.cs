/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution 
{
    static void Main(String[] args) 
	{
        int n = Convert.ToInt32(Console.ReadLine());
        Trie trie = new Trie();
        for(int a0 = 0; a0 < n; a0++){
            string[] tokens_op = Console.ReadLine().Split(' ');
            string op = tokens_op[0];
            string contact = tokens_op[1];
            switch(op)
            {
                case "add":
                        trie.InsertWord(contact);
                    break;
                case "find":
                        Console.WriteLine(trie.WordOccurences(contact));
                    break;
            }
        }
    }
    
    public class TrieNode
    {
        public char Val { get; set; }
        public TrieNode [] Children { get; set; }
        public bool IsLeaf { get; set; }
        public int Occurencecount { get; set; }
        
        public TrieNode()
        {
            Children = new TrieNode[26];
        }

        public TrieNode(char c)
        {
            Val = c;
            Children = new TrieNode[26];
        }
    }

    public class Trie
    {
        public TrieNode root { get; set; }
        public Trie()
        {
            root = new TrieNode();
        }

        public void InsertWord(string word)
        {
            TrieNode t = root;
            for(int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                int index = c - 'a';
                if(t.Children[index] == null)
                {
                    t.Children[index] = new TrieNode(c);
                    t = t.Children[index];
                    t.Occurencecount = 1;
                }
                else 
                {
                    t = t.Children[index];
                    t.Occurencecount++;
                }
            }
            t.IsLeaf = true;
        }

        public bool StartsWith(string word)
        {
            TrieNode t = root;
            for(int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                var index = c - 'a';
                if(t.Children[index] != null)
                {
                    t = t.Children[index];
                }
                else return false;
            }
            if(t == root) return false;
            return true;
        }
        
        public int WordOccurences(string word)
        {
            TrieNode t = root;
            for(int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                var index = c - 'a';
                if(t.Children[index] != null){
                    t = t.Children[index];
                }
                else return 0;
            }
            return t.Occurencecount;
        }
        
        public int CountWordOccurences(string word)
        {
            int count = 0;
            TrieNode t = root;

            bool found = true;
            for(int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                var index = c - 'a';
                if(t.Children[index] != null)
                {
                    t = t.Children[index];
                }
                else found = false;
            }
            if(t == root) found = false;

    		
            if(found)
            {
                if(t.IsLeaf) count++;
                GetWordsCount(t, ref count);
            }
            return count;
        }

        void GetWordsCount(TrieNode t, ref int count)
        {
            for(int k = 0; k < t.Children.Length; k++)
            {
                if(t.Children[k] != null)
                {
                    var temp = t.Children[k];
                    if(temp.IsLeaf) count++;
                    GetWordsCount(temp, ref count);
                }
            }
        }
    }
}
