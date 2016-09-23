/**
 * @(#)MultipleBirths.java
 *
 *
 * @author 
 * @version 1.00 2014/9/12
 */

import java.util.Scanner;
public class MultipleBirths 
{

    public static void main(String[] args)
    {
    
    int numberOfBabies;
    System.out.print("Enter number of babies: ");
    Scanner keyboard = new Scanner(System.in);
    numberOfBabies = keyboard.nextInt();
    boolean EE = numberOfBabies>0;
    switch (numberOfBabies)
    {
    	case 1:
    		System.out.println("GG");
    		
    	case EE:
    		System.out.println("2");
    		break;
    	default:
    		System.out.println("sb");
    }
    
    }
}