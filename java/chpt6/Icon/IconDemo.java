/**
 * @(#)IconDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/11/20
 */

import javax.swing.ImageIcon;
import javax.swing.JApplet;
import javax.swing.JLabel;

public class IconDemo extends JApplet 
{
    
    /** Initialization method that will be called after the applet is loaded
     *  into the browser.
     */
    public void init() 
    {
        // TODO start asynchronous download of heavy resources
        JLabel niceLabel = new JLabel("Java is fun!");
        ImageIcon dukeIcon = new ImageIcon("aa.txt");
        niceLabel.setIcon(dukeIcon);
        getContentPane().add(niceLabel);
    }

   
}