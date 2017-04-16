using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
	/*	author:@shivkrthakur  */
	static void Main(String[] args) 
	{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int x = Convert.ToInt32(Console.ReadLine().Trim());
        
        Dictionary<string, string> phoneBook = new Dictionary<string, string>(x);
        for(int i = 0; i < x; i++)
        {
            string nameAndPhone = Console.ReadLine();
            string name = nameAndPhone.Substring(0, nameAndPhone.IndexOf(' '));
            string phone = nameAndPhone.Substring(nameAndPhone.IndexOf(' ')+1);
            
            phoneBook[name] = phone;
        }
        
        for(int i = 0; i < x; i++)
        {
            string name = Console.ReadLine();
            if(phoneBook.ContainsKey(name))
            {
                Console.WriteLine("{0}={1}", name, phoneBook[name]);
            }
            else 
            {
                Console.WriteLine("Not found");    
            }
        }
    }
}