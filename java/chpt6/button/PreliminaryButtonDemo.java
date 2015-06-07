/**
 * @(#)PreliminaryButtonDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/11/20
 */

import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JApplet;
import javax.swing.JButton;
import javax.swing.ImageIcon;

public class PreliminaryButtonDemo extends JApplet implements ActionListener
{
    
    public void init() 
    {
       Container contentPane = getContentPane();
       contentPane.setBackground(Color.WHITE);
       
       contentPane.setLayout(new FlowLayout());
       
       JButton sunnyButton = new JButton("Sunny");
       ImageIcon abc = new ImageIcon("111.jpg");
       sunnyButton.setIcon(abc);
       contentPane.add(sunnyButton);
       sunnyButton.addActionListener(this);
       
       JButton cloudyButton = new JButton("Cloudy");
       contentPane.add(cloudyButton);
       
       cloudyButton.addActionListener(this);
    }
    public void actionPerformed(ActionEvent e)
    {
    	Container contentPane = getContentPane();
    	if(e.getActionCommand().equals("Sunny"))
    		contentPane.setBackground(Color.BLUE);
    		
    	else if (e.getActionCommand().equals("Cloudy"))
    		contentPane.setBackground(Color.GRAY);
    	else
    		System.out.println("ERROR");
    }

  
}







