/**
 * @(#)PetPair.java
 *
 *
 * @author 
 * @version 1.00 2014/11/3
 */


public class PetPair 
{

    
    	private Pet first,second;
    	public PetPair(Pet firstPet,Pet secondPet)
    	{
    		first = firstPet;
    		second = secondPet;
    	}
    	public Pet getFirst()
    	{
    		return first;
    	}
    	public Pet getSecond()
    	{
    		return second;
    	}
    	public void writeOutput()
    	{
    		System.out.println("First pet in the pair:");
    		first.writeOutput();
    		System.out.println("Second pet in the pair");
    		second.writeOutput();
    	}
    		
    
    
    
}

