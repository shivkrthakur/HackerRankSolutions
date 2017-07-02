/*	author:@shivkrthakur  */
using System;

class Printer
{
	// Add your code here
     public static void printArray<T>(T [] arr)
     {
         for(int i = 0; i < arr.Length; i++)
         {
            Console.WriteLine(arr[i]);
         }
     }
	 
    static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] intArray = new int[n];
		for (int i = 0; i < n; i++)
		{
			intArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		n = Convert.ToInt32(Console.ReadLine());
		string[] stringArray = new string[n];
		for (int i = 0; i < n; i++)
		{
			stringArray[i] = Console.ReadLine();
		}
		
		PrintArray<Int32>(intArray);
		PrintArray<String>(stringArray);
	}
}