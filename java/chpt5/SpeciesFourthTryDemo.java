/**
 * @(#)SpeciesFourthTryDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/9/27
 */

import java.util.Scanner;
public class SpeciesFourthTryDemo {

    public static void main(String[] args) 
    {
    	SpeciesFourthTry speciesOfTheMonth = new SpeciesFourthTry();
    	System.out.println("Enter number of years to project:");
    	Scanner keyboard = new Scanner(System.in);
    	int numberOfYears = keyboard.nextInt();
    	System.out.println("Enter data on the Species of the Month:");
    	speciesOfTheMonth.readInput();
    	speciesOfTheMonth.writeOutput();
    	
    	int futurePopulation = speciesOfTheMonth.predictPopulation(numberOfYears);
    	System.out.println("In "+numberOfYears+"years the population will be "+futurePopulation);
    	//Change the species to show how to change the values of instance variables:
    	speciesOfTheMonth.setSpecies("Klingon ox",10,15);
    	speciesOfTheMonth.name = "GG";
    	
    	System.out.println("The new Species of the Month:");
    	speciesOfTheMonth.writeOutput();
    	futurePopulation=speciesOfTheMonth.predictPopulation(numberOfYears);
    	System.out.println("In "+numberOfYears+"yeas the population wil be "+futurePopulation);
    }
    
    
}