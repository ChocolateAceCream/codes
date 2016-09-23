/**
 * @(#)VisibilityDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/11/20
 */

import javax.swing.ImageIcon;
import javax.swing.JApplet;
import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class VisibilityDemo extends JApplet implements ActionListener 
{
    
    /** Initialization method that will be called after the applet is loaded
     *  into the browser.
     */
     private JLabel response;
     private Container contentPane;
     
     
    public void init() 
    {
        // TODO start asynchronous download of heavy resources
        contentPane = getContentPane();
        contentPane.setBackground(Color.WHITE);
        //creat button:
        JButton aButton = new JButton("Push me!");
        aButton.addActionListener(this);
        //creat label
        response = new JLabel("Thanks, that felt good!");
        ImageIcon smile = new ImageIcon("217ea277.gif");
        response.setIcon(smile);
        response.setVisible(false);
        //invisible until button is clicked
        
        //add button:
        contentPane.setLayout(new FlowLayout());
        contentPane.add(aButton);
        //add label
        contentPane.add(response);
        
    }
    public void actionPerformed(ActionEvent e)
    {
    	contentPane.setBackground(Color.PINK);
    	response.setVisible(true);	//show label
    }

}






