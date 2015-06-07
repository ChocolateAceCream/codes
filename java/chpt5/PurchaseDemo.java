/**
 * @(#)PurchaseDemo.java
 *
 *
 * @author 
 * @version 1.00 2014/9/29
 */


public class PurchaseDemo {

    public static void main(String[] args) 
    {
    	Purchase oneSale = new Purchase();
    	oneSale.readInput();
    	oneSale.wirteOutput();
    	System.out.println("Cost each $ "+oneSale.getUnitCost());
    	System.out.println("Total cost $" + oneSale.getTotalCost());
    }
    
    
}