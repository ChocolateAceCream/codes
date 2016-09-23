/**
 * @(#)group.java
 *
 *
 * @author 
 * @version 1.00 2014/9/18
 */

import java.util.Scanner;

public class group 
{

     public static void main(String[] args)
     {
     		Scanner keyboard = new Scanner(System.in);
     		char choice;
     		
     	
			
     		do
      		{
           		System.out.println("Do you have an initial set? ==>(Y/N)\t");
           		choice =  keyboard.next().charAt(0);
           		
           		
           		System.out.flush();
      		}while(!((choice=='Y')||(choice=='y')||(choice=='n')||(choice=='N')));
     }
    
}