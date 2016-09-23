/**
 * @(#)Pet.java
 *
 *
 * @author 
 * @version 1.00 2014/10/6
 */


public class Pet 
{
	private String name;
	private int age;	//in years
	private double weight;	//in pounds
	

    public Pet() 
    {
    	name = "NO name yet. ";
    	age = 0;
    	weight = 0;
    }
    public Pet(String initialName, int initialAge,double initialWeight)
    {
    	name = initialName;
    	if((initialAge<0)||(initialWeight<0))
    	{
    		System.out.println("Erro: negative age or weight.");
    		System.exit(0);
    	}
    	else
    	{
    		age = initialAge;
    		weight=initialWeight;
    	}
    }
    
    public void setPet(String newName, int newAge, double newWeight)
    {
    	name = newName;
    	if((newAge<0)||(newWeight<0))
    	{
    		System.out.println("Erro: negative age or weight.");
    		System.exit(0);
    	}
    	else
    	{
    		age = newAge;
    		weight = newWeight;
    	}	
    }
    public Pet(String initialName)
    {
    	name = initialName;
    	age = 0;
    	weight = 0;
    }
    public void setName(String newName)
    {
    	name = newName;	//age and weight are unchanged.
    	
    }
    public Pet(int initialAge)
    {
    	name = "No name yet.";
    	weight = 0;
    	if(initialAge<0)
    	{
    		System.out.println("Erro: negative age or weight.");
    		System.exit(0);
    	}
    	else
    	{
    		age = initialAge;
    	}
    		
    }
    public void setAge(int newAge)
    {
    	if(newAge<0)
    	{
    		System.out.println("Erro: negative age or weight.");
    		System.exit(0);
    	}
    	else
    		age=newAge;
    		//name and weight are unchanged
    }
    public Pet(double initialWeight)
    {
    	name = "no name yet";
    	age = 0;
    	if(initialWeight<0)
    	{
    		System.out.println("Erro: negative age or weight.");
    		System.exit(0);
    	}
    	else
    		weight = initialWeight;
    		
    }
    public void setWeight(double newWeight)
    {
    	if(newWeight<0)
    	{
    		System.out.println("Erro: negative age or weight.");
    		System.exit(0);
    	}
    	else
    		weight = newWeight;
    }
    public String getName()
    {
    	return name;
    }
    public int getAge()
    {
    	return age;
    }
    public double getWeight()
    {
    	return weight;
    }
    public void writeOutput()
    {
    	System.out.println("Name: "+name);
    	
    	System.out.println("Age: "+age+" years");
    	
    	System.out.println("Weight: "+weight+" pounds");
    }
}






















