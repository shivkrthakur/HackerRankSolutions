using System;

//Write your code here
class Calculator
{
    public int power(int n, int p)
    {
        int result = 1;
        if(n < 0 | p < 0)
		{
            throw new Exception("n and p should be non-negative");
        }
        
        for(int i = 1; i <= p; i++)
        {
            result = result * n;
        }
        return result;
    }
}

class Solution
{
    /*	author:@shivkrthakur  */
	static void Main(String[] args)
	{
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
    }
}