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


import java.util.Scanner;   //gets the scanner class from the package (library) java.util

public class SavingAccountTest 
{
 	public static void main(String[] args) 
 	{
 		double deposit1,deposit2;			//used to store the current balance for two users
 		double interest1,interest2;			//used to store the temple interest for each month 
 
 		Scanner gg = new Scanner(System.in);
 		SavingAccount saver1 = new SavingAccount();		//creat new object saver1 under class SavingAccount
 		SavingAccount saver2 = new SavingAccount();
 		
 		System.out.println("Enter deposit amount for Saver 1:?");
 		deposit1=gg.nextDouble();						//get input balance from user and then update the balance for saver1
 		saver1.deposit(deposit1);
 		
 		
 		System.out.println("Enter deposit amount for Saver 2:?");	
 		deposit2=gg.nextDouble();						//get input balance from user and then update the balance for saver2
 		saver2.deposit(deposit2);
 		
 		System.out.println("Enter the interest rate(%) to calculate Balance:?");			
 		double interest =  gg.nextDouble();				//get annual interest from user and then update the annual interest for both user
 		saver1.getInterestRate(interest/100);
 		saver2.getInterestRate(interest/100);
 		
 		System.out.printf("\n\bOutput monthly balances for one year at %.2f%%",interest);	//print out result
 		System.out.printf("\n\nBalances:");
 		System.out.printf("\t\t\tSaver 1\t\t\t\tSaver 2\n");
 		System.out.printf("Base:\t\t\t\t$%.2f\t\t\t$%.2f",deposit1,deposit2);
 		
		int i;
		for(i=1;i<=12;i++)
		{
			System.out.printf("\nMonth %d  ",i);
			interest1 = saver1.calculateMonthlyInterest(saver1.returnBalance(),saver1.annualInterestRate);	//calculate interest rate for each month
 			interest2 = saver2.calculateMonthlyInterest(saver2.returnBalance(),saver2.annualInterestRate);
			saver1.deposit(interest1);																		//update current balance
			saver2.deposit(interest2);	
			
				
			saver1.output();
			saver2.output();
				
		}
		
		saver1.modifyInterestRate();			//change interst rate to 5%
		saver2.modifyInterestRate();
		
		System.out.printf("\n\nAfter setting interest rate to 5%%");
		System.out.printf("\n\nBalances for next month:\n");
		interest1 = saver1.calculateMonthlyInterest(saver1.returnBalance(),saver1.annualInterestRate);	//calculate monthly interst for next month
 		interest2 = saver2.calculateMonthlyInterest(saver2.returnBalance(),saver2.annualInterestRate);
		saver1.deposit(interest1);
		saver2.deposit(interest2);				//update balance
		
		System.out.printf("\t\t\tSaver 1\t\t\t\tSaver 2\n");	
		saver1.output();						//print out final result
		saver2.output();
		
 	}
}
















