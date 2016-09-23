

//import java.util.Scanner;   //gets the scanner class from the package (library) java.util
public class ffaa	// name of the class
{


    public static void main(String [] args)
    {
    	/*
    	Scanner gg = new Scanner(System.in);
    //	gg.useDelimiter("##");		//use the ## as the only delimiter to separate input
    	
    	int n1 = gg.nextInt();		//read an int
    	System.out.println(n1);
    	
    	String s1 = gg.next();		//read a word
    	System.out.println(s1);		
    	    		
    	String s2 = gg.next();		//read two words
    	String s3 = gg.next();	
    	System.out.println(s2+s3);   	
    	
    	String sentence = gg.nextLine();
    	System.out.println(sentence);    	
    	
    	byte b1 = gg.nextByte();	//read a byte
    	System.out.println(b1);
    	
    	boolean b2=gg.nextBoolean();	//read a boolean, not case sensitive
    	System.out.println(b2);
    	*/
    	
    	//Format of output
    	
    	double price =11239.5123;
    	System.out.printf("%6.2f",price);
    	System.out.printf("\n%6.2f",price);
    	//print a float number in a field of width 6 and two decimal point
    	//if the output requires more characters, then the field is autoly expanded to the exact size of output
    	//notice: use printf for formating, not use println
    }



}