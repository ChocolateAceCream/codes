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
 *Description: This program promote users to deposite/withdraw such amount of money in account 1 or account 2, then programupdate will update 
 *			   the account balance and show up in the screen.   
 *Input: Base pay and hours worked last week for each worker
 *Output: the gross pay for each worker
 *
 * 
 * @version 1.00 2014/10/08
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
		do
		{
 
			Object[] options ={ "Employee1", "Employee2","Employee3" };  //change the YES_NO_OPTION button contents, used for chooing account
			
			choice = JOptionPane.showOptionDialog(null, "Please select an Employee.", "Employee",JOptionPane.YES_NO_OPTION, 
			JOptionPane.QUESTION_MESSAGE, null, options, options[0]);		//ask user to choose an employee,store in choice	
			
			if(choice == 0)
			{
				hourPay = SalaryTest.getBasePay();
				hour=hgetHour();
				grossPay[choice]=hourPay*hour;				
				JOptionPane.showMessageDialog(null,"Employee 1 gorss pay is :$"+grossPay[choice]);				
			}
			if(choice == 1)
			{
				hourPay = getBasePay();
				hour=getHour();
				grossPay[choice]=hourPay*hour;				
				JOptionPane.showMessageDialog(null,"Employee 2 gorss pay is :$"+grossPay[choice]);				
			}
			if(choice == 2)
			{
				hourPay = this.getBasePay();
				hour=this.getHour();
				grossPay[choice]=hourPay*hour;				
				JOptionPane.showMessageDialog(null,"Employee 3 gorss pay is :$"+grossPay[choice]);				
			}			
			
			
			answer= JOptionPane.showConfirmDialog(null,"End program?","Click Yes or No: ",JOptionPane.YES_NO_OPTION);
			
			if(answer == 0)	//if user choose to quit 
			System.exit(0);
			
			else if(answer == 1)	//if user choose to continue
			System.out.println("One more time");
		}while(answer>0);	
	 
	}
    public double getBasePay()
    {
    		String basePay = JOptionPane.showInputDialog("Please enter the base pay:");
    	   	basePay = basePay.trim();
    	   	if(basePay.charAt(0)=='$')
    			basePay=basePay.substring(1);
    		basePay = basePay.trim();
    		double result = Double.parseDouble(basePay);
    	    while(result<8.00)
    	    {
    	    	JOptionPane.showMessageDialog(null,"Error, must enter a higher basePay");
    	    	basePay = JOptionPane.showInputDialog("Please re-enter the base pay:");
    	   		basePay = basePay.trim();
    	   		if(basePay.charAt(0)=='$')
    				basePay=basePay.substring(1);
    			basePay = basePay.trim();
    			double result = Double.parseDouble(basePay);
    	    }
    		return result;
    	
    }
    public double getHour()
    {
    	String workHour = JOptionPane.showInputDialog("Please enter the hours this employee worked last week:");   
    	double hours = Double.parseDouble(workHour);
    	while(hours>70)
    	{
    		JOptionPane.showMessageDialog(null,"Error, must enter a shorter time:");
    		workHour = JOptionPane.showInputDialog("Please enter the hours this employee worked last week:");
    		hours = Double.parseDouble(workHour); 
    	}
    	if(hours>40)
    	{
    		hours = (hours-40)*1.5+hours;
    	}
    	return hours;
    }
}











