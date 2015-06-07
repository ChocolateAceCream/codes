/**
 * @(#)Olympics.java
 *
 *
 * @author 
 * @version 1.00 2014/9/6
 */

import javax.swing.JApplet;
import java.awt.Graphics;

public class Olympics extends JApplet
{
	public void paint(Graphics gg)
	{
		gg.drawOval(50,50,100,100); 
		gg.drawOval(50+45,50+75,100,100); 
		gg.drawOval(50+45+45,50,100,100); 
		gg.drawOval(50+45+45+45,50+75,100,100); 
		gg.drawOval(50+45+45+45+45,50,100,100); 
		
	}

    
    
}