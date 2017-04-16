using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
    static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        double mealCost = Convert.ToDouble(Console.ReadLine().Trim());
        double tipPerc = Convert.ToDouble(Console.ReadLine().Trim());
        double taxPerc = Convert.ToDouble(Console.ReadLine().Trim());
        
        double tip = ((tipPerc/100) * mealCost);
        double tax = ((taxPerc/100) * mealCost);
        
        int totalMealCost = Convert.ToInt32(mealCost + tip + tax);
        Console.WriteLine("The total meal cost is {0} dollars.", totalMealCost);
    }
}