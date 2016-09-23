/**
 * @(#)PetDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/10/6
 */

import java.util.Scanner;
public class PetDemo {

    public static void main(String[] args) 
    {
    	Pet yourPet = new Pet("Jane Doe");
    	System.out.println("My records on your pet are inaccurate.");
    	System.out.println("Here is what thry currently say:" );
    	yourPet.writeOutput();
    	
    	Scanner keyboard = new Scanner(System.in);
    	System.out.println("Please enter the correct pet name: ");
    	String correctName = keyboard.nextLine();
    	yourPet.setName(correctName);
    	
    	System.out.println("Please neter the correct pet age: ");
    	int correctAge = keyboard.nextInt();
    	yourPet.setAge(correctAge);
    	
    	System.out.println("Please enter the correct pet weight: ");
    	double correctWeight = keyboard.nextDouble();
    	yourPet.setWeight(correctWeight);
    	
    	System.out.println("My updated records now say:");
    	yourPet.writeOutput();
    	
    }
    
    
    


}