
import javax.swing.JApplet;
import java.awt.Graphics;


public class HappyFace extends JApplet
{

    public void paint(Graphics gg)
    {
    	gg.drawOval(100,50,200,200);
    	gg.fillOval(155,100,10,20);
    	gg.fillOval(230,100,10,20);
    	gg.drawArc(150,160,100,50,180,180);
    }
    
    
}