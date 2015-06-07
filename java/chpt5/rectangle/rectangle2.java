/**
 * @(#)rectangle2.java
 *
 *
 * @author 
 * @version 1.00 2014/9/27
 */


public class rectangle2 {

    public static void main(String[] args) 
    {
    	rectangle1 box = new rectangle1();
    	box.input(10,5);
    	int area=box.getArea();
    	System.out.printf("%d",area);
    }
    
    
}