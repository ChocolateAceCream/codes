/**
 * @(#)SpeciesFirstTryDemo.java
 *
 *
 * @author
 * @version 1.00 2014/9/15
 */


public class SpeciesFirstTryDemo
{

    public static void main(String[] args)
    {
    	SpeciasFirstTry speciasOfTheMonth = new SpeciasFirstTry();
    	System.out.println("Enter data on the Species of "+"the Month:");
    	speciasOfTheMonth.readInput();
    	speciasOfTheMonth.writeOutput();
    	int futurePopulation = speciasOfTheMonth.getPopulationIn10();
    	System.out.println("In ten years the population will be "+futurePopulation);
    	//Change the species to show how to change
    	//the values of instance variables:
    	speciasOfTheMonth.name="Klingon ox";
    	speciasOfTheMonth.population = 10;
    	speciasOfTheMonth.growthRate = 15;
    	System.out.println("The new Species of the Month: ");
    	speciasOfTheMonth.writeOutput();
    	System.out.println("In ten years the population will be "+speciasOfTheMonth.getPopulationIn10());
    }


}