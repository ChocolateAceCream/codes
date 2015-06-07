
import java.util.Scanner;   //gets the scanner class from the package (library) java.util
public class FirstProgram	// name of the class
{


    public static void main(String [] args)
    {
    	System.out.println("Hello out there.");		//sends output to screen
    	System.out.println("i will add two number")	;
    	System.out.println("Enter two whole numbers");
    	int n1, n2;
    	Scanner keyboard = new Scanner (System.in); 		//readies the program for keyboard input
    	n1 = keyboard.nextInt ();			//reads one whole number from the keyboard
    	n2 = keyboard.nextInt();
    	System.out.println("SUM is");
    	System.out.println(n1+n2);
    }



}