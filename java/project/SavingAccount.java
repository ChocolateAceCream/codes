/**
 * Course Final Project:
 *
 *Programmer: 	Group 1

				1) Sheng,Di

				2) Hsiao,Han-Tse

				3) Wang,Wen-Han

				4) Arpi,Luis M

				5) Backiel,Konrad
 *
 *Due Date:12/15/2014
 *
 *CSCI125-W03, Fall 2014	Instructor: Parimal Patel
 *
 *Pledge: we have neither given nor received unauthorized aid on this program.
 *
 *Description: This program promote users to input the current balance for two users and annual interest rate and then calculate the monthly balance for each user.
 *
 *deposite/withdraw such amount of money in account 1 or account 2, then programupdate will update 
 *			   the account balance and show up in the screen.   
 *Input: initial deposit amount for two users(double),annual interest rate % (x)e.g: input 4 means 4%
 *Output: the updated account balance of both users for 12 month
 *
 * 
 * @version 1.00 2014/10/08
 */


public class SavingAccount
{
	public static double annualInterestRate=0;

	private double balance = 0;

	
	public void getInterestRate(double interest)		//get an interest rate from user and store in annualInterestRate
	{
	 	 annualInterestRate =  interest;
	}
	
	public static void modifyInterestRate()				//set annualInterestRate to 5%
	{
	 	 annualInterestRate =  0.05;
	}
	
	public void deposit(double amount)					//update balance
    {
    	balance=balance+amount;
    }
    public double calculateMonthlyInterest(double balance, double annualInterestRate)	//calculate the monthly interest using current balance and interest rate
    {
    	return  balance*(annualInterestRate/12);
    }
    public void output()								//print out the current balance
    {
    	System.out.printf("\t\t\t$%.2f ",balance);
    	
    }
    public double returnBalance()						//extract current balance to calculate monthly interest
    {
    	return balance;
    }
 
    
}