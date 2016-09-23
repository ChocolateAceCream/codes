/**
 * @(#)JOptionPane.java
 *
 *
 * @author
 * @version 1.00 2014/9/7
 */

import javax.swing.JOptionPane; //JOptionPane is a class used for producing special windows (called dialog windoes/boxes)
								//All input and output are strings
public class JOptionPaneDemo1
{
	public static void main(String[] args)
	{
		String appleString = JOptionPane.showInputDialog("enter number of apples:");
		int appleCount = Integer.parseInt(appleString);
		//parseInt is a method of the class integer,converts
		//the string stored in the variable appletString into corresponding integer number


		String orangeString = JOptionPane.showInputDialog("enter number of oranges:");
		int orangeCount = Integer.parseInt(orangeString);

		int total = appleCount+orangeCount;
		JOptionPane.showMessageDialog(null,"TOTAL IS "+total);
		System.exit(0);
	}


}