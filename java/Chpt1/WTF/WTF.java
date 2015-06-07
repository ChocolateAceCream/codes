
import javax.swing.JApplet;
import java.awt.Graphics;


public class WTF extends JApplet
{

    public void paint(Graphics gg) 
    {
    	gg.drawOval(300,300,100,100);
    	gg.fillOval(300+25,325,50,50);
    
    	gg.drawArc(300-50-50-50,300-25,150,150,270,180);
    	gg.drawArc(300+50+50,300-25,150,150,90,180);
    	gg.drawArc(300-25,300-150,150,150,180,180);
    	gg.drawArc(300-25,300+100,150,150,0,180);
    }
    
    
}