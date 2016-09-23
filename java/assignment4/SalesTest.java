/**
 * Assignment #4:
 *
 *Programmer: Di Sheng
 *
 *Due Date:11/24/2014
 *
 *CSCI125-W03, Fall 2014	Instructor: Parimal Patel
 *
 *Pledge: I have neither given nor received unauthorized aid on this program.
 *
 *Description: This program promote users to enter the the product number and quantity sold for and then return the retail value of product sold   
 *Input: product number(1-5) and quantity sold (>=0)
 *Output: theretail value of product sold
 *
 * 
 * @version 1.00 11/20/2014
 */

import java.util.Scanner;   //gets the scanner class from the package (library) java.util
import javax.swing.JOptionPane; //JOptionPane is a class used for producing special windows (called dialog windoes/boxes)

public class SalesTest {

    public static void main(String [] args)
    {
    	int number;		//used to store value for product number
    	int quantity;	//used to store value for quantity sold
    	double sum=0;	//used to store value for total retail value
    	int answer;		//used for loop option
    	Scanner gg = new Scanner(System.in);
 	  do
 	  {
 		
    	System.out.println("Enter product number ==> ");
    	number = gg.nextInt();
    	while(number>5||number<1)
    	{
    		System.out.println("Wrong input, try again ==> ");
    		number = gg.nextInt();
    	}
    	System.out.println("Enter quantity sold ==> ");
    	quantity = gg.nextInt();
    	while(quantity<0)
    	{
    		System.out.println("Wrong input, try again ==> ");
    		quantity = gg.nextInt();
    	}
    	switch(number)		//calculate total retail value
    	{
    		case 1:
    			sum = sum + 2.98*quantity;
    			break;
    		case 2:
    			sum = sum + 4.5*quantity;
    			break;
    		case 3:
    			sum = sum + 9.98*quantity;
    			break;
    		case 4:
    			sum = sum + 4.49*quantity;
    			break;
    		case 5:
    			sum = sum + 6.87*quantity;
    			break;			
    	}
    	
    	answer= JOptionPane.showConfirmDialog(null,"End program?","Click Yes or No: ",JOptionPane.YES_NO_OPTION);
			
			if(answer == 0)	//if user choose to quit 
			{
			
			JOptionPane.showMessageDialog(null,String.format("Your final total retail value of product sold is :$%.2f",sum));
			
			}
			
			else if(answer == 1)	//if user choose to continue
			{
			JOptionPane.showMessageDialog(null,String.format("Your current total retail value of product sold is :$%.2f",sum));
			
			System.out.println("One more time");
			}
		}while(answer>0);	
    }
    
}