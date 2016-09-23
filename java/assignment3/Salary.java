import javax.swing.JOptionPane; //JOptionPane is a class used for producing special windows (called dialog windoes/boxes)
public class Salary 
{

    public double getBasePay()
    {
    		String basePay = JOptionPane.showInputDialog("Please enter the base pay:");
    	   	basePay = basePay.trim();
    	   	if(basePay.charAt(0)=='$')
    			basePay=basePay.substring(1);	//if use enter the $ first, trim the string from the 2nd index.
    		basePay = basePay.trim();		//trim any blanks between $ and first number
    		double result = Double.parseDouble(basePay);//convert trimed string to double
    		
    	    while(result<8.00)	//if user enter wrong input, ask user re-enter, then re-do the process above
    	    {
    	    	JOptionPane.showMessageDialog(null,"Error, must enter a higher basePay");
    	    	basePay = JOptionPane.showInputDialog("Please re-enter the base pay:");
    	   		basePay = basePay.trim();
    	   		if(basePay.charAt(0)=='$')
    				basePay=basePay.substring(1);
    			basePay = basePay.trim();
    			result = Double.parseDouble(basePay);
    	    }
    		return result;
    	
    }
    public double getHour()
    {
    	String workHour = JOptionPane.showInputDialog("Please enter the hours this employee worked last week:");   
    	double hours = Double.parseDouble(workHour);
    	while(hours>70)			//if user enter wrong input, ask user re-enter, then re-do the process above
    	{
    		JOptionPane.showMessageDialog(null,"Error, must enter a shorter time:");
    		workHour = JOptionPane.showInputDialog("Please enter the hours this employee worked last week:");
    		hours = Double.parseDouble(workHour); 
    	}
    	if(hours>40)
    	{
    		hours = (hours-40)*1.5+hours; //total hours = 40 + (hours-40)*1.5
    	}
    	return hours;	//total hours(include overtimes)
    }
    
    
}