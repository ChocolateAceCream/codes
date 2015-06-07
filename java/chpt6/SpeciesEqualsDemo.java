/**
 * @(#)SpeciesEqualsDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/10/15
 */


public class SpeciesEqualsDemo 
{

    public static void main() 
    {
    	Species s1 = new Species(), s2=new Species();
    	
    	s1.setSpecies("Klingon 0x",10,15);
    	s2.setSpecies("Klingon 0x",10,15);
    	
    	if(s1.equals(s2))
    		System.out.println("Match with the method equals.");
    	else
    		System.out.println("Do Not match with the method equals.");
    		
    	System.out.println("Now change one Klingon 0x to lowercase.");
    	s2.setSpecies("klingon ox",10,15);	//use lowercase
    	
    	if(s1.equals(s2))
    		System.out.println("Match with the method equals.");
    	else
    		System.out.println("Do Not match with the method equals.");
    	
    	
    	
    			
    	
    }
    
    
}