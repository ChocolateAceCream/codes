
import javax.swing.JApplet;
import java.awt.Graphics;

public class Moon extends JApplet
{

    public void paint(Graphics canvas) 
    {
    	canvas.drawArc(100,50,100,100,90,180);
    	canvas.drawArc(110,50,80,100,90,180);
    }
    
    
}

