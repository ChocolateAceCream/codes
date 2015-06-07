/**
 * Assignment #2:
 *
 *Programmer: Di Sheng
 *
 *Due Date:10/13/2014
 *
 *CSCI125-W03, Fall 2014	Instructor: Parimal Patel
 *
 *Pledge: I have neither given nor received unauthorized aid on this program.
 *Description: This program promote users to deposite/withdraw such amount of money in account 1 or account 2, then programupdate will update 
 *			   the account balance and show up in the screen.   
 *Input: two stinrg choice of account and action(deposite/withdraw),  an integer of amount of money. 
 *Output: the updated account balance for both account
 *
 * 
 * @version 1.00 2014/10/08
 */


import javax.swing.JOptionPane; //JOptionPane is a class used for producing special windows (called dialog windoes/boxes)
								//All input and output are strings
public class JOptionPaneDemo1
{
  
  	 
	public static void main(String[] args)
	{
		int answer;
		double balance1=0.00,balance2=0.00;
	 do{
	 
		int choice1,choice2;	//choice 1 for choosing account, choice for choosing action(deposit/withdraw)
		
		double count;			//used to store the input value
		Object[] options1 ={ "Account1", "Account2" };  
		Object[] options2 ={ "Deposite", "Withdraw" };  	
		choice1 = JOptionPane.showOptionDialog(null, "Please select an account.", "Account",JOptionPane.YES_NO_OPTION, 
				JOptionPane.QUESTION_MESSAGE, null, options1, options1[0]);
		if(choice1 == 0)									//user chosed account1	
		{
		  
			choice2 = JOptionPane.showOptionDialog(null, "What can I do for you today?", "Account",JOptionPane.YES_NO_OPTION, 
			JOptionPane.QUESTION_MESSAGE, null, options2, options2[0]);
			if(choice2 == 0)								//action of deposite
			{
				
				String getInput = JOptionPane.showInputDialog("Please enter the amount of money");
				count = Double.parseDouble(getInput);
				
				balance1 = balance1+count;
				JOptionPane.showMessageDialog(null,"Account1 balance is "+balance1+"\nAccount2 balance is "+balance2);
			}
			else											//action of withdraw
			{
				String getInput = JOptionPane.showInputDialog("Please enter the amount of money");
				count = Double.parseDouble(getInput);
				if(count>balance1)
				{
						JOptionPane.showMessageDialog(null,"Not sufficient funds in your account, The max amount of money you could withdraw is "+balance1);
				}
				else
				balance1 = balance1-count;
				JOptionPane.showMessageDialog(null,"Account1 balance is "+balance1+"\nAccount2 balance is "+balance2);
			}
		}
		else 							//user chosed account2	
		{
			  
			choice2 = JOptionPane.showOptionDialog(null, "What can I do for you today?", "Account",JOptionPane.YES_NO_OPTION, 
			JOptionPane.QUESTION_MESSAGE, null, options2, options2[0]);
			if(choice2 == 0)								//action of deposite
			{
				
				String getInput = JOptionPane.showInputDialog("Please enter the amount of money");
				count = Double.parseDouble(getInput);
				balance2 = balance1+count;
				JOptionPane.showMessageDialog(null,"Account1 balance is "+balance1+"\nAccount2 balance is "+balance2);
			}
			else											//action of withdraw
			{
				String getInput = JOptionPane.showInputDialog("Please enter the amount of money");
				count = Double.parseDouble(getInput);
				if(count>balance2)
				{
						JOptionPane.showMessageDialog(null,"Not sufficient funds in your account, The max amount of money you could withdraw is "+balance2);
				}
				else
				balance2 = balance2-count;
				JOptionPane.showMessageDialog(null,"Account1 balance is "+balance1+"\nAccount2 balance is "+balance2);
			}
			
		}
		
		answer = JOptionPane.showConfirmDialog(null,"End program?","Click Yes or No: ",JOptionPane.YES_NO_OPTION);
		if(answer == 0)
			System.exit(0);
		else if(answer == 1)
			System.out.println("One more time");
	 }while(answer ==1);
		
	
   }


}