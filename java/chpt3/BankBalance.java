/**
 * @(#)BankBalance.java
 *
 *
 * @author 
 * @version 1.00 2014/9/11
 */
import java.util.Scanner;

public class BankBalance 
{	
	public static final double OVERDRAWN_PENALTY = 8.00;
	public static final double INTEREST_RATE = 0.02; //2% annually 


    public static void main (String[] args)
    {
    	double balance;
   
    	System.out.print("Enter your checking account balance: $");
    	Scanner keyboard = new Scanner(System.in);
    	balance = keyboard.nextDouble();
    	System.out.println("Original balance $" +balance);
    	
    	if(balance>=0)
    	  	balance = balance +(INTEREST_RATE*balance)/12;
    	else
    		balance = balance - OVERDRAWN_PENALTY;
    	
    	System.out.print("After adjusting for one month ");
    	System.out.println("of interest and penalties, ");
    	System.out.printf("your new balance is %5.2f $ ",balance);
    	
    }
    
    
    
    
}