using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person
{
	/*	author:@shivkrthakur  */
    private int[] testScores;  
   
   public Student(string firstName, string lastName, int id, int [] scores): base(firstName, lastName, id)
   {
        this.testScores = scores;    
   }
    
    public char calculate()
    {
        int average = Average();
        if(average >= 90 && average <=100) return 'O';
        if(average >= 80 && average < 90) return 'E';
        if(average >= 70 && average < 80) return 'A';
        if(average >= 55 && average < 70) return 'P';
        if(average >= 40 && average < 55) return 'D';
        if(average < 40) return 'T';
        return 'F';
    }
    
    public int Average()
    {
        int sum = 0;
        for(int x = 0; x < testScores.Length; x++)
        {
            sum += testScores[x];
        }
        
        return sum/testScores.Length;
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}