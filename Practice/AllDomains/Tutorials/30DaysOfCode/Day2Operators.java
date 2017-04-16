public class Arithmetic 
{
	/*	author:@shivkrthakur  */
    public static void main(String[] args) 
	{
        Scanner scan = new Scanner(System.in);
        double mealCost = scan.nextDouble(); // original meal price
        int tipPercent = scan.nextInt(); // tip percentage
        int taxPercent = scan.nextInt(); // tax percentage
        scan.close();
      
        double tip = (tipPercent/100.0) * mealCost;
        double tax = (taxPercent/100.0) * mealCost;
        
        // Write your calculation code here.
      
        // cast the result of the rounding operation to an int and save it as totalCost 
        int totalCost = (int) Math.round(mealCost + tip + tax);
        System.out.println("The total meal cost is " + totalCost + " dollars.");
        // Print your result
    }
}
