/**
 * @(#)LabelDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/10/4
 */


import javax.swing.JApplet;
import javax.swing.JLabel;
import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;

public class LabelDemo extends JApplet
{
	public void init()
	{
		Container contentPane = getContentPane();
		//The contentPane is an object of type container, which is a class defined fro you in the java class library.
		//The method getContentPane retrieves the applet's content pane. 
		//By giving the content pane a name, we can use this name instead of using getContentPane every time we want to do sth with it.
		contentPane.setBackground(Color.yellow);
		//creat labels:
		JLabel label1 = new JLabel("hello ");
		JLabel label2 = new JLabel("out there!");
		//add labels:
		contentPane.setLayout(new FlowLayout());
		//this statement says that the components will be arragned in left-to-right order as we add them to contentPane.
		contentPane.add(label1);
		contentPane.add(label2);
		
	}
}