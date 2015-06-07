/**
 * @(#)BankBalance.java
 *
 *
 * @author 
 * @version 1.00 2014/9/11
 */
import java.util.Scanner;

public class StringEqualityDemo 
{	



    public static void main (String[] args)
    {
    	String  s2;
    	boolean s1,s3;
    	System.out.println("Enter two lines of text. ");
    	Scanner keyboard = new Scanner(System.in);
    	s1 = keyboard.nextBoolean();
    	s2 = keyboard.nextLine();
    	s3 = Boolean.parseBoolean(s2);
    	if(s1&&s3)
    		System.out.println("The two lines are equal.");
    	else
    		System.out.println("The two lines are not equal.");
    		
    	if (s1&&s3)
    		System.out.println("But the lines are equal, ignoring case.");
    	else
    		System.out.println("Lines are not equal, even ignoring case.");
    	
    }
    
    
    
    
}