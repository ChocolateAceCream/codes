/**
 * Assignment #3:
 *
 *Programmer: Di Sheng
 *
 *Due Date:11/03/2014
 *
 *CSCI125-W03, Fall 2014	Instructor: Parimal Patel
 *
 *Pledge: I have neither given nor received unauthorized aid on this program.
 *Description: This program promote users to enter the base pay and worked hour for an employee and then return the gross pay including overtimre   
 *Input: Base pay(>=$8) and hours worked (0-70)last week for each worker
 *Output: the gross pay for each worker
 *
 * 
 * @version 1.00 11/03/2014
 */

import javax.swing.JOptionPane; //JOptionPane is a class used for producing special windows (called dialog windoes/boxes)

public class SalaryTest 
{

   	public static void main(String[] args)
	{
	
		int answer;	
		int choice;	//select an employee;
		double hourPay;	
		double hour;
		double[] grossPay = new double[2];		
		Salary Money = new Salary();
		do
		{
 
			Object[] options ={ "Employee1", "Employee2","Employee3" };  //change the YES_NO_OPTION button contents, used for chooing account
			
			choice = JOptionPane.showOptionDialog(null, "Please select an Employee.", "Employee",JOptionPane.YES_NO_OPTION, 
			JOptionPane.QUESTION_MESSAGE, null, options, options[0]);		//ask user to choose an employee,store in choice	
			
			if(choice == 0)						//if user chosed 1st employee
			{
				hourPay = Money.getBasePay();	//get hour pay
				hour=Money.getHour();			//get worked hour
				grossPay[choice]=hourPay*hour;	//calculate gross pay								
				JOptionPane.showMessageDialog(null,String.format("Employee 1 gorss pay is :$%.2f",grossPay[choice]));	//show result			
			}
			if(choice == 1)
			{
				hourPay = Money.getBasePay();
				hour=Money.getHour();
				grossPay[choice]=hourPay*hour;				
				JOptionPane.showMessageDialog(null,String.format("Employee 2 gorss pay is :$%.2f",grossPay[choice]));				
			}
			if(choice == 2)
			{
				hourPay = Money.getBasePay();
				hour=Money.getHour();
				grossPay[choice]=hourPay*hour;				
				JOptionPane.showMessageDialog(null,String.format("Employee 3 gorss pay is :$%.2f",grossPay[choice]));	
			}			
			
			
				answer= JOptionPane.showConfirmDialog(null,"End program?","Click Yes or No: ",JOptionPane.YES_NO_OPTION);
				
				if(answer == 0)	//if user choose to quit 
				System.exit(0);
				
				else if(answer == 1)	//if user choose to continue
				System.out.println("One more time");
			}while(answer>0);	
	 
	}

}











