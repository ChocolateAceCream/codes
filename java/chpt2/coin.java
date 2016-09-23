/**
 * @(#)coin.java
 *
 *
 * @author
 * @version 1.00 2014/9/8
 */


import javax.swing.JOptionPane;


public class coin
{
    public static void main(String[] args)
    {
    	String input = 	JOptionPane.showInputDialog("enter a whole number from 1 to 99\nIwill output"
    		+"a conbination of coins\nthat equals that amount of change");
		
		
		String gg = JOptionPane.showOptionDialog("GG",JOptionPane.YES_NO_CANCEL_OPTION,null,"FF","bb");
		
		
		
		
		
    	int amount = Integer.parseInt(input);
    	int a= amount/25;
    	amount =amount%25;
    	int b = amount/10;
    	amount = amount%10;
    	int c = amount/5;
    	amount = amount%5;


		/*
		 *result type				Method for converting
		 *byte						Byte.parseByte(String_To_Concert)
		 *short						Short.parseShort((String_To_Concert)
		 *int						Integer.parseInt(String_To_Concert)
		 *
		 *
		 */
    	JOptionPane.showMessageDialog(null," "+ input+"cents in coins can be given as :\n "
    		+a+" quarters \n "
    		+b+" dimes\n "
    		+c+" nickels and \n "
    		+amount+" pennies");
    	System.exit(0);
    }

}