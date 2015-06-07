/**
 * @(#)DogDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/9/14
 */


public class DogDemo {

    public static void main (String[] args)
    {
    	Dog balto = new Dog();
    	//the 'new' operator returns the memory address of the object Dog.THe preceding java statement assigns this address to variable scooby
    	balto.name = "Balto";
    	balto.age = 8;
    	balto.breed = "Siberain Husky";
    	balto.writeOutput();
    	
    	Dog scooby = new Dog();
    	scooby.name = "Scooby";
    	scooby.age=42;
    	scooby.breed= "Great Dane";
    	System.out.println(scooby.name+" is a "+scooby.breed +".");
    	System.out.print("He is "+scooby.age+" years old, or ");
    	int humanYears = scooby.getAgeInHumanYears();
    	System.out.println(humanYears+"in human years. ");
    }
    
    
}