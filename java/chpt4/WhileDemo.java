/**
 * @(#)WhileDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/9/12
 */

import java.util.Scanner;
public class WhileDemo 
{

    

    public static void main (String[] args)
    {
    	int count, number;
    	System.out.println("input a number");
    	Scanner keyboard = new Scanner(System.in);
    	number = keyboard.nextInt();
    	
    	count = 1;
    	while (count<=number)
    	{
    		System.out.println(count + ", ");
    		count++;
    	}
    	System.out.println();
    	System.out.println("Buckle my shoe . ");
    	
    }
    
}