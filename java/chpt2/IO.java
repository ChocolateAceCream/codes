

import java.util.Scanner;   //gets the scanner class from the package (library) java.util
public class IO	// name of the class
{


    public static void main(String [] args)
    {
    	Scanner gg = new Scanner(System.in);
    	int n1 = gg.nextInt();		//read an int
    	System.out.println(n1);
    	
    	String s1 = gg.next();		//read a word
    	System.out.println(s1);		
    	
    		
    	String s2 = gg.next();		//read a word
    	String s3 = gg.next();	
    	System.out.println(s2+s3);
    }



}