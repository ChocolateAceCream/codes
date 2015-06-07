/**
 * @(#)BankBalance.java
 *
 *
 * @author 
 * @version 1.00 2014/9/11
 */
import java.util.Scanner;

public class Test 
{	
	public static final double OVERDRAWN_PENALTY = 8.00;
	public static final double INTEREST_RATE = 0.02; //2% annually 


    public static void main (String[] args)
    {
    		System.out.println("This program computes the average of ");
    	System.out.println("a list of (nonnegative) exam scores.");
    	double sum;
    	int numberOfStudents;
    	double next;
    	String answer;
    	Scanner keyboard = new Scanner(System.in);
    	
    	do
    	{
    		System.out.println();
    		System.out.println("Enter all the scores to be averaged.");
    		System.out.println("Enter a negative number after");
    		System.out.println("you have entered all the scores.");
    		sum = 0;
    		numberOfStudents = 0;
    		next = keyboard.nextDouble();
    		while(next>=0)
    		{
    			sum = sum+next;
    			numberOfStudents++;
    			next = keyboard.nextDouble();	
    		}
    		if(numberOfStudents>0)
    			System.out.println("The average is "+(sum/numberOfStudents));
    		else
    			System.out.println("No scores to average.");
    		System.out.println("Want to average another exam?");
    		System.out.println("Enter yes or no.");
    		answer = keyboard.next();
    	}while(answer.equalsIgnoreCase("yes"));
   
    	
    }
    
    
    
    
}