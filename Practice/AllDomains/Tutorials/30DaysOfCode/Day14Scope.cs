using System;
using System.Linq;

class Difference 
{
    private int[] elements;
    public int maximumDifference;
	// Add your code here
	/*	author:@shivkrthakur  */
    public Difference(int[] elements)
        {
        this.elements = elements;
    }

    public void computeDifference()
    {
        for(int i=0; i < elements.Length; i++)
        {
            for(int k=i+1; k < elements.Length; k++)
            {
                int difference = Math.Abs(elements[i] - elements[k]);
                if(difference > maximumDifference)
                {
                    maximumDifference = difference;   
                }
            }
        }
    }
} // End of Difference Class

class Solution 
{
    static void Main(string[] args) 
	{
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}