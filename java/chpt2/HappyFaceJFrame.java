/**
 * @(#)HappyFaceJFrame.java
 *
 *
 * @author 
 * @version 1.00 2014/9/7
 */

import javax.swing.JFrame;
import java.awt.Graphics;

public class HappyFaceJFrame extends JFrame
{
	public static final int Face_Diameter = 200;
	public static final int X_Face = 100;
	public static final int Y_Face = 50;
	public static final int Eye_Width =10;
	public static final int	Eye_Height = 20;
	public static final int X_Right_Eye = 155;
	public static final int Y_Right_Eye = 100;
	public static final int X_Left_Eye = 230;
	public static final int Y_Left_Eye = Y_Right_Eye;
	public static final int Mouth_Width = 100;
	public static final int Mouth_Height = 50;
	public static final int X_Mouth = 150;
	public static final int Y_Mouth = 160;	
	public static final int Mouth_Start_Angle = 180;
	public static final int Mouth_Degrees_Shown = 180;
	
	public void paint(Graphics canvas)
	{
		canvas.drawOval (X_Face,Y_Face,Face_Diameter,Face_Diameter);
		canvas.fillOval(X_Right_Eye,Y_Right_Eye,Eye_Width,Eye_Height);
		canvas.fillOval(X_Left_Eye,Y_Left_Eye,Eye_Width,Eye_Height);
		canvas.drawArc(X_Mouth,Y_Mouth,Mouth_Width,Mouth_Height,Mouth_Start_Angle,Mouth_Degrees_Shown);
	}
	
	public HappyFaceJFrame()		//constructor:a place where we can place initialization code
	{
		setSize(500,300);			//creates a window that is 600x400
		setDefaultCloseOperation(EXIT_ON_CLOSE);	//tell java to exit the program if the window is closed
	
	}
	public static void main(String[] args)		//main method to display the window
	{
		HappyFaceJFrame guiWindow = new HappyFaceJFrame();
		guiWindow.setVisible(true);
	}

    
    
    
}
