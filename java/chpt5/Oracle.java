/**
 * @(#)Oracle.java
 *
 *
 * @author 
 * @version 1.00 2014/9/29
 */

import java.util.Scanner;
public class Oracle 
{

    public String oldAnswer = " The answer is in your heart. ";
    public String newAnswer;
    public String question;
    
    public void chat()
    {
    	System.out.print("I am the oracle. ");
    	System.out.println("I will answer any one-line question.");
    	Scanner keyboard = new Scanner(System.in);
    	String response;
    	do
    	{
    		answer();
    		System.out.println("Do you wish to ask "+ "another question?");
    		response=keyboard.next();
    	
    		
    		
    	}while(response.equalsIgnoreCase("yes"));
    	System.out.println("The oracle will now rest.");
    	
    }
    public void answer()
    {
    	System.out.println("What is your question?");
    	Scanner keyboard = new Scanner(System.in);
    	question = keyboard.nextLine();
    	seekAdvice();
    	System.out.println("You asked the question:");
    	System.out.println(" "+ question);
    	System.out.println("Now, here is my answer: ");
    	System.out.println(" "+oldAnswer);
    	update();
    	
    }
    private void seekAdvice()
    {
    	System.out.println("Hmm, I need some help on that.");
    	System.out.println("Please give me one line of advice.");
    	Scanner keyboard = new Scanner(System.in);
    	newAnswer = keyboard.nextLine();
    	System.out.println("Thank you. That helped a lot.");
    }
    private void update()
    {
    	oldAnswer = newAnswer;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}