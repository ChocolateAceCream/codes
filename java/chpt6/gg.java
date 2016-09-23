/**
 * @(#)gg.java
 *
 *
 * @author 
 * @version 1.00 2014/10/15
 */


public class gg {

    public static void main(String[] args) 
 	{
 		SavingsAccount.setInterestRate(0.01);
 		SavingsAccount mySavings = new SavingsAccount();
 		SavingsAccount yourSavings = new SavingsAccount();
 		System.out.println("I deposited $10.75.");
 		mySavings.deposit(10.75);
 		System.out.println("you deposited $75.");
 		yourSavings.deposit(75.00);
 		System.out.println("you deposited $55.");
    	yourSavings.deposit(75.00);
    	double cash = yourSavings.withdraw(15.75);
    	System.out.println("YOu withdrew $"+cash+".");
    	if(yourSavings.getBalance()>100.00)
    	{
    		System.out.println("You received interest.");
    		yourSavings.addInterest();
    	}
    	System.out.println("Your savings is $"+yourSavings.getBalance());
    	System.out.print("My savings is $");
    	SavingsAccount.showBalance(mySavings);
    	System.out.println();
    	int count = SavingsAccount.getNumberOfAccount();
    	System.out.println("We opened "+count+" savings accounts today.");
    
    }
    
    
    
}