/*	author:@shivkrthakur  */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void SearchUsingDictionary(int[] inputArray, int searchValue)
    {
        var tempTable = new Dictionary<int, int>();
        for(int x = 0; x < inputArray.Length; x++)
        {
            int complement = searchValue - inputArray[x];
            //Console.WriteLine($"x: {x} a[x]: {a[x]} complement: {complement}");
            if(tempTable.ContainsKey(complement))
            {
                if(tempTable[complement] > x)
                    Console.WriteLine($"{x+1} {tempTable[complement] + 1}");
                else
                    Console.WriteLine($"{tempTable[complement] + 1} {x+1}");
                break;
            }
            if(!tempTable.ContainsKey(inputArray[x]))
                tempTable.Add(inputArray[x],x);
        }
    }

    static int SearchUsingInbuiltBinarySearch(int[] a, int searchValue)
    {
        int[] inputArray = new int[a.Length];
        a.CopyTo(inputArray,0);
        Array.Sort(inputArray);
        for(int x = 0; x < inputArray.Length; x++)
        {
           int complement = searchValue - inputArray[x];
           int searchedIndex = Array.BinarySearch(inputArray,complement);
           //Console.WriteLine($"x: {x} inputArray[x]: {inputArray[x]} complement: {complement} SearchedIndex:{searchedIndex}");
           if(searchedIndex >= 0)
           {
               return inputArray[x];
           }
        }
        return -1;
    }

    static int SearchUsingCustomBinarySearch(int[] a, int searchValue)
    {
        int[] inputArray = new int[a.Length];
        a.CopyTo(inputArray,0);
        Array.Sort(inputArray);
        //Console.WriteLine(String.Join(" ", inputArray));
        for(int x = 0; x < inputArray.Length; x++)
        {
           int complement = searchValue - inputArray[x];
           int searchedIndex = BinarySearch(inputArray,0, inputArray.Length - 1, complement);
           //Console.WriteLine($"x: {x} inputArray[x]: {inputArray[x]} complement: {complement} SearchedIndex:{searchedIndex}");
           if(searchedIndex >= 0)
           {
               return inputArray[x];
           }
        }
        return -1;
    }

    static int BinarySearch(int [] a, int leftStart, int rightEnd, int searchValue)
    {
        int output = -1;
        if(leftStart >= rightEnd) return -1;

        int leftEndRightStart = (rightEnd + leftStart)/2;
        //Console.WriteLine($"leftStart:{leftStart} rightEnd:{rightEnd} leftEndRightStart:{leftEndRightStart} a[leftEndRightStart]:{a[leftEndRightStart]} SearchValue:{searchValue}");
        if(searchValue == a[leftEndRightStart]) { return leftEndRightStart;}
        else if(searchValue < a[leftEndRightStart]) output = BinarySearch(a, leftStart, leftEndRightStart, searchValue);
        else output =  BinarySearch(a, leftEndRightStart + 1, rightEnd, searchValue);
        return output;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            //SearchUsingDictionary(a, m);
            //int x = SearchUsingInbuiltBinarySearch(a,m);
            int x = SearchUsingCustomBinarySearch(a, m);
            int index1 = -1, index2 = -1;
            int complement = m - x;
            for(int i = 0; i < a.Length; i++)
            {
                if(index1 == -1 && a[i] == x)
                {
                    index1 = i;
                }
                else if(a[i] == complement)
                        index2 = i;
            }
            if(index1 < index2)
               Console.WriteLine($"{++index1} {++index2}");
            else
                Console.WriteLine($"{++index2} {++index1}");
        }
    }

}
