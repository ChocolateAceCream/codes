/**
 * @(#)rectangle1.java
 *
 *
 * @author 
 * @version 1.00 2014/9/27
 */


public class rectangle1 {

    private int width;
    private int height;
    
    public void input(int newwidth,int newheight) 
    {
    	width = newwidth;
    	height = newheight;
    }
    public int getArea()
    {
    	return width*height;
    }
    
}